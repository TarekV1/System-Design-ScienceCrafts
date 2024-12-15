using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1123
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into Staff (name,email,password,phone_number,address) values(@name,@email,@password,@phone_number,@address)";
            string name = Name_tx.Text;
            string email = email_tx.Text;
            string password = password_tx.Text;
            string phonenum = phonenum_tx.Text;
            string address = address_tx.Text;
            Program.Command.CommandText = query;
            Program.Command.Connection = Program.Connection;
            Program.Command.Parameters.AddWithValue("@name", name);
            Program.Command.Parameters.AddWithValue("@email", email);
            Program.Command.Parameters.AddWithValue("@password", password);
            Program.Command.Parameters.AddWithValue("@phone_number", phonenum);
            Program.Command.Parameters.AddWithValue("@address", address);

            int rowsaffected = Program.Command.ExecuteNonQuery();
            MessageBox.Show(rowsaffected > 0 ? "insert successful" : "insert unsuccessful", "Insertion");
        }
    }
}
