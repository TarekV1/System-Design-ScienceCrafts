using Login;

namespace WinFormsApp1123
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order_Form().ShowDialog();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            //IMPORTANT
            //REMOVE BEFOR BUILD
            //ONLY USE TO TEST APP WITHOUT DATABASE
            if (false)
            {
                ////////////////

                while (true)
                {
                    try
                    {
                        Program.Connection.Open();
                    }
                    catch (Exception er)
                    {
                        if (DialogResult.Cancel.Equals(
                            MessageBox.Show(
                            "Oops!\nSomthing went wrong.\n" + er.Message
                            , "Error"
                            , MessageBoxButtons.RetryCancel
                            , MessageBoxIcon.Error))
                            )
                        {
                            break;
                        }
                    }
                }
                this.Close();


            }
        }
    }
}
