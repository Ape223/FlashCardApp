using System.Text.Json;
namespace FlashCardApp
{
    public partial class StudyDeck : Form
    {
        string fileName;
        //A list of all the decks that have been loaded
        List<Flashcard[]> decks = new List<Flashcard[]>();
        //A list of all the cards available for study
        List<Flashcard> allCards = new List<Flashcard>();
        //Keeps track of the current card that needs to be shown
        int current = 0;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public StudyDeck()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            easy.Visible = medium.Visible = hard.Visible = false;
        }
        //Loads deck from the user's computer, then adds all cards to the allcards list.
        //Adds an indicator to the listbox1 control indicating the name of the deck and how many cards have been loaded.
        //Then, the first card in allcards is loaded into the button.
        private void LoadDeck_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = Path.GetFileName(open1.FileName);
                    string serialise = File.ReadAllText(open1.FileName);
                    MessageBox.Show("Flashcard deck loaded succesfully!", "Success");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    Flashcard[] deck = JsonSerializer.Deserialize<Flashcard[]>(serialise);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    listBox1.Items.Add($"{fileName.Replace(".json", "")}: {Convert.ToString(deck.Length)} cards");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    decks.Add(deck);
                    allCards.AddRange(deck);
                    showTerm(allCards, current);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while trying to load the flashcard deck.\n\nException message: " + ex.Message, "Warning: Deck not loaded");
                }
                label2.Text = ($"Cards loaded: {allCards.Count}");
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
                if (System.DateTime.Parse(list_a[0].DateReview) < System.DateTime.Parse(list_b[0].DateReview))
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
            int selectedIndex = listBox1.SelectedIndex;
            foreach (Flashcard x in decks[selectedIndex])
            {
                    allCards.Remove(x);
            }
            listBox1.Items.RemoveAt(selectedIndex);
            label2.Text = ($"Cards loaded: {allCards.Count}");
            //save
            string serialize = JsonSerializer.Serialize(decks[selectedIndex]);
            File.WriteAllText(fileName, serialize);
            MessageBox.Show("Flashcard set saved succesfully!", "Success");
        }

        private void card_Click(object sender, EventArgs e)
        {
            if (card.Text == "")
            {
                MessageBox.Show("No cards loaded!", "Warning: Empty list");
            }
            else
            {
                if (card.Text == allCards[current].Term.ToString())
                {
                    card.Text = allCards[current].Definition.ToString();
                    easy.Visible = medium.Visible = hard.Visible = true;
                }
                else
                {
                    showTerm(allCards, current);
                }
            }
        }
        private void showTerm(List<Flashcard> allCards, int current)
        {
            card.Text = allCards[current].Term.ToString();
            easy.Visible = medium.Visible = hard.Visible = false;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                current = current - 1;
                showTerm(allCards, current);
            }
            else
            {
                MessageBox.Show("This is the first card!", "Warning: Out of range");
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (current == allCards.Count-1)
            {
                current = 0;
                showTerm(allCards, current);
            }
            else
            {
                current = current + 1;
                showTerm(allCards, current);
            }
        }

        private void StudyDeck_FormClosing(object sender, FormClosingEventArgs e)
        {
            var z = new Main();
            z.Show();
            //saves all loaded decks
            string serialize = JsonSerializer.Serialize(allCards);
                try
                {
                    File.WriteAllText(fileName, serialize);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while trying to save the flashcard set.\n\nException message: " + ex.Message, "Warning: Deck not saved");
                }
        }
        private string change_next_review(int current, int level)
        {
            DateTime previousreview = DateTime.Parse(allCards[current].DateReview);
            switch (level)
            {
                case 1:
                    previousreview = previousreview.AddDays(1);
                    break;
                case 2:
                    previousreview = previousreview.AddDays(7);
                    break;
                case 3:
                    previousreview = previousreview.AddDays(14);
                    break;
                default:
                    MessageBox.Show("An error occured whilst changing the date of next review", "Warning: switch statement error");
                    break;
            }
            return previousreview.ToString();
        }
        private void easy_Click(object sender, EventArgs e)
        {
            string newdate = change_next_review(current, 1);
            allCards[current].DateReview = newdate;
        }
        private void medium_Click(object sender, EventArgs e)
        {
            string newdate = change_next_review(current, 2);
            allCards[current].DateReview = newdate;
        }
        private void hard_Click(object sender, EventArgs e)
        {
            string newdate = change_next_review(current, 3);
            allCards[current].DateReview = newdate;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudyDeck_Load(object sender, EventArgs e)
        {

        }
    }
}
