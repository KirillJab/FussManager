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
    public partial class WeekTaskControl : UserControl
    {
        public WeekTaskControl()
        {
            InitializeComponent();
        }
        public WeekTaskControl(string time, string name, Color backColor, Color foreColor)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            label1.Text = time;
            label2.Text = name;
            BackColor = backColor;
            label1.ForeColor = label2.ForeColor = foreColor;
        }
        public WeekTaskControl(string time, string name)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            label1.Text = time;
            label2.Text = name;
        }
    }
}
