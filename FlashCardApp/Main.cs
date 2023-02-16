namespace FlashCardApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = new Login();
            a.Show();
            this.Dispose();
        }
    }
}