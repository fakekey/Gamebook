using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ListProduct : UserControl
    {
        public static Color FIRST_COLOR = Color.FromArgb(52, 55, 60);
        public static Color SECOND_COLOR = Color.FromArgb(54, 57, 63);
        public ListProduct()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }
        public Color bgColor { get => this.BackColor; set => this.BackColor = value; }
        public bool isChecked { get => checkBox1.Checked; set => checkBox1.Checked = value; }
        private int lid;
        public string lTieuDe { get => lbtieude.Text; set => lbtieude.Text = value; }
        public string lNsx { get => lbnsx.Text; set => lbnsx.Text = value; }
        public string lPhienBan { get => lbpb.Text; set => lbpb.Text = value; }
        public string lNgay { get => lbngay.Text; set => lbngay.Text = value; }
        public string lGia { get => lbgia.Text; set => lbgia.Text = value; }
        public string lIconPath { get; set; }
        public int lID { get => lid; set => lid = value; }

        private void btnSua_MouseEnter(object sender, EventArgs e)
        {
            btnSua.ForeColor = Color.White;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.ForeColor = Color.FromArgb(114, 137, 218);
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            btnXoa.ForeColor = Color.FromArgb(238, 42, 49);
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.ForeColor = Color.FromArgb(255, 119, 117);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Messagebox.Show("CẢNH BÁO", "Bạn có chắc muốn xóa không? Nếu xóa các hóa đơn liên quan sẽ bị ảnh hưởng!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CheckClass.count = 1;
                Controller.XoaSP(this.lID);
                this.Dispose();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (Form f = new Form())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowInTaskbar = false;
                f.BackColor = Color.Black;
                f.Opacity = 0.85f;
                f.Location = this.Parent.Parent.Parent.Parent.Location;
                f.Size = this.Parent.Parent.Parent.Parent.Size;
                using (EditProduct fOverlay = new EditProduct(lIconPath, lTieuDe, lPhienBan, lGia, lNgay, lNsx))
                {
                    f.Show();
                    fOverlay.Owner = f;
                    fOverlay.ShowDialog();
                    CheckClass.count = 1;
                    this.Dispose();
                }
            }
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {
            panel5.BackgroundImage = Image.FromFile(lIconPath);
        }
    }
}
