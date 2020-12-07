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
    }
}
