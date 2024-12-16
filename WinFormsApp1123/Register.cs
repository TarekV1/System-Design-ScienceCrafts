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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Command.Connection = Program.Connection;
            Program.Command.CommandText = "insert into Staff (name,email,password,phone_number,address) " +
                "values(@name,@email,@password,@phone_number,@address)";
            Program.Command.Parameters.Clear();
            Program.Command.Parameters.AddWithValue("@name", Name_tx.Text);
            Program.Command.Parameters.AddWithValue("@email", email_tx.Text);
            Program.Command.Parameters.AddWithValue("@password", password_tx.Text);
            Program.Command.Parameters.AddWithValue("@phone_number", phonenum_tx.Text);
            Program.Command.Parameters.AddWithValue("@address", address_tx.Text);

            int rowsaffected = Program.Command.ExecuteNonQuery();
            if (MessageBox.Show(
                rowsaffected > 0 ? "Register successful\nGo back?" : "Register unsuccessful\nGo back?",
                "Insertion",
                MessageBoxButtons.YesNo).Equals(DialogResult.Yes)
                )
            {
                this.Close();
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
