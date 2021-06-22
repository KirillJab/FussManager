
namespace SuetaManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.iconButtonMeme = new FontAwesome.Sharp.IconButton();
            this.iconButtonAccountInfo = new FontAwesome.Sharp.IconButton();
            this.iconButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.labelUsername = new System.Windows.Forms.Label();
            this.iconButtonActivities = new FontAwesome.Sharp.IconButton();
            this.iconButtonAvailablePlans = new FontAwesome.Sharp.IconButton();
            this.iconButtonCurPlan = new FontAwesome.Sharp.IconButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonMaximize = new FontAwesome.Sharp.IconButton();
            this.iconButtonMimize = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.labelNameChildForm = new System.Windows.Forms.Label();
            this.iconOfChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconOfChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.MenuPanel.Controls.Add(this.iconButtonMeme);
            this.MenuPanel.Controls.Add(this.iconButtonAccountInfo);
            this.MenuPanel.Controls.Add(this.iconButtonLogOut);
            this.MenuPanel.Controls.Add(this.labelUsername);
            this.MenuPanel.Controls.Add(this.iconButtonActivities);
            this.MenuPanel.Controls.Add(this.iconButtonAvailablePlans);
            this.MenuPanel.Controls.Add(this.iconButtonCurPlan);
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(254, 741);
            this.MenuPanel.TabIndex = 0;
            // 
            // iconButtonMeme
            // 
            this.iconButtonMeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMeme.FlatAppearance.BorderSize = 0;
            this.iconButtonMeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMeme.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMeme.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMeme.IconChar = FontAwesome.Sharp.IconChar.LaughSquint;
            this.iconButtonMeme.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMeme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMeme.IconSize = 42;
            this.iconButtonMeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMeme.Location = new System.Drawing.Point(0, 456);
            this.iconButtonMeme.Name = "iconButtonMeme";
            this.iconButtonMeme.Size = new System.Drawing.Size(254, 80);
            this.iconButtonMeme.TabIndex = 8;
            this.iconButtonMeme.Text = "Meme";
            this.iconButtonMeme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMeme.UseVisualStyleBackColor = true;
            this.iconButtonMeme.Click += new System.EventHandler(this.iconButtonMeme_Click);
            // 
            // iconButtonAccountInfo
            // 
            this.iconButtonAccountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAccountInfo.FlatAppearance.BorderSize = 0;
            this.iconButtonAccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAccountInfo.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAccountInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAccountInfo.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconButtonAccountInfo.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAccountInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAccountInfo.IconSize = 42;
            this.iconButtonAccountInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAccountInfo.Location = new System.Drawing.Point(0, 376);
            this.iconButtonAccountInfo.Name = "iconButtonAccountInfo";
            this.iconButtonAccountInfo.Size = new System.Drawing.Size(254, 80);
            this.iconButtonAccountInfo.TabIndex = 7;
            this.iconButtonAccountInfo.Text = "Account Info";
            this.iconButtonAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAccountInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAccountInfo.UseVisualStyleBackColor = true;
            this.iconButtonAccountInfo.Click += new System.EventHandler(this.iconButtonAccountInfo_Click);
            // 
            // iconButtonLogOut
            // 
            this.iconButtonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonLogOut.FlatAppearance.BorderSize = 0;
            this.iconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonLogOut.IconColor = System.Drawing.Color.Black;
            this.iconButtonLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogOut.Location = new System.Drawing.Point(151, 701);
            this.iconButtonLogOut.Name = "iconButtonLogOut";
            this.iconButtonLogOut.Size = new System.Drawing.Size(97, 32);
            this.iconButtonLogOut.TabIndex = 6;
            this.iconButtonLogOut.Text = "Log Out";
            this.iconButtonLogOut.UseVisualStyleBackColor = true;
            this.iconButtonLogOut.Click += new System.EventHandler(this.iconButtonLogOut_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsername.Location = new System.Drawing.Point(10, 706);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(57, 21);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "label1";
            // 
            // iconButtonActivities
            // 
            this.iconButtonActivities.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonActivities.FlatAppearance.BorderSize = 0;
            this.iconButtonActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonActivities.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonActivities.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonActivities.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButtonActivities.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonActivities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonActivities.IconSize = 42;
            this.iconButtonActivities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonActivities.Location = new System.Drawing.Point(0, 296);
            this.iconButtonActivities.Name = "iconButtonActivities";
            this.iconButtonActivities.Size = new System.Drawing.Size(254, 80);
            this.iconButtonActivities.TabIndex = 3;
            this.iconButtonActivities.Text = "Week";
            this.iconButtonActivities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonActivities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonActivities.UseVisualStyleBackColor = true;
            this.iconButtonActivities.Click += new System.EventHandler(this.iconButtonWeek_Click);
            // 
            // iconButtonAvailablePlans
            // 
            this.iconButtonAvailablePlans.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAvailablePlans.FlatAppearance.BorderSize = 0;
            this.iconButtonAvailablePlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAvailablePlans.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAvailablePlans.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAvailablePlans.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconButtonAvailablePlans.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAvailablePlans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAvailablePlans.IconSize = 42;
            this.iconButtonAvailablePlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAvailablePlans.Location = new System.Drawing.Point(0, 216);
            this.iconButtonAvailablePlans.Name = "iconButtonAvailablePlans";
            this.iconButtonAvailablePlans.Size = new System.Drawing.Size(254, 80);
            this.iconButtonAvailablePlans.TabIndex = 2;
            this.iconButtonAvailablePlans.Text = "Calendar";
            this.iconButtonAvailablePlans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAvailablePlans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAvailablePlans.UseVisualStyleBackColor = true;
            this.iconButtonAvailablePlans.Click += new System.EventHandler(this.iconButtonCalendar_Click);
            // 
            // iconButtonCurPlan
            // 
            this.iconButtonCurPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCurPlan.FlatAppearance.BorderSize = 0;
            this.iconButtonCurPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCurPlan.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCurPlan.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCurPlan.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconButtonCurPlan.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCurPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCurPlan.IconSize = 42;
            this.iconButtonCurPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCurPlan.Location = new System.Drawing.Point(0, 136);
            this.iconButtonCurPlan.Name = "iconButtonCurPlan";
            this.iconButtonCurPlan.Size = new System.Drawing.Size(254, 80);
            this.iconButtonCurPlan.TabIndex = 1;
            this.iconButtonCurPlan.Text = "Current Plan";
            this.iconButtonCurPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCurPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCurPlan.UseVisualStyleBackColor = true;
            this.iconButtonCurPlan.Click += new System.EventHandler(this.iconButtonCurrentPlan_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.labelLogo);
            this.LogoPanel.Controls.Add(this.iconPictureBox1);
            this.LogoPanel.Controls.Add(this.panelMenuLogo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(254, 136);
            this.LogoPanel.TabIndex = 0;
            this.LogoPanel.Click += new System.EventHandler(this.panelMenuLogo_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLogo.Location = new System.Drawing.Point(63, 58);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(153, 25);
            this.labelLogo.TabIndex = 4;
            this.labelLogo.Text = "Fuss Manager";
            this.labelLogo.Click += new System.EventHandler(this.panelMenuLogo_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(10, 47);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(65, 58);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.panelMenuLogo_Click);
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(254, 136);
            this.panelMenuLogo.TabIndex = 3;
            this.panelMenuLogo.Click += new System.EventHandler(this.panelMenuLogo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.iconButtonMaximize);
            this.panelTitleBar.Controls.Add(this.iconButtonMimize);
            this.panelTitleBar.Controls.Add(this.iconButtonClose);
            this.panelTitleBar.Controls.Add(this.labelNameChildForm);
            this.panelTitleBar.Controls.Add(this.iconOfChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(254, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1020, 90);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonMaximize
            // 
            this.iconButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMaximize.FlatAppearance.BorderSize = 0;
            this.iconButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButtonMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMaximize.IconSize = 20;
            this.iconButtonMaximize.Location = new System.Drawing.Point(963, 2);
            this.iconButtonMaximize.Name = "iconButtonMaximize";
            this.iconButtonMaximize.Size = new System.Drawing.Size(24, 30);
            this.iconButtonMaximize.TabIndex = 6;
            this.iconButtonMaximize.UseVisualStyleBackColor = true;
            this.iconButtonMaximize.Click += new System.EventHandler(this.iconButtonMaximize_Click);
            // 
            // iconButtonMimize
            // 
            this.iconButtonMimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMimize.IconSize = 20;
            this.iconButtonMimize.Location = new System.Drawing.Point(933, 2);
            this.iconButtonMimize.Name = "iconButtonMimize";
            this.iconButtonMimize.Size = new System.Drawing.Size(24, 30);
            this.iconButtonMimize.TabIndex = 5;
            this.iconButtonMimize.UseVisualStyleBackColor = true;
            this.iconButtonMimize.Click += new System.EventHandler(this.iconButtonMimize_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonClose.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 20;
            this.iconButtonClose.Location = new System.Drawing.Point(993, 0);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(24, 30);
            this.iconButtonClose.TabIndex = 4;
            this.iconButtonClose.Text = "x";
            this.iconButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonClose.UseMnemonic = false;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // labelNameChildForm
            // 
            this.labelNameChildForm.AutoSize = true;
            this.labelNameChildForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNameChildForm.Location = new System.Drawing.Point(52, 47);
            this.labelNameChildForm.Name = "labelNameChildForm";
            this.labelNameChildForm.Size = new System.Drawing.Size(56, 21);
            this.labelNameChildForm.TabIndex = 1;
            this.labelNameChildForm.Text = "Home";
            // 
            // iconOfChildForm
            // 
            this.iconOfChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconOfChildForm.ForeColor = System.Drawing.Color.SlateBlue;
            this.iconOfChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconOfChildForm.IconColor = System.Drawing.Color.SlateBlue;
            this.iconOfChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOfChildForm.IconSize = 36;
            this.iconOfChildForm.Location = new System.Drawing.Point(16, 39);
            this.iconOfChildForm.Name = "iconOfChildForm";
            this.iconOfChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconOfChildForm.TabIndex = 0;
            this.iconOfChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(254, 90);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1020, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.panelDesktop.Controls.Add(this.panelLogo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(254, 98);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1020, 643);
            this.panelDesktop.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogo.AutoSize = true;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.iconPictureBox2);
            this.panelLogo.Location = new System.Drawing.Point(259, 159);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(553, 274);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(117, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuss Manager";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 127;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 68);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(127, 140);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 741);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1290, 780);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconOfChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuPanel;
        private FontAwesome.Sharp.IconButton iconButtonCurPlan;
        private FontAwesome.Sharp.IconButton iconButtonActivities;
        private FontAwesome.Sharp.IconButton iconButtonAvailablePlans;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelNameChildForm;
        private FontAwesome.Sharp.IconPictureBox iconOfChildForm;
        private FontAwesome.Sharp.IconButton iconButtonLogOut;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonMaximize;
        private FontAwesome.Sharp.IconButton iconButtonMimize;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label labelLogo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelMenuLogo;
        private FontAwesome.Sharp.IconButton iconButtonAccountInfo;
        private FontAwesome.Sharp.IconButton iconButtonMeme;
        private System.Windows.Forms.Timer timer1;
    }
}

