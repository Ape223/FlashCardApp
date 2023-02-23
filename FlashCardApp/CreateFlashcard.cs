using System.Text.Json;
namespace FlashCardApp
{
    public partial class CreateFlashcard : Form
    {
        public CreateFlashcard()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Creates a new deck of flashcards
            List<Flashcard> deck = new List<Flashcard>();
            foreach(Flashcard x in listBox1.Items)
            {
                deck.Add(x);
            }
            string serialize = JsonSerializer.Serialize(deck);

            SaveFileDialog saveDialog = new SaveFileDialog();
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
#pragma warning disable CS8604 // Possible null reference argument.
            Flashcard flashcard = new Flashcard(term.Text, definition.Text, Convert.ToString(DateTime.Today));
#pragma warning restore CS8604 // Possible null reference argument.
            if (term.Text == "" || definition.Text == "")   
            {
                MessageBox.Show("You cannot saved an empty flashcard!", "Warning: Empty flashcard");
                return;
            }
            else
            {
                listBox1.Items.Add(flashcard);
                //Remove items from t and d for user friendliness
                term.Text = "";
                definition.Text = "";
            }
        }

            private void loadDeck_Click(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
                OpenFileDialog open1 = new OpenFileDialog();
                open1.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";
                if (open1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string serialise = File.ReadAllText(open1.FileName);
                        MessageBox.Show("Flashcard set loaded succesfully!", "Success");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        List<Flashcard> deck = JsonSerializer.Deserialize<List<Flashcard>>(serialise);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        foreach(Flashcard x in deck)
                    {
                        listBox1.Items.Add(x);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while trying to load the flashcard set.\n\nException message: " + ex.Message, "Warning: Deck not loaded");
                    }
                }
            }
            
            //Changes the font of the text,
            //Currently does not save, maybe remove later?
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                //https://stackoverflow.com/questions/19834635/how-to-set-textbox-font-size-in-c
               // Font fnt = new Font(term.Font.FontFamily, Convert.ToInt32(comboBox1.Text));
                //term.Font = fnt;
               // definition.Font = fnt;
            }
        //Event handler for when the user removes a card from the deck.
        //Gets the position of the card specified, then removes it from the list box.
        private void removeCard_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }
        private void CreateFlashcard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.Items.Count > 0)
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

        private void CreateFlashcard_Load(object sender, EventArgs e)
        {

        }
    }   
}
