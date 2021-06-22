using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuetaManager
{
    public partial class AccountInfoForm : Form
    {
        public AccountInfoForm()
        {
            InitializeComponent();
            labelLogin.Text = MainForm.UserManager.CurrentUser.Name;
        }

        private void labelPassword_Enter(object sender, EventArgs e)
        {
            labelPassword.Text = MainForm.UserManager.CurrentUser.Password;
        }
        private void labelPassword_Leave(object sender, EventArgs e)
        {
            labelPassword.Text = "********";
        }
        private void UpdatePanelState()
        {
            if (!panelChangePassword.Visible)
            {
                iconButtonChangePassword.BackColor = Color.FromArgb(85, 85, 170);
                iconButtonChangePassword.FlatAppearance.BorderSize = 0;
                panelChangePassword.Visible = true;
                newPasswordText.Text = string.Empty;
                confirmPasswordText.Text = string.Empty;
            }
            else
            {
                iconButtonChangePassword.BackColor = Color.FromArgb(34, 33, 78);
                iconButtonChangePassword.FlatAppearance.BorderSize = 1;
                panelChangePassword.Visible = false;
            }
        }
        private void iconButtonChangePassword_Click(object sender, EventArgs e)
        {
            UpdatePanelState();
        }

        private void iconButtonSubmitChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (newPasswordText.Text == confirmPasswordText.Text)
                {
                    if (newPasswordText.Text != "")
                    {
                        if (newPasswordText.Text.Length > 4)
                        {
                            MainForm.UserManager.CurrentUser.Password = confirmPasswordText.Text;
                            UpdatePanelState();
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
                    throw new Exception("Passwords do not match. Please, try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
