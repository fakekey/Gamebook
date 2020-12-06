using System.Windows.Forms;

namespace Server
{
    public static class Msb
    {
        public static DialogResult Show(string message, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MsbOK f = new MsbOK())
                    {
                        f.Text = title;
                        f.Title = title;
                        f.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                f.Icons = Properties.Resources.icons8_ok_100;
                                break;
                            case MessageBoxIcon.Error:
                                f.Icons = Properties.Resources.icons8_cancel_100;
                                break;
                            case MessageBoxIcon.Question:
                                f.Icons = Properties.Resources.icons8_help_100;
                                break;
                            case MessageBoxIcon.Warning:
                                f.Icons = Properties.Resources.icons8_brake_warning_100;
                                break;
                        }
                        result = f.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.YesNo:
                    using (MsbYesNo f = new MsbYesNo())
                    {
                        f.Text = title;
                        f.Title = title;
                        f.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                f.Icons = Properties.Resources.icons8_ok_100;
                                break;
                            case MessageBoxIcon.Error:
                                f.Icons = Properties.Resources.icons8_cancel_100;
                                break;
                            case MessageBoxIcon.Question:
                                f.Icons = Properties.Resources.icons8_help_100;
                                break;
                            case MessageBoxIcon.Warning:
                                f.Icons = Properties.Resources.icons8_brake_warning_100;
                                break;
                        }
                        result = f.ShowDialog();
                    }
                    break;
            }
            return result;
        }
    }
}
