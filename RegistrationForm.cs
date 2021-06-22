using SuetaManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuetaManager
{
    public partial class RegistrationForm : Form
    {
        public delegate void RegistrationHandler();
        public static event RegistrationHandler OnRegistred;
        EmailHelper emailHelper;
        public RegistrationForm()
        {
            InitializeComponent();

            emailHelper = new EmailHelper();

            panelRegister.Visible = true;
            panelConfirm.Visible = false;
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            iconButtonSignUp.Enabled = checkBoxRememberMe.Checked;
        }

        private void iconPictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                iconPictureBoxShowPassword1.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                iconPictureBoxShowPassword1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void iconPictureShowPassword_MouseDown(object sender, MouseEventArgs e)
        {

            if (textBoxPasswordConfirm.UseSystemPasswordChar)
            {
                iconPictureShowPassword2.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                iconPictureShowPassword2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
            }
        }

        private void iconButtonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateMail(textBoxGmail.Text))
                {
                    if (!MainForm.UserManager.UserExists(textBoxUsername.Text))
                    {
                        if (textBoxPassword.Text != "")
                        {
                            if (textBoxPassword.Text.Length > 4)
                            {
                                if (textBoxPassword.Text == textBoxPasswordConfirm.Text)
                                {
                                    panelRegister.Visible = false;
                                    panelConfirm.Visible = true;
                                    emailHelper.SendEmailVerificationAsync(textBoxGmail.Text).GetAwaiter();
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
                    else
                    {
                        throw new Exception("Username is already taken. Please, try another one");
                    }
                }
                else
                {
                    MessageBox.Show("Your e-mail is not valid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ValidateMail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCode.Text == emailHelper.VerificationCode)
                {
                    LoginForm.CurrentUser = textBoxUsername.Text;
                    MainForm.UserManager.AddUser(textBoxUsername.Text, textBoxPassword.Text, false, textBoxGmail.Text);
                    MainForm.UserManager.SetCurrentUser(textBoxUsername.Text);
                    MainForm.UserManager.RememberMe = checkBoxRememberMe.Checked;
                    emailHelper.SendThankMessage(textBoxGmail.Text).GetAwaiter();
                    MessageBox.Show("Your account was succesfully registered in the FussManager");
                    OnRegistred();
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
