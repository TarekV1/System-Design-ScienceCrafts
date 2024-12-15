using WinFormsApp1123;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_credientials(Email_tx.Text, Password_tx.Text))
            {
                MessageBox.Show("Login Succesfull", "Login Succesfull");
                this.Hide();
                new EmployeeMain().ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Wrong username or password", "Error");
        }
        public bool check_credientials(string username, string password)
        {
            //Awaiting Implementation
            Email_tx_Validating(new object(), new System.ComponentModel.CancelEventArgs());
            Password_tx_Validating(new object(), new System.ComponentModel.CancelEventArgs());
            return true;
        }

        private void Email_tx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Email_tx.Text.Equals(""))
                MessageBox.Show("Email is a required field", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Password_tx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Password_tx.Text.Equals(""))
                MessageBox.Show("Password is a required field", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Email_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
            this.Show();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }
    }
}