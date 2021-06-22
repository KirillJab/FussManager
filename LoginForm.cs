using FontAwesome.Sharp;
using SuetaManager.Classes;
using System;
using System.Windows.Forms;

namespace SuetaManager
{
    public partial class LoginForm : Form
    {
        public static string CurrentUser;
        private User userToChangePass;
        private EmailHelper emailHelper;

        public delegate void LoginHandler();
        public static event LoginHandler OnLoggedIn;
        public delegate void SignUpHandler();
        public static event SignUpHandler OnSignUpClicked;
        public LoginForm()
        {
            InitializeComponent();

            panelLogin.Visible = true;
            panelForgotPassword.Visible = false;
            panelConfirm.Visible = false;
            panelNewPassword.Visible = false;
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;

            emailHelper = new EmailHelper();

            if (MainForm.UserManager.RememberMe == true)
            {
                UsernameText.Text = MainForm.UserManager.CurrentUser.Name;
                PasswordText.Text = MainForm.UserManager.CurrentUser.Password;
                checkBoxRememberMe.Checked = true;
            }
        }

        private void iconButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainForm.UserManager.UserExists(UsernameText.Text))
                {
                    MainForm.UserManager.SetCurrentUser(UsernameText.Text);
                    if (PasswordText.Text == MainForm.UserManager.CurrentUser.Password)
                    {
                        CurrentUser = UsernameText.Text;
                        MainForm.UserManager.RememberMe = checkBoxRememberMe.Checked;
                        OnLoggedIn();
                    }
                    else
                    {
                        throw new Exception("Password is incorrect, please, try again");
                    }
                }
                else
                {
                    throw new Exception("Username is incorrect, please, try again");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButtonSignUp.FlatAppearance.BorderSize = 0;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButtonSignUp.FlatAppearance.BorderSize = 1;

        }

        private void iconPictureShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ShowHidePassword(sender, PasswordText);
        }

        private void iconButtonSignUp_Click(object sender, EventArgs e)
        {
            OnSignUpClicked();
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelForgotPassword.Visible = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelForgotPassword.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string email = textBoxGmail.Text;
            if (MainForm.UserManager.UserExists(username))
            {
                if (MainForm.UserManager.FindUser(username).EmailAddress == email)
                {
                    userToChangePass = MainForm.UserManager.FindUser(username);
                    panelForgotPassword.Visible = false;
                    panelConfirm.Visible = true;
                    emailHelper.SendEmailVerificationAsync(email).GetAwaiter();
                }
            }
            else
            {
                MessageBox.Show("User do not exists");
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNewPassword.Text != "")
                {
                    if (textBoxNewPassword.Text.Length > 4)
                    {
                        if (textBoxNewPassword.Text == textBoxNewPasswordConfirm.Text)
                        {
                            //CurrentUser = userToChangePass.Name;
                            userToChangePass.Password = textBoxNewPassword.Text;
                            panelNewPassword.Visible = false;
                            panelLogin.Visible = true;
                            PasswordText.Text = string.Empty;

                            MessageBox.Show("Password was changed succesfully");
                            //OnLoggedIn();
                        }
                        else
                        {
                            throw new Exception("Passwords do not match. Please, try one more time");
                        }
                    }
                    else
                    {
                        throw new Exception("Password is too short. Please, try another one");
                    }
                }
                else
                {
                    throw new Exception("Password can not be empty. Please, try another one");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void iconPictureBoxShowPassword1_MouseDown(object sender, MouseEventArgs e)
        {
            ShowHidePassword(sender, textBoxNewPassword);
        }

        private void iconPictureBoxShowPassword2_MouseDown(object sender, MouseEventArgs e)
        {
            ShowHidePassword(sender, textBoxNewPasswordConfirm);
        }
        private void ShowHidePassword(object sender, object passBox)
        {
            var icon = (IconPictureBox)sender;
            var textBox = (TextBox)passBox;

            if (textBox.UseSystemPasswordChar)
            {
                icon.IconChar = IconChar.Eye;
                textBox.UseSystemPasswordChar = false;
            }
            else
            {
                icon.IconChar = IconChar.EyeSlash;
                textBox.UseSystemPasswordChar = true;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCode.Text == emailHelper.VerificationCode)
                {
                    panelConfirm.Visible = false;
                    panelNewPassword.Visible = true;
                }
                else
                {
                    throw new Exception("Verification code is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
