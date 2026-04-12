using MiniCRM.Forms;
using MiniCRM.Services;
namespace MiniCRM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            var authService = new AuthService();
            var user = authService.Login(username, password);

            if (user != null)
            {
                var mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

                // buraya sonra MainForm açacağız
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }




        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
