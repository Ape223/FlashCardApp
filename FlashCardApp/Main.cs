namespace FlashCardApp
{
    public partial class Main : Form
    {
        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Main()
        {
            InitializeComponent();
            this.Hide();
            createFile();
        }
        private void createFile()
        {
            string dir = "Flashcard decks";
            string dirpath = Path.Combine(desktopPath, dir);
            if (!Directory.Exists(dirpath))
            {
                Directory.CreateDirectory(dirpath);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var a = new StudyDeck();
            a.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new CreateFlashcard();
            m.Show();
            this.Dispose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}