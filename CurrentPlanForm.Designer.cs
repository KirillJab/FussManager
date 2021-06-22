
namespace SuetaManager
{
    partial class CurrentPlanForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.comboBoxCurrentSchedule = new System.Windows.Forms.ComboBox();
            this.iconButtonAddSched = new FontAwesome.Sharp.IconButton();
            this.textBoxNewSchedName = new System.Windows.Forms.TextBox();
            this.iconButtonDeleteSchedule = new FontAwesome.Sharp.IconButton();
            this.iconButtonRenameCurrentSchedule = new FontAwesome.Sharp.IconButton();
            this.iconButtonLoadSched = new FontAwesome.Sharp.IconButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.iconButtonSaveSched = new FontAwesome.Sharp.IconButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(78)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.Date,
            this.Time,
            this.DayOfWeek});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 539);
            this.dataGridView1.TabIndex = 0;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "Task";
            this.TaskName.HeaderText = "Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 91;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 81;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 75;
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.DataPropertyName = "DayOfWeek";
            this.DayOfWeek.HeaderText = "Day Of Week";
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.ReadOnly = true;
            this.DayOfWeek.Width = 143;
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.iconButtonDelete.FlatAppearance.BorderSize = 0;
            this.iconButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonDelete.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDelete.IconColor = System.Drawing.Color.Black;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.Location = new System.Drawing.Point(1313, 14);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(165, 35);
            this.iconButtonDelete.TabIndex = 5;
            this.iconButtonDelete.Text = "DELETE ACTIVITY";
            this.iconButtonDelete.UseVisualStyleBackColor = false;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // comboBoxCurrentSchedule
            // 
            this.comboBoxCurrentSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(176)))), ((int)(((byte)(223)))));
            this.comboBoxCurrentSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCurrentSchedule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrentSchedule.FormattingEnabled = true;
            this.comboBoxCurrentSchedule.Location = new System.Drawing.Point(12, 20);
            this.comboBoxCurrentSchedule.Name = "comboBoxCurrentSchedule";
            this.comboBoxCurrentSchedule.Size = new System.Drawing.Size(210, 27);
            this.comboBoxCurrentSchedule.TabIndex = 13;
            this.comboBoxCurrentSchedule.Text = "Choose Your Schedule";
            this.comboBoxCurrentSchedule.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrentSchedule_SelectedIndexChanged);
            // 
            // iconButtonAddSched
            // 
            this.iconButtonAddSched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonAddSched.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.iconButtonAddSched.FlatAppearance.BorderSize = 0;
            this.iconButtonAddSched.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonAddSched.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButtonAddSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddSched.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonAddSched.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonAddSched.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAddSched.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddSched.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddSched.Location = new System.Drawing.Point(475, 14);
            this.iconButtonAddSched.Name = "iconButtonAddSched";
            this.iconButtonAddSched.Size = new System.Drawing.Size(183, 35);
            this.iconButtonAddSched.TabIndex = 14;
            this.iconButtonAddSched.Text = "ADD NEW SCHEDULE";
            this.iconButtonAddSched.UseVisualStyleBackColor = false;
            this.iconButtonAddSched.Click += new System.EventHandler(this.iconButtonAddNewSchedule_Click);
            // 
            // textBoxNewSchedName
            // 
            this.textBoxNewSchedName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewSchedName.Location = new System.Drawing.Point(256, 20);
            this.textBoxNewSchedName.Name = "textBoxNewSchedName";
            this.textBoxNewSchedName.Size = new System.Drawing.Size(213, 25);
            this.textBoxNewSchedName.TabIndex = 15;
            this.textBoxNewSchedName.Text = "New Schedule Name";
            this.textBoxNewSchedName.UseWaitCursor = true;
            this.textBoxNewSchedName.Click += new System.EventHandler(this.textBoxTaskName_Click);
            // 
            // iconButtonDeleteSchedule
            // 
            this.iconButtonDeleteSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDeleteSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonDeleteSchedule.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.iconButtonDeleteSchedule.FlatAppearance.BorderSize = 0;
            this.iconButtonDeleteSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonDeleteSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButtonDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDeleteSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonDeleteSchedule.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonDeleteSchedule.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDeleteSchedule.IconColor = System.Drawing.Color.Black;
            this.iconButtonDeleteSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDeleteSchedule.Location = new System.Drawing.Point(1142, 14);
            this.iconButtonDeleteSchedule.Name = "iconButtonDeleteSchedule";
            this.iconButtonDeleteSchedule.Size = new System.Drawing.Size(165, 35);
            this.iconButtonDeleteSchedule.TabIndex = 16;
            this.iconButtonDeleteSchedule.Text = "DELETE SCHEDULE";
            this.iconButtonDeleteSchedule.UseVisualStyleBackColor = false;
            this.iconButtonDeleteSchedule.Click += new System.EventHandler(this.iconButtonDeleteSchedule_Click);
            // 
            // iconButtonRenameCurrentSchedule
            // 
            this.iconButtonRenameCurrentSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonRenameCurrentSchedule.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.iconButtonRenameCurrentSchedule.FlatAppearance.BorderSize = 0;
            this.iconButtonRenameCurrentSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonRenameCurrentSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButtonRenameCurrentSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRenameCurrentSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonRenameCurrentSchedule.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonRenameCurrentSchedule.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonRenameCurrentSchedule.IconColor = System.Drawing.Color.Black;
            this.iconButtonRenameCurrentSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRenameCurrentSchedule.Location = new System.Drawing.Point(664, 14);
            this.iconButtonRenameCurrentSchedule.Name = "iconButtonRenameCurrentSchedule";
            this.iconButtonRenameCurrentSchedule.Size = new System.Drawing.Size(260, 35);
            this.iconButtonRenameCurrentSchedule.TabIndex = 17;
            this.iconButtonRenameCurrentSchedule.Text = "RENAME CURRENT SCHEDULE";
            this.iconButtonRenameCurrentSchedule.UseVisualStyleBackColor = false;
            this.iconButtonRenameCurrentSchedule.Click += new System.EventHandler(this.iconButtonRenameCurrentSchedule_Click);
            // 
            // iconButtonLoadSched
            // 
            this.iconButtonLoadSched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonLoadSched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonLoadSched.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.iconButtonLoadSched.FlatAppearance.BorderSize = 0;
            this.iconButtonLoadSched.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonLoadSched.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButtonLoadSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLoadSched.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonLoadSched.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonLoadSched.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonLoadSched.IconColor = System.Drawing.Color.Black;
            this.iconButtonLoadSched.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLoadSched.Location = new System.Drawing.Point(800, 14);
            this.iconButtonLoadSched.Name = "iconButtonLoadSched";
            this.iconButtonLoadSched.Size = new System.Drawing.Size(165, 35);
            this.iconButtonLoadSched.TabIndex = 18;
            this.iconButtonLoadSched.Text = "LOAD SCHEDULE";
            this.iconButtonLoadSched.UseVisualStyleBackColor = false;
            this.iconButtonLoadSched.Click += new System.EventHandler(this.iconButtonLoadSched_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // iconButtonSaveSched
            // 
            this.iconButtonSaveSched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSaveSched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonSaveSched.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.iconButtonSaveSched.FlatAppearance.BorderSize = 0;
            this.iconButtonSaveSched.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.iconButtonSaveSched.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButtonSaveSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSaveSched.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonSaveSched.ForeColor = System.Drawing.Color.Snow;
            this.iconButtonSaveSched.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSaveSched.IconColor = System.Drawing.Color.Black;
            this.iconButtonSaveSched.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSaveSched.Location = new System.Drawing.Point(971, 14);
            this.iconButtonSaveSched.Name = "iconButtonSaveSched";
            this.iconButtonSaveSched.Size = new System.Drawing.Size(165, 35);
            this.iconButtonSaveSched.TabIndex = 19;
            this.iconButtonSaveSched.Text = "SAVE SCHEDULE";
            this.iconButtonSaveSched.UseVisualStyleBackColor = false;
            this.iconButtonSaveSched.Click += new System.EventHandler(this.iconButtonSaveSched_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            // 
            // CurrentPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1490, 916);
            this.ControlBox = false;
            this.Controls.Add(this.iconButtonSaveSched);
            this.Controls.Add(this.iconButtonLoadSched);
            this.Controls.Add(this.iconButtonRenameCurrentSchedule);
            this.Controls.Add(this.iconButtonDeleteSchedule);
            this.Controls.Add(this.textBoxNewSchedName);
            this.Controls.Add(this.iconButtonAddSched);
            this.Controls.Add(this.comboBoxCurrentSchedule);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CurrentPlanForm";
            this.Text = "CurrentPlanForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.ComboBox comboBoxCurrentSchedule;
        private FontAwesome.Sharp.IconButton iconButtonAddSched;
        private System.Windows.Forms.TextBox textBoxNewSchedName;
        private FontAwesome.Sharp.IconButton iconButtonDeleteSchedule;
        private FontAwesome.Sharp.IconButton iconButtonRenameCurrentSchedule;
        private FontAwesome.Sharp.IconButton iconButtonLoadSched;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private FontAwesome.Sharp.IconButton iconButtonSaveSched;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfWeek;
    }
}