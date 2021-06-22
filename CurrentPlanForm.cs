using SuetaManager.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SuetaManager
{
    public partial class CurrentPlanForm : Form
    {
        private List<TaskGrid> tasks = new List<TaskGrid>();

        private class TaskGrid
        {
            private DateTime dateTime = new DateTime();
            private string taskName;
            private string dayOfWeek;
            private string time;

            
            

            public DateTime Date { get => dateTime; set => dateTime = value; }
            public string Task { get => taskName; set => taskName = value; }
            public string DayOfWeek { get => dayOfWeek; set => dayOfWeek = value; }
            public string Time { get => time; set => time = value; }
            public TaskGrid(DateTime dateTime, string timeStart, string taskName)
            {
                Date = dateTime;
                DayOfWeek = dateTime.DayOfWeek.ToString();
                Time = timeStart;
                Task = taskName;
            }
        }
        public CurrentPlanForm()
        {
            InitializeComponent();
            UpdateComboBox();
            UpdateGrid();
            UpdateDeleteButtons();
        }
        private void UpdateDeleteButtons()
        {
            iconButtonDeleteSchedule.Enabled = comboBoxCurrentSchedule.Items.Count > 1;
        }
        private void UpdateGrid()
        {
            int count = MainForm.UserManager.CurrentUser.CurrentSchedule.Years.Count;

            tasks.Clear();
            dataGridView1.DataSource = typeof(List<TaskGrid>);

            for (int m = 0; m < count; m++)
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 31; j++)
                    {
                        foreach (var task in MainForm.UserManager.CurrentUser.CurrentSchedule.Years[m].Months[i].Days[j].Activities)
                        {
                            if (task != null)
                            {
                                i++; j++;
                                DateTime day = new DateTime(MainForm.UserManager.CurrentUser.CurrentSchedule.Years[m].YearNumber, i, j);//, Convert.ToInt32(task.TimeStart.Split('.')[0]), Convert.ToInt32(task.TimeStart.Split('.')[1]), 0);
                                tasks.Add(new TaskGrid(day, task.TimeStart, task.Name));
                                i--; j--;
                            }
                        }
                    }
                }
            }
            dataGridView1.DataSource = tasks;
        }
        private void UpdateComboBox()
        {
            comboBoxCurrentSchedule.Items.Clear();
            foreach (Schedule sched in MainForm.UserManager.CurrentUser.GetSchedules())
            {
                comboBoxCurrentSchedule.Items.Add(sched.Name);
            }
            comboBoxCurrentSchedule.Text = MainForm.UserManager.CurrentUser.CurrentSchedule.Name;
            UpdateDeleteButtons();
        }
        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var task = tasks[dataGridView1.SelectedRows[0].Index];
                var day = MainForm.UserManager.CurrentUser.CurrentSchedule.GetYear(task.Date.Year).Months[task.Date.Month - 1].Days[task.Date.Day - 1];
                MainForm.UserManager.CurrentUser.CurrentSchedule.GetYear(task.Date.Year).Months[task.Date.Month - 1].Days[task.Date.Day - 1].Activities.RemoveAt(day.FindIndexOfActivity(task.Time));
            }
            catch
            {
                MessageBox.Show("You must select the whole row to delete it. Please, try again");
            }
            UpdateGrid();
        }
        private void textBoxTaskName_Click(object sender, EventArgs e)
        {
            if(textBoxNewSchedName.Text == "New Schedule Name")
                textBoxNewSchedName.Text = string.Empty;
        }

        private void iconButtonAddNewSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNewSchedName.Text != "New Schedule Name" && textBoxNewSchedName.Text != String.Empty)
                {
                    MainForm.UserManager.CurrentUser.AddNewSchedule(textBoxNewSchedName.Text);
                    MainForm.UserManager.CurrentUser.SetCurrentSchedule(comboBoxCurrentSchedule.Items.Count);
                    UpdateComboBox();
                    UpdateGrid();
                    textBoxNewSchedName.Text = string.Empty;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCurrentSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.UserManager.CurrentUser.SetCurrentSchedule(comboBoxCurrentSchedule.SelectedIndex);
            UpdateGrid();
        }

        private void iconButtonDeleteSchedule_Click(object sender, EventArgs e)
        {
            MainForm.UserManager.CurrentUser.DeleteSchedule(comboBoxCurrentSchedule.SelectedIndex);
            UpdateGrid();
            UpdateComboBox();
        }

        private void iconButtonRenameCurrentSchedule_Click(object sender, EventArgs e)
        {
            if (textBoxNewSchedName.Text != "New Schedule Name" && textBoxNewSchedName.Text != string.Empty)
            {
                MainForm.UserManager.CurrentUser.CurrentSchedule.SetName(textBoxNewSchedName.Text);
                UpdateComboBox();
                textBoxNewSchedName.Text = string.Empty;
            }
        }

        private void iconButtonLoadSched_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName.EndsWith(".json"))
            {
                ISettingsProvider settingsProvider = new StandartJsonSettingsProvider();
                ISerializer<List<Schedule>> serializer = new ScheduleSerializer();
                try
                {
                    List<Schedule> scheds;
                    try
                    {
                        scheds = serializer.Deserialize(File.ReadAllText(openFileDialog.FileName), settingsProvider.GetSettings());
                    }
                    catch
                    {
                        throw new Exception("Unable to load file " + Path.GetFileName(openFileDialog.FileName) + ". It's not a Schedule file!");
                    }
                    MainForm.UserManager.CurrentUser.AddSchedules(scheds);
                    MessageBox.Show("Schedule(-s) were loaded successully!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                UpdateComboBox();
            }
        }

        private void iconButtonSaveSched_Click(object sender, EventArgs e)
        {
            ISettingsProvider settingsProvider = new StandartJsonSettingsProvider();
            ISerializer<List<Schedule>> serializer = new ScheduleSerializer();
            List<Schedule> schedules = new List<Schedule>();
            schedules.Add(MainForm.UserManager.CurrentUser.CurrentSchedule);
            saveFileDialog.ShowDialog();

            serializer.Serialize(schedules, saveFileDialog.FileName, settingsProvider.GetSettings());
        }
    }
}
