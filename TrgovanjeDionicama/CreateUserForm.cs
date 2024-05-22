using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrgovanjeDionicama
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            BackgroundImage = background;
            BackgroundImageLayout = ImageLayout.Stretch;
            passwordTextBox.UseSystemPasswordChar = true;
            

            FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        readonly Image background = Properties.Resources.login_background;
        /// <summary>
        /// Checks if user data is valid and creates new user with wallet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text)
                || string.IsNullOrEmpty(passwordTextBox.Text) || string.IsNullOrEmpty(firstNameTextBox.Text)
                || string.IsNullOrEmpty(lastNameTextBox.Text))
            { 
                MessageBox.Show("All fields are required in order to create new user");
                return;
            }

            if(!IsEmailValid(emailTextBox.Text))
            {
                MessageBox.Show("Invalid email");
                return;
            }
            var user = UserService.CreateUser(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text,
                firstNameTextBox.Text, lastNameTextBox.Text);
            if (user != null)
            {
                FrontPage walletForm = new FrontPage(user.UserId);
                Hide();
                walletForm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Username already exists");
                usernameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                firstNameTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
            Close();
        }

        private bool IsEmailValid(string email)
        {
            // Regularni izraz za provjeru ispravnosti e-mail adrese
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Provjera e-mail adrese uz pomoć regexa
            return Regex.IsMatch(email, pattern);
        }
    }
}
