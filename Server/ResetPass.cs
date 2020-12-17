using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class ResetPass : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private string email;
        public ResetPass(string email)
        {
            this.email = email;
            InitializeComponent();
            textBox1.AutoSize = false;
            textBox1.Size = new Size(371, 22);
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void usertb_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(usertb, e, 34, 36, 40);
        }
        private void VeBorder(Control control, PaintEventArgs e, int r, int g, int b)
        {
            ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.FromArgb(r, g, b), ButtonBorderStyle.Solid);
        }
        bool tbUserDontHandle = false;

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (tbUserDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                VeBorder(usertb, eventArgs, 4, 4, 5);
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (tbUserDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                VeBorder(usertb, eventArgs, 34, 36, 40);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            tbUserDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
            VeBorder(usertb, eventArgs, 114, 137, 218);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
            VeBorder(usertb, eventArgs, 34, 36, 40);
            tbUserDontHandle = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            timer1.Stop();
            j = 0;
            timerIsAlive = false;
            btnLogin.Text = "Xác Nhận";
            if (textBox1.Text == string.Empty)
            {
                lbUser.Text = "- Mục này không thể bỏ trống";
                label3.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                VeBorder(usertb, eventArgs, 240, 71, 71);
                tbUserDontHandle = true;
            }
            else
            {
                int rs = Controller.changePassword(this.email, textBox1.Text);
                switch (rs)
                {
                    case 1:
                        lbUser.ForeColor = Color.FromArgb(77, 222, 19);
                        lbUser.Text = "- Thành công! Mời bạn quay trở lại đăng nhập";
                        label3.ForeColor = Color.FromArgb(77, 222, 19);
                        PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                        VeBorder(usertb, eventArgs, 77, 222, 19);
                        tbUserDontHandle = true;
                        break;
                    case -1:
                        lbUser.Text = "- Thất bại! Vui lòng thử lại sau";
                        label3.ForeColor = Color.FromArgb(240, 71, 71);
                        PaintEventArgs eventArgs2 = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                        VeBorder(usertb, eventArgs2, 240, 71, 71);
                        tbUserDontHandle = true;
                        break;
                    case -99:
                        lbUser.Text = "- Lỗi kết nối";
                        label3.ForeColor = Color.FromArgb(240, 71, 71);
                        PaintEventArgs eventArgs3 = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                        VeBorder(usertb, eventArgs3, 240, 71, 71);
                        tbUserDontHandle = true;
                        break;
                    default:
                        break;
                }
            }
            textBox1.Enabled = true;
        }
        int j = 0;
        string[] dotArr = new string[] { "•", "• •", "• • •" };
        bool timerIsAlive = false;
        private void timer3_Tick(object sender, EventArgs e)
        {
            j = j % 3;
            btnLogin.Text = dotArr[j];
            j++;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (timerIsAlive == false)
            {
                lbUser.Text = "";
                lbUser.ForeColor = Color.FromArgb(240, 71, 71);
                label3.ForeColor = Color.FromArgb(138, 142, 147);
                timerIsAlive = true;
                timer3.Enabled = true;
                timer3_Tick(null, null);
                timer1.Enabled = true;
                textBox1.Enabled = false;
            }
        }

        private void ResetPass_MouseDown(object sender, MouseEventArgs e)
        {
            DragControl.mouseDown(this);
        }

        private void ResetPass_MouseMove(object sender, MouseEventArgs e)
        {
            DragControl.mouseMove(this);
        }

        private void ResetPass_MouseUp(object sender, MouseEventArgs e)
        {
            DragControl.mouseUp();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.Font = new Font("Quicksand", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Pixel, 0);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font("Quicksand", 13F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            Close();
        }
    }
}
