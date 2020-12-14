using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            tbMail.AutoSize = false;
            tbMail.Size = new Size(371, 22);
            tbName.AutoSize = false;
            tbName.Size = new Size(371, 22);
            tbPass.AutoSize = false;
            tbPass.Size = new Size(371, 22);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VeBorder(Control control, PaintEventArgs e, int r, int g, int b)
        {
            ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.FromArgb(r, g, b), ButtonBorderStyle.Solid);
        }

        private void mail_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(mail, e, 34, 36, 40);
        }

        private void name_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(name, e, 34, 36, 40);
        }

        private void pass_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(pass, e, 34, 36, 40);
        }

        bool tbMailDontHandle = false;
        bool tbNameDontHandle = false;
        bool tbPassDontHandle = false;

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

        private void tbPass_MouseEnter(object sender, EventArgs e)
        {
            if (tbPassDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(pass.CreateGraphics(), pass.ClientRectangle);
                VeBorder(pass, eventArgs, 4, 4, 5);
            }
        }

        private void tbPass_MouseLeave(object sender, EventArgs e)
        {
            if (tbPassDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(pass.CreateGraphics(), pass.ClientRectangle);
                VeBorder(pass, eventArgs, 34, 36, 40);
            }
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            tbPassDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(pass.CreateGraphics(), pass.ClientRectangle);
            VeBorder(pass, eventArgs, 114, 137, 218);
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(pass.CreateGraphics(), pass.ClientRectangle);
            VeBorder(pass, eventArgs, 34, 36, 40);
            tbPassDontHandle = false;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            label1.Select();
            comboBox1.SelectedIndex = 0;
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
            btnLogin.Text = "Thêm ngay bây giờ";
            tbMail.Enabled = true;
            tbName.Enabled = true;
            tbPass.Enabled = true;
            timerIsAlive = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            if (tbMail.Text == string.Empty)
            {
                lbMail.Text = "- Mục này không thể bỏ trống";
                mailb.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(mail.CreateGraphics(), mail.ClientRectangle);
                VeBorder(mail, eventArgs, 240, 71, 71);
                tbMailDontHandle = true;
            }
            if (tbName.Text == string.Empty)
            {
                lbName.Text = "- Mục này không thể bỏ trống";
                namelb.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(name.CreateGraphics(), name.ClientRectangle);
                VeBorder(name, eventArgs, 240, 71, 71);
                tbNameDontHandle = true;
            }
            if (tbPass.Text == string.Empty)
            {
                lbPass.Text = "- Mục này không thể bỏ trống";
                passlb.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(pass.CreateGraphics(), pass.ClientRectangle);
                VeBorder(pass, eventArgs, 240, 71, 71);
                tbPassDontHandle = true;
            }
            int rs = Controller.ThemUser(tbMail.Text, tbPass.Text, comboBox1.SelectedItem.ToString(), tbName.Text);
            if (rs == 1)
            {
                lbMail.ForeColor = Color.FromArgb(77, 222, 19);
                lbMail.Text = "- Thêm thành công!";
                mailb.ForeColor = Color.FromArgb(77, 222, 19);
                PaintEventArgs eventArgs = new PaintEventArgs(mail.CreateGraphics(), mail.ClientRectangle);
                VeBorder(mail, eventArgs, 77, 222, 19);
                tbMailDontHandle = true;
            }
            else if (rs == -99)
            {
                lbMail.Text = "- Lỗi kết nối";
                mailb.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(mail.CreateGraphics(), mail.ClientRectangle);
                VeBorder(mail, eventArgs, 240, 71, 71);
                tbMailDontHandle = true;
            }
            else if (rs == 0)
            {
                lbMail.Text = "- Email này đã tồn tại";
                mailb.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(mail.CreateGraphics(), mail.ClientRectangle);
                VeBorder(mail, eventArgs, 240, 71, 71);
                tbMailDontHandle = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (timerIsAlive == false)
            {
                lbMail.Text = "";
                lbName.Text = "";
                lbPass.Text = "";
                lbMail.ForeColor = Color.FromArgb(240, 71, 71);
                mailb.ForeColor = Color.FromArgb(138, 142, 147);
                namelb.ForeColor = Color.FromArgb(138, 142, 147);
                passlb.ForeColor = Color.FromArgb(138, 142, 147);
                timerIsAlive = true;
                timer1.Enabled = true;
                timer1_Tick(null, null);
                timer2.Enabled = true;
                timer3.Enabled = true;
                tbMail.Enabled = false;
                tbName.Enabled = false;
                tbPass.Enabled = false;
            }
        }
    }
}
