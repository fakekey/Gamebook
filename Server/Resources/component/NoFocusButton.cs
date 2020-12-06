using System.Windows.Forms;

namespace Server
{
    public class NoFocusButton : Button
    {
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
