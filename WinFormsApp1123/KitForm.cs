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
            Program.Command.Connection = Program.Connection;
            Program.Command.CommandText = "insert into KitInfo(name,description) values(@name,@description)";
            Program.Command.Parameters.Clear();
            Program.Command.Parameters.AddWithValue("@name",textBox1.Text);
            Program.Command.Parameters.AddWithValue("@description", textBox2.Text);
            if(Program.Command.ExecuteNonQuery() > 0)
                MessageBox.Show("Kit Submitted Successfully", "Submission",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Oops Something Went Wrong", "Submission", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
