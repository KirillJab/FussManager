using System.Drawing;
using System.Windows.Forms;

namespace SuetaManager
{
    public partial class TimeControl : UserControl
    {
        public TimeControl(string time, Color color, Color foreColor)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            label1.Text = time;
            BackColor = color;
            label1.ForeColor = label1.ForeColor = foreColor;
        }
    }
}
