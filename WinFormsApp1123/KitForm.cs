namespace WinFormsApp1123
{
    public partial class KitForm : Form
    {
        public KitForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Awaiting validation that name is unique
            if (textBox1.Text.Equals(""))
                MessageBox.Show("Kit Name is a required field", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox2.Text.Equals(""))
                MessageBox.Show("Kit Description is a required field", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Awating SQL Connection
            MessageBox.Show("Kit Submitted Successfully");
        }
    }
}
