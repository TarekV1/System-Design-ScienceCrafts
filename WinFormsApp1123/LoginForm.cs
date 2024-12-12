using WinFormsApp1123;

namespace _5RYA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_credientials(UserName_tx.Text, Password_tx.Text))
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
            return true;
        }

        private void Password_tx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}