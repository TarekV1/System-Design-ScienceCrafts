namespace WinFormsApp1123
{
    public partial class EmployeeMain : Form
    {
        public EmployeeMain()
        {
            InitializeComponent();
        }

        public EmployeeMain(string name, string role)
        {
            InitializeComponent();
            label1.Text += name;
            this.role = role;
        }

        private string role;

        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (role.Equals("ADMIN"))
            {
                this.Hide();
                new ReviewContract().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You don't have permissions for this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KitForm().ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN"))
            {
                this.Hide();
                new StaffInfo().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You don't have permissions for this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {

        }
    }
}
