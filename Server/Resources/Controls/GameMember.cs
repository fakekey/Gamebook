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
    public partial class GameMember : UserControl
    {
        public GameMember()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        private void panelRadius1_MouseEnter(object sender, EventArgs e)
        {
            panelRadius1.rColor = Color.FromArgb(54, 57, 63);
            panelRadius1.Refresh();
        }

        private void panelRadius1_MouseLeave(object sender, EventArgs e)
        {
            panelRadius1.rColor = Color.FromArgb(48, 51, 57);
            panelRadius1.Refresh();
        }
        private string idGame;
        public string ID_Game { get => idGame; set => idGame = value; }
        public string TenGame { get => label1.Text; set => label1.Text = value; }
        public string Gia { get => label2.Text; set => label2.Text = "$" + value; }

        private void panelRadius1_Click(object sender, EventArgs e)
        {
            CheckClass.count = 1;
            CheckClass.IDGameNowSelected = ID_Game;
            CheckClass.TenGameNowSelected = TenGame;
            CheckClass.DonGiaNowSelected = Gia.Replace("$", "");
            this.Dispose();
        }
    }
}
