﻿using System;
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
        public Order_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Submitted", "Success");
            //Awaiting SQL
        }

        private void calcPrice(object sender, EventArgs e)
        {
            //Awaiting Implementation
            double price = 1.0 / 0;
            label5.Text = $"Price : {price}";
        }
    }
}
