using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrgovanjeDionicama
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            Icon = Properties.Resources.icon;
            BackgroundImage = background;
            BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();

            FormClosing += LoginForm_FormClosing;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        Image background = Properties.Resources.login_background;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            Controls.Add(panel1);
        }

        /// <summary>
        /// Checks password and opens front page form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            var user = UserService.LogIn(username, password);

            if (user != null)
            {
                FrontPage frontPage = new FrontPage(user.UserId);
                Hide();
                frontPage.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Unable to log in. Check your username or password.");
            }
        }
        /// <summary>
        /// Shows form for creating new user and hides current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Size = this.Size;
            createUserForm.Location = this.Location;
            createUserForm.WindowState = this.WindowState;
            Hide();
            createUserForm.ShowDialog();
        }
        /// <summary>
        /// Opens front page form without logged user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frontPageForm = new FrontPage(0);
            Hide();
            frontPageForm.ShowDialog();
            Close();
        }
    }
}
