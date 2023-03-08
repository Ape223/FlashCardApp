using System.Text.Json;
using FlashCardApp;
namespace FlashCardApp
{
    public partial class StudyDeck : Form
    {
        private string fileName;
        //A list of all the decks that have been loaded
        private List<Flashcard[]> decks = new List<Flashcard[]>();
        //A list of all the cards available for study
        private DoublyLinkedList allCards = new DoublyLinkedList();
        //Keeps track of the current card that needs to be shown
        private int current = 0;
        private string dirpath = Path.Combine(Main.desktopPath, "Flashcard decks");
        public StudyDeck()
        {
            InitializeComponent();
            easy.Visible = medium.Visible = hard.Visible = false;
            card.BackColor = Color.LightGray;
        }
        //Loads deck from the user's computer, then adds all cards to the allcards list.
        //Adds an indicator to the listbox1 control indicating the name of the deck and how many cards have been loaded.
        //Then, the first card in allcards is loaded into the button.
        private void LoadDeck_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";
            open1.InitialDirectory = dirpath;   
            if (open1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Flashcard> temp = new List<Flashcard>();
                    fileName = Path.GetFileName(open1.FileName);
                    string serialise = File.ReadAllText(open1.FileName);
                    MessageBox.Show("Flashcard deck loaded succesfully!", "Success");
                    Flashcard[] deck = JsonSerializer.Deserialize<Flashcard[]>(serialise);
                    decksList.Items.Add($"{fileName.Replace(".json", "")}: {Convert.ToString(deck.Length)} cards");
                    decks.Add(deck);
                    foreach(Flashcard f in deck)
                    {
                        if (f.DateReview > DateTime.Now)
                        {
                           //do nothing
                        }
                        else
                        {
                            temp.Add(f);
                        }
                    }
                    temp = mergesort(temp);
                    foreach (Flashcard f in temp)
                    {
                        allCards.Queue(f);
                    }
                    showTerm(allCards, current);
                    currCard.Text = $"Current card: {current+1} of {allCards.Count()}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while trying to load the flashcard deck.\n\nException message: " + ex.Message, "Warning: Deck not loaded");
                }
                label2.Text = ($"Cards loaded: {allCards.Count()}");
            }
        }
        //Card with the earliest review date needs to be reviewed first
        private List<Flashcard> mergesort(List<Flashcard> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }
            else
            {
                int mid = (unsorted.Count + 1) / 2;
                List<Flashcard> front = unsorted.Take(mid).ToList();
                List<Flashcard> back = unsorted.Skip(mid).ToList();
                front = mergesort(front);
                back = mergesort(back);
                return merge(front, back);
            }
        }
        //https://www.futurelearn.com/info/courses/programming-102-think-like-a-computer-scientist/0/steps/53115
        private List<Flashcard> merge(List<Flashcard> list_a, List<Flashcard> list_b)
        {
            List<Flashcard> sorted = new List<Flashcard>();
            while (list_a.Count > 0 && list_b.Count > 0)
            {
                if (list_a[0].DateReview < list_b[0].DateReview)
                {
                    sorted.Add(list_a[0]);
                    list_a.RemoveAt(0);
                }
                else
                {
                    sorted.Add(list_b[0]);
                    list_b.RemoveAt(0);
                }
                if (list_a.Count < 1)
                {
                    sorted.AddRange(list_b);
                }
                else if (list_b.Count < 1)
                {
                    sorted.AddRange(list_a);
                }
            }
            return sorted;
        }
        private void RemoveDeck_Click(object sender, EventArgs e)
        {
            //Either get the index of the list of cards and then remove cards from there with how many cards are in the specific deck
            //Will not work after a shuffle
            //Or store all cards as a list of individual sets
            //Will have to create new variables based on what the user loads
            if (decksList.Items.Count != 0)
            {
                int selectedIndex = decksList.SelectedIndex;
                string filename = decksList.SelectedItem.ToString().Substring(0, decksList.SelectedItem.ToString().IndexOf(":")) + ".json";
                List<Flashcard> temp = new List<Flashcard>();
                foreach (Flashcard x in decks[selectedIndex])
                {
                    allCards.remove(x);
                    temp.Add(x);
                }
                decksList.Items.RemoveAt(selectedIndex);
                label2.Text = ($"Cards loaded: {allCards.Count}");
                //save
                string serialize = JsonSerializer.Serialize(temp);
                string fullfile = Path.Combine(dirpath, filename);
                File.WriteAllText(fullfile, serialize);
            }
            if (decksList.Items.Count == 0)
            {
                label2.Text = ("Cards loaded: 0");
                allCards.delAll();
            }

        }

        private void card_Click(object sender, EventArgs e)
        {
            if (card.Text == "")
            {
                MessageBox.Show("No cards loaded!", "Warning: Empty list");
            }
            else
            {
                if (card.Text == allCards.index(current).Term.ToString())
                {
                    card.Text = allCards.index(current).Definition.ToString();
                    easy.Visible = medium.Visible = hard.Visible = true;
                    card.Enabled = false;
                }
                else
                {
                    showTerm(allCards, current);
                }
            }
        }
        private void showTerm(DoublyLinkedList allCards, int current)
        {
            card.Text = allCards.index(current).Term.ToString();
            easy.Visible = medium.Visible = hard.Visible = false;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            card.Enabled = true;
            if (current > 0)
            {
                current = current - 1;
                showTerm(allCards, current);
            }
            else
            {
                current = allCards.Count() - 1;
                showTerm(allCards, current);
            }
            currCard.Text = $"Current card: {current + 1} of {allCards.Count()}";
        }

        private void next_Click(object sender, EventArgs e)
        {
            card.Enabled = true;
            int temp = allCards.Count();
            if (current == temp - 1)
            {
                current = 0;
                showTerm(allCards, current);
            }
            else
            {
                current = current + 1;
                showTerm(allCards, current);
            }
            currCard.Text = $"Current card: {current+1} of {allCards.Count()}";
        }

        private void StudyDeck_FormClosing(object sender, FormClosingEventArgs e)
        {
            //saves all loaded decks
            if (decksList.Items.Count != 0)
            {
                MessageBox.Show("All decks need to be unloaded before closing the program.");
                e.Cancel = true;
            }
            else
            {
                var z = new Main();
                z.Show();
            }
        }

        private void easy_Click(object sender, EventArgs e)
        {
            allCards.index(current).SM2(allCards.index(current), 1);
        }
        private void medium_Click(object sender, EventArgs e)
        {
            allCards.index(current).SM2(allCards.index(current), 3);
        }
        private void hard_Click(object sender, EventArgs e)
        {
            allCards.index(current).SM2(allCards.index(current), 5);
        }

        private void StudyDeck_Load(object sender, EventArgs e)
        {

        }

        private void card_EnabledChanged(object sender, EventArgs e)
        {
            card.BackColor = Color.LightGray;
        }
    }
}