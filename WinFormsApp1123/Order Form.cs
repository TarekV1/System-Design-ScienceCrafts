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
    public partial class Order_Form : Form
    {
        int price1;
        int price2;
        int price3;
        public Order_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Command.Connection = Program.Connection;
            Program.Command.CommandText = "insert into [order](email,phone_number,category,courses,services,price)" +
                " values(@email,@phone_number,@category,@courses,@services,@price)";
            Program.Command.Parameters.Clear();
            Program.Command.Parameters.AddWithValue("@email", textBox1.Text);
            Program.Command.Parameters.AddWithValue("@phone_number", textBox2.Text);
            Program.Command.Parameters.AddWithValue("@category", comboBox1.SelectedItem.ToString());
            Program.Command.Parameters.AddWithValue("@courses", comboBox2.SelectedItem.ToString());
            Program.Command.Parameters.AddWithValue("@services", comboBox3.SelectedItem.ToString());
            Program.Command.Parameters.AddWithValue("@price", price1 + price2 + price3);
            int exc = Program.Command.ExecuteNonQuery();
            if (exc > 0)
            {
                MessageBox.Show("Order Submitted", "Success");
            }
            else
            {
                MessageBox.Show("Oops !\n Something Went Wrong", "Error");
            }

        }

        private void calcPrice(object sender, EventArgs e)
        {
            label5.Text = $"Price : {price1 + price2 + price3}";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Educational"))
                price1 = 15000;
            else if (comboBox1.SelectedItem.ToString().Equals("Entertainment"))
                price1 = 20000;
            else
                price1 = 30000;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString().Equals("Physics"))
                price2 = 12525;
            else if (comboBox2.SelectedItem.ToString().Equals("Communicational Skills"))
                price2 = 22250;
            else
                price2 = 36900;
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString().Equals("Trainning"))
                price3 = 27500;
            else if (comboBox3.SelectedItem.ToString().Equals("Sessions"))
                price3 = 25625;
            else
                price3 = 57357;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
