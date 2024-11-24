using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace ProjectTracker
{
    public partial class RegistrationForm : MaterialForm
    {
        private bool isRegisterMode = false;

        public RegistrationForm()
        {
            InitializeComponent();
            InitializeMaterialDesign();
            passwordTextBox.PasswordChar = '*';
            ToggleMode();
        }

        private void InitializeMaterialDesign()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey600,
                Primary.Grey800,
                Primary.Grey200,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void ToggleMode()
        {
            userNameTextBox.Visible = isRegisterMode;
            userNameLabel.Visible = isRegisterMode; 
            signUpButton.Visible = isRegisterMode;
            signInButton.Visible = !isRegisterMode;
            registerLink.Visible = !isRegisterMode;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string email = eMailTextBox.Text;
            string password = passwordTextBox.Text;

            string passwordHash = HashPassword(password);

            if (User.FindByEmail(email) != null)
            {
                MessageBox.Show("A user with this email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User(username, email, passwordHash);
            newUser.Save();

            ClearFields();

            ProjectsForm projectsForm = new ProjectsForm(newUser.UserID, newUser.Username);
            projectsForm.Show();
            this.Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string email = eMailTextBox.Text;
            string password = passwordTextBox.Text;

            User existingUser = User.FindByEmail(email);

            if (existingUser == null)
            {
                MessageBox.Show("User with this email does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (VerifyPassword(password, existingUser.PasswordHash))
            {

                ClearFields();

                ProjectsForm projectsForm = new ProjectsForm(existingUser.UserID, existingUser.Username);
                projectsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isRegisterMode = true;
            ToggleMode();
        }

        private void ClearFields()
        {
            userNameTextBox.Text = "";
            eMailTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
        }

        private void togglePasswordVisibility_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = togglePasswordVisibility.Checked ? '\0' : '*';
        }
    }
}
