using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Server
{
    public partial class Loading : Form
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

        Image[] images = new Image[200];
        public Loading()
        {
            InitializeComponent();
            LoadImages();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }
        private void LoadImages()
        {
            for (int i = 0; i <= 199; i++)
            {
                string path = $@"{Directory.GetParent(Path.GetFullPath(Application.StartupPath)).Parent.FullName}\Resources\img\{"logo" + i}.png";
                Image image = Image.FromFile(path);
                images[i] = image;
            }
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i % 200;
            pictureBox1.Image = images[i];
            i += 1;
        }
        private void freeMemory()
        {
            timer1.Dispose();
            timer2.Dispose();
            timer3.Dispose();
            images = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            Login f = new Login();
            freeMemory();
            Hide();
            f.ShowDialog();
            Close();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 400, WinAPI.BLEND);
            timer3_Tick(null, null);
        }
        string[] mess = new string[] { "INITIALIZING...", "LOADING...", "STARTING..." };
        int k = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (k < 3)
            {
                label1.Text = mess[k];
            }
            k++;
        }
    }
}
