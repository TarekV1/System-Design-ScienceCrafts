using Login;

namespace WinFormsApp1123
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Employee Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Show();
        }
        //Customer Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order_Form().ShowDialog();
            this.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        TryAgain:
            try
            {
                Program.Connection.Close();
                Program.Connection.Open();
                MessageBox.Show("Connected","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                if (DialogResult.Cancel.Equals(
                    MessageBox.Show(
                    "Oops!\nSomething went wrong.\n" + er.Message
                    , "Error"
                    , MessageBoxButtons.RetryCancel
                    , MessageBoxIcon.Error))
                    )
                {
                    this.Close();
                }
                else
                {
                    goto TryAgain;
                }
            }
        }
    }
}

