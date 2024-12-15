using System.Data.SqlClient;

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
            SqlDataReader reader = Program.Command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add((reader.GetInt32(0)).ToString());
                comboBox2.Items.Add(reader.GetString(1));
                comboBox3.Items.Add((reader.GetDateTime(2)).ToString());
            }
            reader.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Awaiting Implementation
        }
    }
}