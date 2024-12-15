namespace WinFormsApp1123
{
    public partial class ReviewContract : Form
    {
        SortedDictionary<int, int> dic;
        FileStream text;
        StreamReader textreader;
        StreamWriter textwriter;
        public ReviewContract()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.Command.Connection = Program.Connection;
            Program.Command.CommandText = "select * from Contract";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Awaiting Implementation
        }
    }
}