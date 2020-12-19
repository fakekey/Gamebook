using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public static class Messagebox
    {
        public static DialogResult Show(string title, string content, MessageBoxButtons btn)
        {
            DialogResult dr = DialogResult.None;
            switch (btn)
            {
                case MessageBoxButtons.YesNo:
                    using (Form f = new Form())
                    {
                        f.StartPosition = FormStartPosition.Manual;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.ShowInTaskbar = false;
                        f.BackColor = Color.Black;
                        f.Opacity = 0.85f;
                        f.Location = CheckClass.location;
                        f.Size = CheckClass.size;
                        using (MsbYesNo fOverlay = new MsbYesNo())
                        {
                            f.Show();
                            fOverlay.Owner = f;
                            fOverlay.mTitle = title;
                            fOverlay.mContent = content;
                            fOverlay.Text = title;
                            dr = fOverlay.ShowDialog();
                        }
                    }
                    break;
                default:
                    break;
            }
            return dr;
        }
    }
}
