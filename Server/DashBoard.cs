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
            if (panel2.Width != 73)
            {
                panel2.Width = 73;
                panel18.BackgroundImage = Properties.Resources.icons8_next_page_48px;
            }
            else
            {
                panel2.Width = 200;
                panel18.BackgroundImage = Properties.Resources.icons8_back_to_48px;
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
                if (icoUser.Radius == 14)
                {
                    icoUser.rColor = Color.FromArgb(54, 57, 63);
                    icoUser.Radius = 48;
                    icoUser.Refresh();
                    active2.rColor = Color.Transparent;
                    active2.Refresh();
                }
            }
            else
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
            if (activeTwo == true)
            {
                if (icoHome.Radius == 14)
                {
                    icoHome.rColor = Color.FromArgb(54, 57, 63);
                    icoHome.Radius = 48;
                    icoHome.Refresh();
                    active1.rColor = Color.Transparent;
                    active1.Refresh();
                }
                if (icoProduct.Radius == 14)
                {
                    icoProduct.rColor = Color.FromArgb(54, 57, 63);
                    icoProduct.Radius = 48;
                    icoProduct.Refresh();
                    active3.rColor = Color.Transparent;
                    active3.Refresh();
                }
            }
            else
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
            if (activeThree == true)
            {
                if (icoUser.Radius == 14)
                {
                    icoUser.rColor = Color.FromArgb(54, 57, 63);
                    icoUser.Radius = 48;
                    icoUser.Refresh();
                    active2.rColor = Color.Transparent;
                    active2.Refresh();
                }
                if (icoBill.Radius == 14)
                {
                    icoBill.rColor = Color.FromArgb(54, 57, 63);
                    icoBill.Radius = 48;
                    icoBill.Refresh();
                    active4.rColor = Color.Transparent;
                    active4.Refresh();
                }
            }
            else
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
            if (activeFour == true)
            {
                if (icoProduct.Radius == 14)
                {
                    icoProduct.rColor = Color.FromArgb(54, 57, 63);
                    icoProduct.Radius = 48;
                    icoProduct.Refresh();
                    active3.rColor = Color.Transparent;
                    active3.Refresh();
                }
                if (icoCollapse.Radius == 14)
                {
                    icoCollapse.rColor = Color.FromArgb(54, 57, 63);
                    icoCollapse.Radius = 48;
                    icoCollapse.Refresh();
                    active5.rColor = Color.Transparent;
                    active5.Refresh();
                }
            }
            else
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
            if (activeFive == true)
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
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = activeFive = false;
            clear();
        }

        private void sPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = activeFive = false;
            clear();
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
    }
}
