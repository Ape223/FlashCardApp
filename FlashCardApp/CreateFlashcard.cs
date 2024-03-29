﻿using System.Text.Json;
namespace FlashCardApp
{
    public partial class CreateFlashcard : Form
    {
        private string desktopPath = Main.desktopPath;
        public CreateFlashcard()
        {
            InitializeComponent();
            
    }

        private void save_Click(object sender, EventArgs e)
        {
            //Creates a new deck of flashcards
            List<Flashcard> deck = new List<Flashcard>();
            foreach(Flashcard x in cardList.Items)
            {
                deck.Add(x);
            }
            string serialize = JsonSerializer.Serialize(deck);

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = Path.Combine(desktopPath, "Flashcard decks");
            saveDialog.Title = "Please save only in THIS folder!";
            saveDialog.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK) // Ok button was pressed on the save dialog, save the JSON text
            {
                try
                {
                    File.WriteAllText(saveDialog.FileName, serialize);

                    MessageBox.Show("Flashcard set saved succesfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while trying to save the flashcard set.\n\nException message: " + ex.Message, "Warning: Deck not saved");
                }
            }
        }
        //Event handler for the addCard control.
            //Creates a new flashcard object and adds it to the listbox on the right side of the screen
            private void addCard_Click(object sender, EventArgs e)
        {
            Flashcard flashcard = new Flashcard(termText.Text, definitionText.Text, DateTime.Today);
            if (termText.Text == "" || definitionText.Text == "")   
            {
                MessageBox.Show("You cannot saved an empty flashcard!", "Warning: Empty flashcard");
                return;
            }
            else
            {
                cardList.Items.Add(flashcard);
                //Remove items from t and d for user friendliness
                termText.Text = "";
                definitionText.Text = "";
            }
        }

            private void loadDeck_Click(object sender, EventArgs e)
            {
                cardList.Items.Clear();
                OpenFileDialog open1 = new OpenFileDialog();
                open1.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";
                if (open1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string serialise = File.ReadAllText(open1.FileName);
                        MessageBox.Show("Flashcard set loaded succesfully!", "Success");
                        List<Flashcard> deck = JsonSerializer.Deserialize<List<Flashcard>>(serialise);
                        foreach(Flashcard x in deck)
                    {
                        cardList.Items.Add(x);
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while trying to load the flashcard set.\n\nException message: " + ex.Message, "Warning: Deck not loaded");
                    }
                }
            }

        //Gets the position of the card specified, then removes it from the list box.
        private void removeCard_Click(object sender, EventArgs e)
        {
            int selectedIndex = cardList.SelectedIndex;
            if (cardList.SelectedIndex >= 0)
            {
                cardList.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }
        private void CreateFlashcard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cardList.Items.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to exit the window? All items in the set will be lost.", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            var a = new Main();
            a.Show();
        }
        private void clearCards_Click(object sender, EventArgs e)
        {
            cardList.Items.Clear();
        }

        private void CreateFlashcard_Load(object sender, EventArgs e)
        {

        }
    }   
}
