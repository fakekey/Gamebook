using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class Products : Form
    {
        private Panel loadOverlay;
        private PictureBox icoOverlay;
        // danhsach
        private List<Product> dsAll;
        private List<Product> dsAAA;
        private List<Product> dsIndie;
        public Products()
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
            dsAll = Controller.getSpAll();
            dsAAA = Controller.getSpAAA();
            dsIndie = Controller.getSpIndie();
            if (dsIndie != null && dsAAA != null)
            {
                label3.Text = $"({dsAAA.Count.ToString()})";
                label5.Text = $"({dsIndie.Count.ToString()})";
                dsAll.AddRange(dsAAA);
                dsAll.AddRange(dsIndie);
            }
            else
            {
                btnAAA.Enabled = false;
                btnIndie.Enabled = false;

            }
            if (dsAll != null)
            {
                label2.Text = "(" + dsAll.Count.ToString() + ")";
            }
            else
            {
                btnTatCa.Enabled = false;
            }
        }
        private void addToPanel(List<Product> ds)
        {
            for (int i = 0; i <= ds.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    pnDisplay.Controls.Add(new ListProduct()
                    {
                        bgColor = ListProduct.FIRST_COLOR,
                        lIcon = Image.FromFile(ds[i].Img),
                        lTieuDe = ds[i].Title,
                        lNsx = ds[i].Cate,
                        lPhienBan = ds[i].Version,
                        lNgay = ds[i].Daterelease,
                        lGia = ds[i].Price.ToString()
                    });
                }
                else
                {
                    pnDisplay.Controls.Add(new ListProduct()
                    {
                        bgColor = ListProduct.SECOND_COLOR,
                        lIcon = Image.FromFile(ds[i].Img),
                        lTieuDe = ds[i].Title,
                        lNsx = ds[i].Cate,
                        lPhienBan = ds[i].Version,
                        lNgay = ds[i].Daterelease,
                        lGia = ds[i].Price.ToString()
                    });
                }
            }
        }

        bool tatca = false;
        bool aaa = false;
        bool indie = false;
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
        private void btnAAA_MouseEnter(object sender, EventArgs e)
        {
            if (aaa == false)
            {
                btnAAA.ForeColor = Color.White;
                pnAAA.rColor = Color.FromArgb(82, 79, 84, 92);
                pnAAA.Refresh();
            }
        }

        private void btnAAA_MouseLeave(object sender, EventArgs e)
        {
            if (aaa == false)
            {
                btnAAA.ForeColor = Color.FromArgb(220, 221, 222);
                pnAAA.rColor = Color.Transparent;
                pnAAA.Refresh();
            }
        }

        private void btnIndie_MouseEnter(object sender, EventArgs e)
        {
            if (indie == false)
            {
                btnIndie.ForeColor = Color.White;
                pnIndie.rColor = Color.FromArgb(82, 79, 84, 92);
                pnIndie.Refresh();
            }
        }

        private void btnIndie_MouseLeave(object sender, EventArgs e)
        {
            if (indie == false)
            {
                btnIndie.ForeColor = Color.FromArgb(220, 221, 222);
                pnIndie.rColor = Color.Transparent;
                pnIndie.Refresh();
            }
        }
        private int nCount;
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            reload();
            aaa = indie = false;
            tatca = true;
            btnTatCa.ForeColor = Color.White;
            pnTatCa.rColor = Color.FromArgb(82, 79, 84, 92);
            clear();
            nCount = dsAll.Count;
            ReSize();
            pnDisplay.Controls.Clear();
            if (nCount != 0)
            {
                addToPanel(dsAll);
            }
            else
            {
                NoData();
            }
        }

        private void btnAAA_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            reload();
            tatca = indie = false;
            aaa = true;
            clear();
            nCount = dsAAA.Count;
            ReSize();
            pnDisplay.Controls.Clear();
            if (nCount != 0)
            {
                addToPanel(dsAAA);
            }
            else
            {
                NoData();
            }
        }

        private void btnIndie_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            reload();
            aaa = tatca = false;
            indie = true;
            clear();
            nCount = dsIndie.Count;
            ReSize();
            pnDisplay.Controls.Clear();
            if (nCount != 0)
            {
                addToPanel(dsIndie);
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
            if (aaa == false)
            {
                btnAAA.ForeColor = Color.FromArgb(220, 221, 222);
                pnAAA.rColor = Color.Transparent;
                pnAAA.Refresh();
            }
            if (indie == false)
            {
                btnIndie.ForeColor = Color.FromArgb(220, 221, 222);
                pnIndie.rColor = Color.Transparent;
                pnIndie.Refresh();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListProduct item in pnDisplay.Controls)
            {
                item.isChecked = checkBox1.Checked ? true : false;
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            btnTatCa_Click(null, null);
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

        private void noFocusButton3_Click(object sender, EventArgs e)
        {
            string txtFind = textBox1.Text;
            textBox1.Text = "";
            List<Product> dstk = new List<Product>(0);
            if (tatca == true)
            {
                foreach (Product item in dsAll)
                {
                    if (item.Price.ToString().Contains(txtFind) || item.Title.Contains(txtFind) || item.Version.Contains(txtFind) || item.Cate.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (aaa == true)
            {
                foreach (Product item in dsAAA)
                {
                    if (item.Price.ToString().Contains(txtFind) || item.Title.Contains(txtFind) || item.Version.Contains(txtFind) || item.Cate.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (indie == true)
            {
                foreach (Product item in dsIndie)
                {
                    if (item.Price.ToString().Contains(txtFind) || item.Title.Contains(txtFind) || item.Version.Contains(txtFind) || item.Cate.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            clear();
            nCount = dstk.Count;
            ReSize();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer4.Enabled = true;
            timer1_Tick(null, null);
            pnDisplay.Visible = false;
            pnDisplay.Controls.Clear();
            if (nCount != 0)
            {
                addToPanel(dstk);
            }
            else
            {
                NoData();
            }
        }
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            loadOverlay.Visible = true;
        }
        private void reload()
        {
            dsAAA = dsIndie = null;
            dsAll.Clear();
            dsAAA = Controller.getSpAAA();
            dsIndie = Controller.getSpIndie();
            if (dsAAA != null && dsIndie != null)
            {
                label3.Text = "(" + dsAAA.Count.ToString() + ")";
                label5.Text = "(" + dsIndie.Count.ToString() + ")";
                dsAll.AddRange(dsAAA);
                dsAll.AddRange(dsIndie);
            }
            else
            {
                btnAAA.Enabled = false;
                btnIndie.Enabled = false;

            }
            if (dsAll != null)
            {
                label2.Text = "(" + dsAll.Count.ToString() + ")";
            }
            else
            {
                btnTatCa.Enabled = false;
            }
            pnDisplay.Controls.Clear();
            if (tatca == true)
            {
                nCount = dsAll.Count;
                ReSize();
                addToPanel(dsAll);
            }
            if (aaa == true)
            {
                nCount = dsAAA.Count;
                ReSize();
                addToPanel(dsAAA);
            }
            if (indie == true)
            {
                nCount = dsIndie.Count;
                ReSize();
                addToPanel(dsIndie);
            }
        }
        public int leftPaddingNSX
        {
            set
            {
                label7.Padding = new Padding(value, 0, 0, 0);
            }
        }
        public int leftPaddingPB
        {
            set
            {
                label8.Padding = new Padding(value, 0, 0, 0);
            }
        }
        public int leftPaddingNgay
        {
            set
            {
                label9.Padding = new Padding(value, 0, 0, 0);
            }
        }
        public int leftPaddingGia
        {
            set
            {
                label10.Padding = new Padding(value, 0, 0, 0);
            }
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
            if (nCount < 7)
            {
                leftPaddingNSX = 31;
                leftPaddingPB = 30;
                leftPaddingNgay = 30;
                leftPaddingGia = 29;
            }
            if (nCount >= 7 && nCount < 11)
            {
                if (this.Width == 1231)
                {
                    leftPaddingNSX = 25;
                    leftPaddingPB = 23;
                    leftPaddingNgay = 19;
                    leftPaddingGia = 16;
                }
                else
                {
                    leftPaddingNSX = 31;
                    leftPaddingPB = 30;
                    leftPaddingNgay = 30;
                    leftPaddingGia = 29;
                }
            }
            else if (nCount >= 11)
            {
                if (this.Width == 1231)
                {
                    leftPaddingNSX = 25;
                    leftPaddingPB = 23;
                    leftPaddingNgay = 19;
                    leftPaddingGia = 16;
                }
                else
                {
                    leftPaddingNSX = 26;
                    leftPaddingPB = 21;
                    leftPaddingNgay = 17;
                    leftPaddingGia = 12;
                }
            }
        }
    }
}
