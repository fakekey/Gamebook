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
    public partial class MsbYesNo : Form
    {
        public MsbYesNo()
        {
            InitializeComponent();
        }

        private void MsbYesNo_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panelRadius3.rColor = Color.FromArgb(216, 64, 64);
            panelRadius3.Refresh();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panelRadius3.rColor = Color.FromArgb(240, 71, 71);
            panelRadius3.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font("Quicksand", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Pixel, 0);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font("Quicksand", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
        }
        public string mTitle { get => label3.Text; set => label3.Text = value; }
        public string mContent { get => label4.Text; set => label4.Text = value; }
    }
}
