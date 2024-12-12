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
    public partial class EmployeeMain : Form
    {
        public EmployeeMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roleCheck().Equals("Admin"))
            {
                this.Hide();
                new ReviewContract().ShowDialog();
                this.Show();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                this.Hide();
                new KitForm().ShowDialog();
                this.Show();
        }
        public string roleCheck()
        {
            //Awaiting Implementation
            return "Admin";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (roleCheck().Equals("Admin"))
            {
                this.Hide();
                new StaffInfo().ShowDialog();
                this.Show();
            }
        }
    }
}
