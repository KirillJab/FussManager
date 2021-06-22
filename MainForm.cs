using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SuetaManager.Classes;

namespace SuetaManager
{
    partial class MainForm : Form
    {
        int r, g, b;
        private static DataAccessLayer DataAccessLayer;

        private LoginForm loginForm;
        private CalendarForm calendarForm;
        private WeekForm weekForm;

        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;
        public static UserManager UserManager { get => DataAccessLayer.UserManager;}
        public MainForm()
        {
            InitializeComponent();
            DataAccessLayer = new DataAccessLayer();
            r = 250; g = 5; b = 0;
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(8, 80);
            MenuPanel.Controls.Add(leftBorderButton);

            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            loginForm = new LoginForm();
            calendarForm = new CalendarForm();
            weekForm = new WeekForm();
        }
        private void LoggedIn()
        {
            DisableButtons();

            iconButtonCurPlan.Visible = true;
            iconButtonAvailablePlans.Visible = true;
            iconButtonActivities.Visible = true;
            iconButtonLogOut.Visible = true;
            iconButtonAccountInfo.Visible = true;

            currentChildForm.Close();
            leftBorderButton.Visible = false;
            iconOfChildForm.IconChar = IconChar.Home;
            iconOfChildForm.IconColor = Color.SlateBlue;
            labelNameChildForm.Text = "Home";
            iconButtonLogOut.Text = "Log Out";
            labelUsername.Text = LoginForm.CurrentUser;
        }
        private void LoggedOut()
        {
            DisableButtons();
            leftBorderButton.Visible = false;

            iconButtonCurPlan.Visible = false;
            iconButtonAvailablePlans.Visible = false;
            iconButtonActivities.Visible = false;
            iconButtonAccountInfo.Visible = false;
            iconButtonMeme.Visible = false;
            iconButtonLogOut.Text = "Log In";

            leftBorderButton.Visible = false;
            iconOfChildForm.IconChar = IconChar.UserLock;
            iconOfChildForm.IconColor = Color.SlateBlue;
            labelNameChildForm.Text = "Log In";
            LoginForm.CurrentUser = string.Empty;
            labelUsername.Text = string.Empty;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoggedOut();
            LoadChildForm(loginForm);
            LoadChildForm(calendarForm);
            LoadChildForm(weekForm);
            labelNameChildForm.Text = "Home";

            LoginForm.OnLoggedIn += LoggedIn;
            RegistrationForm.OnRegistred += LoggedIn;
            LoginForm.OnSignUpClicked += SignUp;
            WeekForm.OnMemeReady += EastTheEgg;
            UserManager.OnUserChanged += UnEastTheEgg;

            timer1.Tick += (s, ee) => CirclePanelColors();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void SignUp()
        {
            OpenChildForm(new RegistrationForm());
        }

        private struct Colors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(20, 227, 110);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButtons();

                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
                
                iconOfChildForm.IconChar = currentButton.IconChar;
                iconOfChildForm.IconColor = color;
                labelNameChildForm.Text = currentButton.Text;
            }
        }
        
        private void DisableButtons()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void LoadChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.Show();
            childForm.Hide();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm == childForm)
            {
                return;
            }
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            currentChildForm = childForm;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        private void iconButtonCurrentPlan_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            ActivateButton(sender, Colors.color1);
            OpenChildForm(new CurrentPlanForm());
        }

        private void iconButtonCalendar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color2);
            OpenChildForm(new CalendarForm());
        }

        private void iconButtonWeek_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            ActivateButton(sender, Colors.color3);
            weekForm.UpdateWeek(DateTime.Now);
            OpenChildForm(weekForm);
        }
        private void iconButtonAccountInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color4);
            OpenChildForm(new AccountInfoForm());
        }
        private void iconButtonMeme_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color4);
            OpenChildForm(new MemeForm());
        }

        private void iconButtonLogOut_Click(object sender, EventArgs e)
        {
            DisableButtons();
            leftBorderButton.Visible = false;
            iconOfChildForm.IconChar = IconChar.UserLock;
            iconOfChildForm.IconColor = Color.SlateBlue;
            OpenChildForm(new LoginForm());
            LoggedOut();
        }
        private void panelMenuLogo_Click(object sender, EventArgs e)
        {
            DisableButtons();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            leftBorderButton.Visible = false;
            iconOfChildForm.IconChar = LoginForm.CurrentUser == String.Empty ? IconChar.UserLock : IconChar.Home;
            iconOfChildForm.IconColor = Color.SlateBlue;
            labelNameChildForm.Text = "Home";

            iconButtonLogOut.Visible = true;
        }

        // Navigation Buttons
        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        private void iconButtonMimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataAccessLayer.SaveData();
        }

        private void EastTheEgg()
        {
            iconButtonMeme.Visible = true;
            timer1.Interval = 18;
            timer1.Start();
        }
        private void UnEastTheEgg()
        {
            iconButtonMeme.Visible = false;
            timer1.Stop();
        }
        private void CirclePanelColors()
        {
            if (r > 0 && b == 0)
            {
                r-=5;
                g+=5;
            }
            if (g > 0 && r == 0)
            {
                g -= 5;
                b += 5;
            }
            if (b > 0 && g == 0)
            {
                r += 5;
                b -= 5;
            }
            Color color = Color.FromArgb(r, g, b);

            leftBorderButton.BackColor = color;
            iconButtonMeme.ForeColor = color;
            iconButtonMeme.IconColor = color;
            iconOfChildForm.IconColor = color;
            if (currentButton != null)
            {
                currentButton.IconColor = color;
                currentButton.ForeColor = color;
            }
        }
    }
}
