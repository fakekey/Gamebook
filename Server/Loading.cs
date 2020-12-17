using System;
using System.Drawing;
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
        public Loading()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i % 200;
            pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"logo{i}");
            i += 1;
        }
        private void freeMemory()
        {
            timer1.Dispose();
            timer2.Dispose();
            timer3.Dispose();
            mess = null;
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
            timer3_Tick(null, null);
        }
        string[] mess = new string[] { "KIỂM TRA CẬP NHẬT...", "ĐANG KHỞI TẠO...", "ĐANG TẢI...", "ĐANG BẮT ĐẦU..." };
        int k = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (k < 4)
            {
                label1.Text = mess[k];
            }
            k++;
        }
    }
}
