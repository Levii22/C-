namespace ems
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }
   
            if (username.Text == "admin" && password.Text == "admin")
            {
                this.Hide();
                employees dashboard = new employees();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}