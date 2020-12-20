using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class Bills : Form
    {
        List<Bill> dsdaxuly = new List<Bill>();
        List<Bill> dsdahuy = new List<Bill>();
        List<Bill> dschuaxuly = new List<Bill>();
        List<Bill> dsAll = new List<Bill>();
        public Bills()
        {
            InitializeComponent();
            icoOverlay = new PictureBox();
            icoOverlay.BackColor = Color.Transparent;
            icoOverlay.Dock = DockStyle.Fill;
            icoOverlay.SizeMode = PictureBoxSizeMode.Zoom;
            loadOverlay = new Panel()
            {
                Bounds = new Rectangle(0, 251, 1111, 447),
                Padding = new Padding(505, 132, 505, 200),
                BackColor = Color.FromArgb(47, 49, 54),
            };
            loadOverlay.Controls.Add(icoOverlay);
            this.Controls.Add(loadOverlay);
            comboBox1.SelectedIndex = 0;
            textBox1.AutoSize = false;
            textBox1.Size = new Size(230, 22);
            setdata();

            if (dsAll.Count != 0)
            {
                label3.Text = $"({dschuaxuly.Count.ToString()})";
                label5.Text = $"({dsdaxuly.Count.ToString()})";
                label7.Text = $"({dsdahuy.Count.ToString()})";
                label2.Text = $"({dsAll.Count.ToString()})";
            } 
            else
            {
                btnTatCa.Enabled = false;
                btnChua.Enabled = false;
                btnHuy.Enabled = false;
                btnDa.Enabled = false;
            }
        }

        private void setdata()
        {
            dsAll = Controller.GetBill();
            if(dschuaxuly == null)
            {
                dsdaxuly = new List<Bill>();
                dsdahuy = new List<Bill>();
                dschuaxuly = new List<Bill>();
            }
            foreach (Bill item in dsAll)
            {
                if (item._matinhtrang == "1")
                {
                    dschuaxuly.Add(item);
                }
                if (item._matinhtrang == "2")
                {
                    dsdaxuly.Add(item);
                }
                if (item._matinhtrang == "3")
                {
                    dsdahuy.Add(item);
                }
            }
        }
        private int nBills;
        public int leftPaddingTenKH
        {
            set
            {
                lbTenKH.Padding = new Padding(value, 0, 0, 0);
            }
        }
        public int leftPaddingNgayMua
        {
            set
            {
                lbNgayMua.Padding = new Padding(value, 0, 0, 0);
            }
        }
        public int leftPaddingTien
        {
            set
            {
                lbTongTien.Padding = new Padding(value, 0, 0, 0);
            }
        }
        public int leftPaddingTinhTrang
        {
            set
            {
                lbTinhTrang.Padding = new Padding(value, 0, 0, 0);
            }
        }

        private void addToPanel(List<Bill> ds)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (i % 2 == 0)
                {
                    pnDisplay.Controls.Add(new ListBill()
                    {
                        lMaHD = ds[i]._mahd,
                        lTenKH = ds[i]._tenkhach,
                        lNgayMua = ds[i]._ngaymua,
                        lTien = ds[i]._tongtien,
                        lTinhTrang = ds[i]._matinhtrang,
                        bgColor = ListBill.FIRST_COLOR,
                    });
                }
                else
                {
                    pnDisplay.Controls.Add(new ListBill()
                    {
                        lMaHD = ds[i]._mahd,
                        lTenKH = ds[i]._tenkhach,
                        lNgayMua = ds[i]._ngaymua,
                        lTien = ds[i]._tongtien,
                        lTinhTrang = ds[i]._matinhtrang,
                        bgColor = ListBill.SECOND_COLOR,
                    });
                }
            }
        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            using (f = new Form())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowInTaskbar = false;
                f.BackColor = Color.Black;
                f.Opacity = 0.85f;
                f.Location = this.Parent.Parent.Location;
                f.Size = this.Parent.Parent.Size;
                using (AddUser fOverlay = new AddUser())
                {
                    f.Show();
                    fOverlay.Owner = f;
                    fOverlay.ShowDialog();
                    btnTatCa_Click(null, null);
                }
            }
        }

        private void NoData()
        {
            pnDisplay.Controls.Add(new Label()
            {
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                Font = new Font("Quicksand", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0),
                ForeColor = Color.White,
                Padding = new Padding(0, 0, 0, 50),
                Text = "Không tìm thấy dữ liệu",
                TextAlign = ContentAlignment.MiddleCenter,
            });
        }
        private void btnTatCa_MouseEnter(object sender, EventArgs e)
        {
            if (tatca == false)
            {
                btnTatCa.ForeColor = Color.White;
                pnTatCa.rColor = Color.FromArgb(82, 79, 84, 92);
                pnTatCa.Refresh();
            }
        }

        private void btnTatCa_MouseLeave(object sender, EventArgs e)
        {
            if (tatca == false)
            {
                btnTatCa.ForeColor = Color.FromArgb(220, 221, 222);
                pnTatCa.rColor = Color.Transparent;
                pnTatCa.Refresh();
            }
        }

        private void btnChua_MouseEnter(object sender, EventArgs e)
        {
            if (chuaxuly == false)
            {
                btnChua.ForeColor = Color.White;
                pnAdmin.rColor = Color.FromArgb(82, 79, 84, 92);
                pnAdmin.Refresh();
            }
        }

        private void btnChua_MouseLeave(object sender, EventArgs e)
        {
            if (chuaxuly == false)
            {
                btnChua.ForeColor = Color.FromArgb(220, 221, 222);
                pnAdmin.rColor = Color.Transparent;
                pnAdmin.Refresh();
            }
        }

        private void btnDa_MouseEnter(object sender, EventArgs e)
        {
            if (daxuly == false)
            {
                btnDa.ForeColor = Color.White;
                pnNhanVien.rColor = Color.FromArgb(82, 79, 84, 92);
                pnNhanVien.Refresh();
            }
        }

        private void btnDa_MouseLeave(object sender, EventArgs e)
        {
            if (daxuly == false)
            {
                btnDa.ForeColor = Color.FromArgb(220, 221, 222);
                pnNhanVien.rColor = Color.Transparent;
                pnNhanVien.Refresh();
            }
        }

        private void btnHuy_MouseEnter(object sender, EventArgs e)
        {
            if (dahuy == false)
            {
                btnHuy.ForeColor = Color.White;
                pnKhach.rColor = Color.FromArgb(82, 79, 84, 92);
                pnKhach.Refresh();
            }
        }

        private void btnHuy_MouseLeave(object sender, EventArgs e)
        {
            if (dahuy == false)
            {
                btnHuy.ForeColor = Color.FromArgb(220, 221, 222);
                pnKhach.rColor = Color.Transparent;
                pnKhach.Refresh();
            }
        }
        bool tatca = false;
        bool chuaxuly = false;
        bool daxuly = false;
        bool dahuy = false;
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            reload();
            chuaxuly = daxuly = dahuy = false;
            tatca = true;
            btnTatCa.ForeColor = Color.White;
            pnTatCa.rColor = Color.FromArgb(82, 79, 84, 92);
            clear();
            freeMemory();
            nBills = dsAll.Count;
            ReSize();
            pnDisplay.Controls.Clear();
            if (nBills != 0)
            {
                addToPanel(dsAll);
            }
            else
            {
                NoData();
            }
        }

        private void btnChua_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            reload();
            tatca = daxuly = dahuy = false;
            chuaxuly = true;
            clear();
            nBills = dschuaxuly.Count;
            ReSize();
            freeMemory();
            pnDisplay.Controls.Clear();
            if (nBills != 0)
            {
                addToPanel(dschuaxuly);
            }
            else
            {
                NoData();
            }
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            reload();
            chuaxuly = tatca = dahuy = false;
            daxuly = true;
            clear();
            nBills = dsdaxuly.Count;
            ReSize();
            freeMemory();
            pnDisplay.Controls.Clear();
            if (nBills != 0)
            {
                addToPanel(dsdaxuly);
            }
            else
            {
                NoData();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            reload();
            chuaxuly = daxuly = tatca = false;
            dahuy = true;
            clear();
            nBills = dsdahuy.Count;
            ReSize();
            freeMemory();
            pnDisplay.Controls.Clear();
            if (nBills != 0)
            {
                addToPanel(dsdahuy);
            }
            else
            {
                NoData();
            }
        }
        private void clear()
        {
            if (tatca == false)
            {
                btnTatCa.ForeColor = Color.FromArgb(220, 221, 222);
                pnTatCa.rColor = Color.Transparent;
                pnTatCa.Refresh();
            }
            if (chuaxuly == false)
            {
                btnChua.ForeColor = Color.FromArgb(220, 221, 222);
                pnAdmin.rColor = Color.Transparent;
                pnAdmin.Refresh();
            }
            if (daxuly == false)
            {
                btnDa.ForeColor = Color.FromArgb(220, 221, 222);
                pnNhanVien.rColor = Color.Transparent;
                pnNhanVien.Refresh();
            }
            if (dahuy == false)
            {
                btnHuy.ForeColor = Color.FromArgb(220, 221, 222);
                pnKhach.rColor = Color.Transparent;
                pnKhach.Refresh();
            }
        }
        private void VeBorder(Control control, PaintEventArgs e, int r, int g, int b)
        {
            ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.FromArgb(r, g, b), ButtonBorderStyle.Solid);
        }

        private void usertb_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(usertb, e, 34, 36, 40);
        }

        bool tbUserDontHandle = false;

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (tbUserDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                VeBorder(usertb, eventArgs, 4, 4, 5);
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (tbUserDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
                VeBorder(usertb, eventArgs, 34, 36, 40);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            tbUserDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
            VeBorder(usertb, eventArgs, 114, 137, 218);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(usertb.CreateGraphics(), usertb.ClientRectangle);
            VeBorder(usertb, eventArgs, 34, 36, 40);
            tbUserDontHandle = false;
        }

        public void ReSize()
        {
            if (this.Width == 1231)
            {
                loadOverlay.Bounds = new Rectangle(0, 251, 1231, 447);
                loadOverlay.Padding = new Padding(565, 132, 565, 200);
            }
            else
            {
                loadOverlay.Bounds = new Rectangle(0, 251, 1783, 759);
                loadOverlay.Padding = new Padding(760, 200, 760, 300);
            }
            if (nBills < 7)
            {
                if (this.Width == 1231)
                {
                    leftPaddingTenKH = 44;
                    leftPaddingNgayMua = 34;
                    leftPaddingTien = 34;
                    leftPaddingTinhTrang = 34;
                }
                else
                {
                    leftPaddingTenKH = 43;
                    leftPaddingNgayMua = 33;
                    leftPaddingTien = 32;
                    leftPaddingTinhTrang = 32;
                }
            }
            if (nBills >= 7 && nBills < 11)
            {
                if (this.Width == 1231)
                {
                    leftPaddingTenKH = 42;
                    leftPaddingNgayMua = 27;
                    leftPaddingTien = 22;
                    leftPaddingTinhTrang = 18;
                }
                else
                {
                    leftPaddingTenKH = 43;
                    leftPaddingNgayMua = 33;
                    leftPaddingTien = 32;
                    leftPaddingTinhTrang = 32;
                }
            }
            else if (nBills >= 11)
            {
                if (this.Width == 1231)
                {
                    leftPaddingTenKH = 42;
                    leftPaddingNgayMua = 27;
                    leftPaddingTien = 22;
                    leftPaddingTinhTrang = 18;
                }
                else
                {
                    leftPaddingTenKH = 42;
                    leftPaddingNgayMua = 27;
                    leftPaddingTien = 22;
                    leftPaddingTinhTrang = 18;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dsAll.Count != 0)
            {
                foreach (ListBill item in pnDisplay.Controls)
                {
                    item.isChecked = checkBox1.Checked ? true : false;
                }
            }
        }

        private void noFocusButton3_Click(object sender, EventArgs e)
        {
            string txtFind = textBox1.Text;
            textBox1.Text = "";
            List<Bill> dstk = new List<Bill>(0);
            if (tatca == true)
            {
                foreach (Bill item in dsAll)
                {
                    if (item._mahd.Contains(txtFind) || item._ngaymua.Contains(txtFind) || item._tenkhach.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (chuaxuly == true)
            {
                foreach (Bill item in dschuaxuly)
                {
                    if (item._mahd.Contains(txtFind) || item._ngaymua.Contains(txtFind) || item._tenkhach.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (daxuly == true)
            {
                foreach (Bill item in dsdaxuly)
                {
                    if (item._mahd.Contains(txtFind) || item._ngaymua.Contains(txtFind) || item._tenkhach.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (dahuy == true)
            {
                foreach (Bill item in dsdahuy)
                {
                    if (item._mahd.Contains(txtFind) || item._ngaymua.Contains(txtFind) || item._tenkhach.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            clear();
            nBills = dstk.Count;
            ReSize();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            freeMemory();
            pnDisplay.Controls.Clear();
            if (nBills != 0)
            {
                addToPanel(dstk);
            }
            else
            {
                NoData();
            }
        }
        private Panel loadOverlay;
        private PictureBox icoOverlay;

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i % 125;
            icoOverlay.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"logo{i + 25}");
            i += 1;
        }
        private void freeMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            freeMemory();
            i = 0;
            loadOverlay.Visible = false;
            pnDisplay.Visible = true;
        }

        private void noFocusButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Xóa")
            {
                if (Messagebox.Show("CẢNH BÁO", "Bạn có chắc muốn xóa không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (tatca == true)
                    {
                        if (dsAll.Count != 0)
                        {
                            Xoa();
                        }
                    }
                    else if (chuaxuly == true)
                    {
                        if (dschuaxuly.Count != 0)
                        {
                            Xoa();
                        }
                    }
                    else if (daxuly == true)
                    {
                        if (dsdaxuly.Count != 0)
                        {
                            Xoa();
                        }
                    }
                    else if (dahuy == true)
                    {
                        if (dsdahuy.Count != 0)
                        {
                            Xoa();
                        }
                    }
                }
            }
        }
        private void Xoa()
        {
            foreach (ListBill item in pnDisplay.Controls)
            {
                if (item.isChecked == true && item.lTinhTrang == "3")
                {
                    Controller.XoaBill(item.lMaHD);
                }
            }
            pnDisplay.Visible = false;
            reload();
            if (tatca == true)
            {
                btnTatCa_Click(null, null);
            }
            if (chuaxuly == true)
            {
                btnChua_Click(null, null);
            }
            if (daxuly == true)
            {
                btnDa_Click(null, null);
            }
            if (dahuy == true)
            {
                btnHuy_Click(null, null);
            }
        }
        private void reload()
        {
            dschuaxuly = dsdahuy = dsdaxuly = null;
            setdata();
            if (dsAll.Count != 0)
            {
                label3.Text = $"({dschuaxuly.Count.ToString()})";
                label5.Text = $"({dsdaxuly.Count.ToString()})";
                label7.Text = $"({dsdahuy.Count.ToString()})";
                label2.Text = $"({dsAll.Count.ToString()})";
            }
            else
            {
                btnTatCa.Enabled = false;
                btnChua.Enabled = false;
                btnHuy.Enabled = false;
                btnDa.Enabled = false;
            }

            freeMemory();
            pnDisplay.Controls.Clear();
            if (tatca == true)
            {
                nBills = dsAll.Count;
                ReSize();
                addToPanel(dsAll);
            }
            if (chuaxuly == true)
            {
                nBills = dschuaxuly.Count;
                ReSize();
                addToPanel(dschuaxuly);
            }
            if (daxuly == true)
            {
                nBills = dsdaxuly.Count;
                ReSize();
                addToPanel(dsdaxuly);
            }
            if (dahuy == true)
            {
                nBills = dsdahuy.Count;
                ReSize();
                addToPanel(dsdahuy);
            }
        }
        private void pnDisplay_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (CheckClass.count != 0)
            {
                if (tatca == true)
                {
                    btnTatCa_Click(sender, e);
                }
                if (chuaxuly == true)
                {
                    btnChua_Click(sender, e);
                }
                if (daxuly == true)
                {
                    btnDa_Click(null, null);
                }
                if (dahuy == true)
                {
                    btnHuy_Click(null, null);
                }
            }
        }
        private Form f;

        private void Bills_Load(object sender, EventArgs e)
        {
            CheckClass.location = this.Parent.Parent.Location;
            CheckClass.size = this.Parent.Parent.Size;
            textBox1.Select();
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            btnTatCa_Click(null, null);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            loadOverlay.Visible = true;
        }
    }
}
