using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class EditUser : Form
    {
        private string quyen;
        public EditUser(string email, string name, string vaitro)
        {
            InitializeComponent();
            tbMail.AutoSize = false;
            tbMail.Size = new Size(371, 22);
            tbName.AutoSize = false;
            tbName.Size = new Size(371, 22);
            tbMail.Enabled = false;
            tbMail.Text = email;
            tbName.Text = name;
            quyen = vaitro;
        }
        private void VeBorder(Control control, PaintEventArgs e, int r, int g, int b)
        {
            ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.FromArgb(r, g, b), ButtonBorderStyle.Solid);
        }
        bool tbMailDontHandle = false;
        bool tbNameDontHandle = false;
        private void tbMail_MouseEnter(object sender, EventArgs e)
        {
            if (tbMailDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(mail.CreateGraphics(), mail.ClientRectangle);
                VeBorder(mail, eventArgs, 4, 4, 5);
            }
        }

        private void tbMail_MouseLeave(object sender, EventArgs e)
        {
            if (tbMailDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(mail.CreateGraphics(), mail.ClientRectangle);
                VeBorder(mail, eventArgs, 34, 36, 40);
            }
        }

        private void tbMail_Enter(object sender, EventArgs e)
        {
            tbMailDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(mail.CreateGraphics(), mail.ClientRectangle);
            VeBorder(mail, eventArgs, 114, 137, 218);
        }

        private void tbMail_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(mail.CreateGraphics(), mail.ClientRectangle);
            VeBorder(mail, eventArgs, 34, 36, 40);
            tbMailDontHandle = false;
        }

        private void tbName_MouseEnter(object sender, EventArgs e)
        {
            if (tbNameDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(name.CreateGraphics(), name.ClientRectangle);
                VeBorder(name, eventArgs, 4, 4, 5);
            }
        }

        private void tbName_MouseLeave(object sender, EventArgs e)
        {
            if (tbNameDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(name.CreateGraphics(), name.ClientRectangle);
                VeBorder(name, eventArgs, 34, 36, 40);
            }
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            tbNameDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(name.CreateGraphics(), name.ClientRectangle);
            VeBorder(name, eventArgs, 114, 137, 218);
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(name.CreateGraphics(), name.ClientRectangle);
            VeBorder(name, eventArgs, 34, 36, 40);
            tbNameDontHandle = false;
        }
        private void mail_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(mail, e, 34, 36, 40);
        }

        private void name_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(name, e, 34, 36, 40);
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            tbName.Select();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int j = 0;
        string[] dotArr = new string[] { "•", "• •", "• • •" };
        bool timerIsAlive = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            j = j % 3;
            btnLogin.Text = dotArr[j];
            j++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            j = 0;
            btnLogin.Text = "Cập nhật";
            tbName.Enabled = true;
            timerIsAlive = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            timer3.Stop();
            if (tbName.Text == string.Empty)
            {
                lbName.Text = "- Mục này không thể bỏ trống";
                namelb.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(name.CreateGraphics(), name.ClientRectangle);
                VeBorder(name, eventArgs, 240, 71, 71);
                tbNameDontHandle = true;
            }
            else
            {
                int rs = Controller.SuaNV(tbMail.Text, tbName.Text, this.quyen);
                if (rs == 1)
                {
                    lbName.Text = "- Sửa thành công";
                    lbName.ForeColor = Color.FromArgb(77, 222, 19);
                    namelb.ForeColor = Color.FromArgb(77, 222, 19);
                    PaintEventArgs eventArgs = new PaintEventArgs(name.CreateGraphics(), name.ClientRectangle);
                    VeBorder(name, eventArgs, 77, 222, 19);
                    tbNameDontHandle = true;
                }
                else
                {
                    lbName.Text = "- Sửa thất bại";
                    lbName.ForeColor = Color.FromArgb(240, 71, 71);
                    namelb.ForeColor = Color.FromArgb(240, 71, 71);
                    PaintEventArgs eventArgs = new PaintEventArgs(name.CreateGraphics(), name.ClientRectangle);
                    VeBorder(name, eventArgs, 240, 71, 71);
                    tbNameDontHandle = true;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (timerIsAlive == false)
            {
                lbName.Text = "";
                lbName.ForeColor = Color.FromArgb(240, 71, 71);
                namelb.ForeColor = Color.FromArgb(138, 142, 147);
                timerIsAlive = true;
                timer1.Enabled = true;
                timer1_Tick(null, null);
                timer2.Enabled = true;
                timer3.Enabled = true;
                tbName.Enabled = false;
            }
        }
    }
}
