using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class ListBill : UserControl
    {
        public static Color FIRST_COLOR = Color.FromArgb(52, 55, 60);
        public static Color SECOND_COLOR = Color.FromArgb(54, 57, 63);
        public ListBill()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }
        public Color bgColor { get => this.BackColor; set => this.BackColor = value; }
        public bool isChecked { get => checkBox1.Checked; set => checkBox1.Checked = value; }
        public string lMaHD { get => lbMaHD.Text; set => lbMaHD.Text = value; }
        public string lTenKH { get => lbTenKH.Text; set => lbTenKH.Text = value; }
        public string lNgayMua { get => lbNgayMua.Text; set => lbNgayMua.Text = value; }
        public string lTien { get => lbTien.Text; set => lbTien.Text = value; }
        public string lTinhTrang { get; set; }
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

        private void panelRadius1_Click(object sender, EventArgs e)
        {
            if (lTinhTrang == "1")
            {
                panelRadius1.rColor = Color.FromArgb(67, 181, 129);
                panel2.BackgroundImage = Properties.Resources.icons8_ok_24;
                panel2.Dock = DockStyle.Right;
                panelRadius1.Refresh();
                lTinhTrang = "2";
            }
            else
            {
                panelRadius1.rColor = Color.FromArgb(114, 118, 125);
                panel2.BackgroundImage = Properties.Resources.icons8_cancel_24;
                panel2.Dock = DockStyle.Left;
                panelRadius1.Refresh();
                lTinhTrang = "1";
            }
            CheckClass.count = 1;
            Controller.SuaBill(this.lMaHD, this.lTinhTrang);
            this.Dispose();
        }

        private void ListBill_Load(object sender, EventArgs e)
        {
            if (lTinhTrang == "1")
            {
                panelRadius1.rColor = Color.FromArgb(114, 118, 125);
                panel2.BackgroundImage = Properties.Resources.icons8_cancel_24;
                panel2.Dock = DockStyle.Left;
                panelRadius1.Refresh();
                btnXoa.Text = "Hủy";
            }
            else if (lTinhTrang == "2")
            {
                panelRadius1.rColor = Color.FromArgb(67, 181, 129);
                panel2.BackgroundImage = Properties.Resources.icons8_ok_24;
                panel2.Dock = DockStyle.Right;
                panelRadius1.Refresh();
                btnXoa.Text = "Hủy";
            }
            else
            {
                panelRadius1.rColor = Color.FromArgb(240, 71, 71);
                panel2.BackgroundImage = Properties.Resources.icons8_cancel_24;
                panel2.Dock = DockStyle.Fill;
                panelRadius1.Refresh();
                panelRadius1.Enabled = false;
                btnXoa.Text = "Xóa vĩnh viễn";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {   
            if(btnXoa.Text == "Hủy")
            {
                if (Messagebox.Show("CẢNH BÁO", "Bạn có chắc muốn hủy hóa đơn này không? Nếu hủy sẽ không thể xử lý được hóa đơn này!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CheckClass.count = 1;
                    Controller.HuyBill(this.lMaHD);
                    this.Dispose();
                }
            }
            else
            {
                if (Messagebox.Show("CẢNH BÁO", "Bạn có chắc muốn xóa vĩnh viễn hóa đơn này không? ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CheckClass.count = 1;
                    Controller.XoaBill(this.lMaHD);
                    this.Dispose();
                }
            }
        }

    }
}
