using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1123
{
    public partial class StaffInfo : Form
    {
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Awaiting Implementation
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            Program.Command.Connection = Program.Connection;
            Program.Command.CommandText = "select * from Staff";
            SqlDataReader reader = Program.Command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add((reader.GetInt32(0)).ToString());
            }
            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Command.Connection = Program.Connection;
            Program.Command.CommandText = "select * from Staff where Id = @Id";
            Program.Command.Parameters.Clear();
            Program.Command.Parameters.AddWithValue("@Id", int.Parse(comboBox1.SelectedItem.ToString()));
            SqlDataReader reader = Program.Command.ExecuteReader();
            reader.Read();
            textBox1.Text = reader.GetString(1);
            textBox2.Text = reader.GetString(2);
            textBox3.Text = reader.GetString(4);
            textBox4.Text = reader.GetString(5);
            textBox5.Text = reader.GetString(7);
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
