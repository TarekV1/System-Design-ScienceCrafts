using System.Data.SqlClient;

namespace WinFormsApp1123
{
    public partial class ReviewContract : Form
    {
        SortedDictionary<int, int> dic;
        FileStream text;
        StreamReader textreader;
        StreamWriter textwriter;
        List<List<string>> list = new List<List<string>>();
        public ReviewContract()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.Command.Connection = Program.Connection;
            Program.Command.CommandText = "select * from Contract";
            SqlDataReader reader = Program.Command.ExecuteReader();
            List<string> arr;
            while (reader.Read())
            {
                arr = new List<string>(3);
                arr.Add(reader.GetInt32(0).ToString());
                arr.Add(reader.GetString(1));
                arr.Add((reader.GetDateTime(2)).ToString());
                list.Add(arr);
                comboBox1.Items.Add((reader.GetInt32(0)).ToString());
                //comboBox2.Items.Add(reader.GetString(1));
                //comboBox3.Items.Add((reader.GetDateTime(2)).ToString());
            }
            reader.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Awaiting Implementation
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = list[comboBox1.SelectedIndex][1];
            textBox2.Text = list[comboBox1.SelectedIndex][2];
        }
    }
}