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
    public partial class DashBoard : Form
    {
        public DashBoard(string name)
        {
            InitializeComponent();
            lbName.Text = name;
            panel20.Visible = false;
            message1.Hien = message2.Hien = message3.Hien = message4.Hien = message5.Hien = false;
        }
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
        private void DashBoard_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 400, WinAPI.BLEND);
            panel4_MouseMove(null, null);
            icoHome_Click(null, null);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragControl.mouseDown(this);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            DragControl.mouseMove(this);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            DragControl.mouseUp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            if (panel2.Width != 97)
            {
                label2.Text = label3.Text = label4.Text = label5.Text = label6.Text = "";
                panel2.Width = 97;
                panel18.BackgroundImage = Properties.Resources.icons8_next_page_48px;
                panel20.Visible = true;
            }
            else
            {
                label2.Text = "Home";
                label3.Text = "Users";
                label4.Text = "Products";
                label5.Text = "Bills";
                label6.Text = "Collapse";
                panel2.Width = 217;
                panel18.BackgroundImage = Properties.Resources.icons8_back_to_48px;
                panel20.Visible = false;
            }
        }

        bool activeOne = false;
        bool activeTwo = false;
        bool activeThree = false;
        bool activeFour = false;
        bool activeFive = false;

        private void clear()
        {
            if (activeOne == true)
            {
                if (panel2.Width == 97)
                {
                    message2.Hien = false;
                }
                if (userIsActive == false)
                {
                    if (icoUser.Radius == 14)
                    {
                        icoUser.rColor = Color.FromArgb(54, 57, 63);
                        icoUser.Radius = 48;
                        icoUser.Refresh();
                        active2.rColor = Color.Transparent;
                        active2.Refresh();
                    }
                }

            }
            else
            {
                if (panel2.Width == 97)
                {
                    message1.Hien = false;
                }
                if (homeIsActive == false)
                {
                    if (icoHome.Radius == 14)
                    {
                        icoHome.rColor = Color.FromArgb(54, 57, 63);
                        icoHome.Radius = 48;
                        icoHome.Refresh();
                        active1.rColor = Color.Transparent;
                        active1.Refresh();
                    }
                }
            }
            if (activeTwo == true)
            {
                if (panel2.Width == 97)
                {
                    message1.Hien = false;
                }
                if (homeIsActive == false)
                {
                    if (icoHome.Radius == 14)
                    {
                        icoHome.rColor = Color.FromArgb(54, 57, 63);
                        icoHome.Radius = 48;
                        icoHome.Refresh();
                        active1.rColor = Color.Transparent;
                        active1.Refresh();
                    }
                }
                if (panel2.Width == 97)
                {
                    message3.Hien = false;
                }
                if (productIsActive == false)
                {
                    if (icoProduct.Radius == 14)
                    {
                        icoProduct.rColor = Color.FromArgb(54, 57, 63);
                        icoProduct.Radius = 48;
                        icoProduct.Refresh();
                        active3.rColor = Color.Transparent;
                        active3.Refresh();
                    }
                }
            }
            else
            {
                if (panel2.Width == 97)
                {
                    message2.Hien = false;
                }
                if (userIsActive == false)
                {
                    if (icoUser.Radius == 14)
                    {
                        icoUser.rColor = Color.FromArgb(54, 57, 63);
                        icoUser.Radius = 48;
                        icoUser.Refresh();
                        active2.rColor = Color.Transparent;
                        active2.Refresh();
                    }
                }
            }
            if (activeThree == true)
            {
                if (panel2.Width == 97)
                {
                    message2.Hien = false;
                }
                if (userIsActive == false)
                {
                    if (icoUser.Radius == 14)
                    {
                        icoUser.rColor = Color.FromArgb(54, 57, 63);
                        icoUser.Radius = 48;
                        icoUser.Refresh();
                        active2.rColor = Color.Transparent;
                        active2.Refresh();
                    }
                }
                if (panel2.Width == 97)
                {
                    message4.Hien = false;
                }
                if (billIsActive == false)
                {
                    if (icoBill.Radius == 14)
                    {
                        icoBill.rColor = Color.FromArgb(54, 57, 63);
                        icoBill.Radius = 48;
                        icoBill.Refresh();
                        active4.rColor = Color.Transparent;
                        active4.Refresh();
                    }
                }

            }
            else
            {
                if (panel2.Width == 97)
                {
                    message3.Hien = false;
                }
                if (productIsActive == false)
                {
                    if (icoProduct.Radius == 14)
                    {
                        icoProduct.rColor = Color.FromArgb(54, 57, 63);
                        icoProduct.Radius = 48;
                        icoProduct.Refresh();
                        active3.rColor = Color.Transparent;
                        active3.Refresh();
                    }
                }
            }
            if (activeFour == true)
            {
                if (panel2.Width == 97)
                {
                    message3.Hien = false;
                }
                if (productIsActive == false)
                {
                    if (icoProduct.Radius == 14)
                    {
                        icoProduct.rColor = Color.FromArgb(54, 57, 63);
                        icoProduct.Radius = 48;
                        icoProduct.Refresh();
                        active3.rColor = Color.Transparent;
                        active3.Refresh();
                    }
                }
                if (icoCollapse.Radius == 14)
                {
                    icoCollapse.rColor = Color.FromArgb(54, 57, 63);
                    icoCollapse.Radius = 48;
                    icoCollapse.Refresh();
                    active5.rColor = Color.Transparent;
                    active5.Refresh();
                }
                if (panel2.Width == 97)
                {
                    message5.Hien = false;
                }
            }
            else
            {
                if (panel2.Width == 97)
                {
                    message4.Hien = false;
                }
                if (billIsActive == false)
                {
                    if (icoBill.Radius == 14)
                    {
                        icoBill.rColor = Color.FromArgb(54, 57, 63);
                        icoBill.Radius = 48;
                        icoBill.Refresh();
                        active4.rColor = Color.Transparent;
                        active4.Refresh();
                    }
                }
            }
            if (activeFive == true)
            {
                if (panel2.Width == 97)
                {
                    message4.Hien = false;
                }
                if (billIsActive == false)
                {
                    if (icoBill.Radius == 14)
                    {
                        icoBill.rColor = Color.FromArgb(54, 57, 63);
                        icoBill.Radius = 48;
                        icoBill.Refresh();
                        active4.rColor = Color.Transparent;
                        active4.Refresh();
                    }
                }
            }
            else
            {
                if (icoCollapse.Radius == 14)
                {
                    icoCollapse.rColor = Color.FromArgb(54, 57, 63);
                    icoCollapse.Radius = 48;
                    icoCollapse.Refresh();
                    active5.rColor = Color.Transparent;
                    active5.Refresh();
                }
                if (panel2.Width == 97)
                {
                    message5.Hien = false;
                }

            }
        }
        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            activeTwo = activeOne = activeFour = activeThree = false;
            activeFive = true;
            clear();
            if (icoCollapse.Radius == 48)
            {
                active5.rColor = Color.White;
                active5.Refresh();
                icoCollapse.rColor = Color.FromArgb(114, 137, 218);
                icoCollapse.Radius = 14;
                icoCollapse.Refresh();
            }
            if (panel2.Width == 97)
            {
                message5.Hien = true;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = activeFive = false;
            clear();
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeThree = activeFour = activeFive = false;
            activeTwo = true;
            clear();
            if (icoUser.Radius == 48)
            {
                active2.rColor = Color.White;
                active2.Refresh();
                icoUser.rColor = Color.FromArgb(114, 137, 218);
                icoUser.Radius = 14;
                icoUser.Refresh();
            }
            if (panel2.Width == 97)
            {
                message2.Hien = true;
            }
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            activeTwo = activeOne = activeFour = activeFive = false;
            activeThree = true;
            clear();
            if (icoProduct.Radius == 48)
            {
                active3.rColor = Color.White;
                active3.Refresh();
                icoProduct.rColor = Color.FromArgb(114, 137, 218);
                icoProduct.Radius = 14;
                icoProduct.Refresh();
            }
            if (panel2.Width == 97)
            {
                message3.Hien = true;
            }
        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {
            activeTwo = activeOne = activeThree = activeFive = false;
            activeFour = true;
            clear();
            if (icoBill.Radius == 48)
            {
                active4.rColor = Color.White;
                active4.Refresh();
                icoBill.rColor = Color.FromArgb(114, 137, 218);
                icoBill.Radius = 14;
                icoBill.Refresh();
            }
            if (panel2.Width == 97)
            {
                message4.Hien = true;
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            activeTwo = activeThree = activeFour = activeFive = false;
            activeOne = true;
            clear();
            if (icoHome.Radius == 48)
            {
                active1.rColor = Color.White;
                active1.Refresh();
                icoHome.rColor = Color.FromArgb(114, 137, 218);
                icoHome.Radius = 14;
                icoHome.Refresh();
            }
            if (panel2.Width == 97)
            {
                message1.Hien = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel17_Click(null, null);
        }

        private void icoCollapse_Click(object sender, EventArgs e)
        {
            panel17_Click(null, null);
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            panel17_Click(null, null);
        }
        bool homeIsActive = false;
        bool userIsActive = false;
        bool productIsActive = false;
        bool billIsActive = false;
        private void panel4_Click(object sender, EventArgs e)
        {
            userIsActive = productIsActive = billIsActive = false;
            homeIsActive = true;
            clear();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            homeIsActive = productIsActive = billIsActive = false;
            userIsActive = true;
            clear();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            userIsActive = homeIsActive = billIsActive = false;
            productIsActive = true;
            clear();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            userIsActive = productIsActive = homeIsActive = false;
            billIsActive = true;
            clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel4_Click(null, null);
        }

        private void icoHome_Click(object sender, EventArgs e)
        {
            panel4_Click(null, null);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel4_Click(null, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel8_Click(null, null);
        }

        private void icoUser_Click(object sender, EventArgs e)
        {
            panel8_Click(null, null);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel8_Click(null, null);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel11_Click(null, null);
        }

        private void icoProduct_Click(object sender, EventArgs e)
        {
            panel11_Click(null, null);
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel11_Click(null, null);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel14_Click(null, null);
        }

        private void icoBill_Click(object sender, EventArgs e)
        {
            panel14_Click(null, null);
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            panel14_Click(null, null);
        }

        private void panelRadius1_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = activeFive = false;
            clear();
        }

        private void panel7_MouseMove_1(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = activeFive = false;
            clear();
        }
    }
}
