using System.Data.SqlClient;
using WinFormsApp1123;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string name;
        private string role;
        private void button1_Click(object sender, EventArgs e)
        {
            if (check_credientials(Email_tx.Text, Password_tx.Text))
            {
                MessageBox.Show("Login Succesfull", "Login Succesfull");
                this.Hide();
                new EmployeeMain(name, role).ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Wrong username or password", "Error");
        }
        public bool check_credientials(string username, string password)
        {
            if (
            Email_tx_Validating() &&
            Password_tx_Validating()
            )
            {
                Program.Command.Connection = Program.Connection;

                string query = "Select count(*) from Staff where email = @email and password = @password";
                Program.Command.CommandText = query;
                Program.Command.Parameters.AddWithValue("@email", username);
                Program.Command.Parameters.AddWithValue("@password", password);

                try
                {
                    int usercount = (int)Program.Command.ExecuteScalar();
                    if (!(usercount > 0))
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Oops!\nSomething went wrong.\n" + e.Message
                    , "Error"
                    , MessageBoxButtons.RetryCancel
                    , MessageBoxIcon.Error);
                    return false;
                }
                Program.Command.Parameters.Clear();
                Program.Command.CommandText = "select name,role from Staff where email = @email";
                Program.Command.Parameters.AddWithValue("@email", username);
                SqlDataReader reader = Program.Command.ExecuteReader();
                reader.Read();
                name = " " + (string)reader["name"];
                role = (string)reader["role"];
                reader.Close();
                return true;
            }
            else
                return false;
        }

        private void Email_tx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Email_tx_Validating();
        }

        private bool Email_tx_Validating()
        {
            if (Email_tx.Text.Equals(""))
            {
                MessageBox.Show("Email is a required field", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private bool Password_tx_Validating()
        {
            if (Password_tx.Text.Equals(""))
            {
                MessageBox.Show("Password is a required field", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void Password_tx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Password_tx_Validating();
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