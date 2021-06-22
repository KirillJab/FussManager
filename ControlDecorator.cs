using System.Windows.Forms;

namespace SuetaManager
{
    abstract class ControlDecorator : UserControl
    {
        public UserControl uControl { get; set; }
    }
}
