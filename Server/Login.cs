using System;
using System.Drawing;
using System.Windows.Forms;
using Server.Resources.classes;

namespace Server
{
    public partial class Login : Form
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
        public Login()
        {
            InitializeComponent();
            textBox1.AutoSize = false;
            textBox1.Size = new Size(371, 22);
            textBox2.AutoSize = false;
            textBox2.Size = new Size(371, 22);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 550, WinAPI.BLEND);
        }

        private void usertb_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(usertb, e, 34, 36, 40);
        }

        private void passtb_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(passtb, e, 34, 36, 40);
        }
        private void VeBorder(Control control, PaintEventArgs e, int r, int g, int b)
        {
            ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.FromArgb(r, g, b), ButtonBorderStyle.Solid);
        }
        private void VeBorder(Control control, PaintEventArgs e, int a, int r, int g, int b)
        {
            ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.FromArgb(a, r, g, b), ButtonBorderStyle.Solid);
        }
        bool tbUserDontHandle = false;
        bool tbPassDontHandle = false;
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

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (tbPassDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(passtb.CreateGraphics(), passtb.ClientRectangle);
                VeBorder(passtb, eventArgs, 4, 4, 5);
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (tbPassDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(passtb.CreateGraphics(), passtb.ClientRectangle);
                VeBorder(passtb, eventArgs, 34, 36, 40);
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

        private void textBox2_Enter(object sender, EventArgs e)
        {
            tbPassDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(passtb.CreateGraphics(), passtb.ClientRectangle);
            VeBorder(passtb, eventArgs, 114, 137, 218);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(passtb.CreateGraphics(), passtb.ClientRectangle);
            VeBorder(passtb, eventArgs, 34, 36, 40);
            tbPassDontHandle = false;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.Font = new Font("Quicksand", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Pixel, 0);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font("Quicksand", 13F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            DragControl.mouseDown(this);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            DragControl.mouseUp();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            DragControl.mouseMove(this);
        }

        private void label6_Click(object sender, EventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (timerIsAlive == false)
            {
                lbUser.Text = "";
                lbPass.Text = "";
                label3.ForeColor = Color.FromArgb(138, 142, 147);
                label4.ForeColor = Color.FromArgb(138, 142, 147);
                timerIsAlive = true;
                timer1.Enabled = true;
                timer1_Tick(null, null);
                timer2.Enabled = true;
                timer3.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            j = 0;
            btnLogin.Text = "Login";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            timerIsAlive = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "":
                    lbUser.Text = "- This field cannot be empty";
                    label3.ForeColor = Color.FromArgb(240, 71, 71);
                    PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                    VeBorder(usertb, eventArgs, 240, 71, 71);
                    tbUserDontHandle = true;
                    break;
                default:
                    break;
            }
            switch (textBox2.Text)
            {
                case "":
                    lbPass.Text = "- This field cannot be empty";
                    label4.ForeColor = Color.FromArgb(240, 71, 71);
                    PaintEventArgs eventArgs = new PaintEventArgs(passtb.CreateGraphics(), passtb.ClientRectangle);
                    VeBorder(passtb, eventArgs, 240, 71, 71);
                    tbPassDontHandle = true;
                    break;
                default:
                    break;
            }

            timer3.Stop();

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                int rs = Controller.checkLogin(textBox1.Text, textBox2.Text);
                if(rs == 1)
                {
                    DashBoard f = new DashBoard();
                    Hide();
                    f.ShowDialog();
                    Close();
                }else if( rs == 0)
                {
                    Msb.Show("Tài khoản của bạn không có quyền truy cập !", "Lỗi quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if(rs == -99)
                {
                    Msb.Show("Lỗi kết nối đến server vui lòng truy cập lại sau !", " Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if(rs == -1)
                {
                    Msb.Show("Sai tài Khoản / mật khẩu. Vui lòng đăng nhập lại !", " Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lbUser.Text = "";
            label3.ForeColor = Color.FromArgb(138, 142, 147);
            timer4.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            if (textBox1.Text == string.Empty)
            {
                lbUser.Text = "- This field cannot be empty";
                label3.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                VeBorder(usertb, eventArgs, 240, 71, 71);
                tbUserDontHandle = true;
            }
            else
            {
                int rs = Controller.checkEmail(textBox1.Text);
                if( rs == 1)
                {
                    ResetPass f = new ResetPass(textBox1.Text);
                    Hide();
                    f.ShowDialog();
                    Show();
                }
                else if( rs == -1)
                {
                    Msb.Show("Không tồn tại tài Khoản. Vui lòng đăng nhập lại !", " Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(rs == -99)
                {
                    Msb.Show("Lỗi kết nối đến server vui lòng truy cập lại sau !", " Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }
    }
}
