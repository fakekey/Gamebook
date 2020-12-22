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
    public partial class Block : UserControl
    {
        public Block()
        {
            InitializeComponent();
        }
        public string LabelTitle { get => label1.Text; set => label1.Text = value; }
        public string Count { get => label2.Text; set => label2.Text = value; }
        public string ThangTruoc { get => label5.Text; set => label5.Text = value; }
        public string SoVoiThangTruoc { get => label4.Text; set => label4.Text = value; }
        public string Percent { get => label7.Text; set => label7.Text = value; }
        public bool isTang { get; set; }

        private void panelRadius1_MouseEnter(object sender, EventArgs e)
        {
            panelRadius1.rColor = Color.FromArgb(32, 34, 37);
            panelRadius1.Refresh();
        }

        private void panelRadius1_MouseLeave(object sender, EventArgs e)
        {
            panelRadius1.rColor = Color.FromArgb(41, 43, 47);
            panelRadius1.Refresh();
        }

        public void Block_Load(object sender, EventArgs e)
        {
            if (isTang == true)
            {
                Percent = $"+ {Percent.Replace("+", "")}%";
                SoVoiThangTruoc = $"+ {SoVoiThangTruoc.Replace("+", "")}";
                panel1.BackgroundImage = Properties.Resources.icons8_send_letter_48;
            }
            else
            {
                Percent = $"- {Percent.Replace("-", "")}%";
                SoVoiThangTruoc = $"- {SoVoiThangTruoc.Replace("-", "")}";
                panel1.BackgroundImage = Properties.Resources.icons8_below_48;
            }
        }
    }
}
