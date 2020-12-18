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
    public partial class Products : Form
    {
        // danhsach
        private List<Product> dsAll;
        private List<Product> dsAAA;
        private List<Product> dsIndie;
        public Products()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            textBox1.AutoSize = false;
            textBox1.Size = new Size(230, 22);
            dsAll = Controller.getSpAll();
            dsAAA = Controller.getSpAAA();
            dsIndie = Controller.getSpIndie();
            if(dsAll != null)
            {
                label2.Text = "(" + dsAll.Count + ")";
            }
            else
            {
                btnAAA.Enabled = false;
                btnIndie.Enabled = false;
            }
            if (dsAAA != null)
            {
                label3.Text = "(" + dsAAA.Count + ")";
            }
            if (dsIndie != null)
            {
                label5.Text = "(" + dsIndie.Count + ")";
            }
        }
        /*public struct products
        {
            public Image avata;
            public string tieude;
            public string nsx;
            public string pb;
            public string ngay;
            public string gia;
            public products(Image a, string b, string c, string d, string e, string f)
            {
                avata = a;
                tieude = b;
                nsx = c;
                pb = d;
                ngay = e;
                gia = f;
            }
        }
        products[] dsTest = new products[]{
                new products(Properties.Resources.forgotPass,"Grand Theft Auto V","AAA","1.51","25/06/2020","30$"),       
        };*/

        private void addToPanel(List<Product> ds)
        {
            for (int i = 0; i <= ds.Count-1; i++)
            {
                if (i % 2 == 0)
                {
                    pnDisplay.Controls.Add(new ListProduct() { 
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
            aaa = indie = false;
            tatca = true;
            btnTatCa.ForeColor = Color.White;
            pnTatCa.rColor = Color.FromArgb(82, 79, 84, 92);
            clear();
            pnDisplay.Controls.Clear();
            if(dsAll != null)
            {
                nCount = dsAll.Count;
            }
            else
            {
                nCount = 0;
            }    
            if(nCount != 0)
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
            tatca = indie = false;
            aaa = true;
            btnAAA.ForeColor = Color.White;
            pnAAA.rColor = Color.FromArgb(82, 79, 84, 92);
            clear();
            pnDisplay.Controls.Clear();
            if (dsAll != null)
            {
                nCount = dsAAA.Count;
            }
            else
            {
                nCount = 0;
            }
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
            aaa = tatca = false;
            indie = true;
            btnIndie.ForeColor = Color.White;
            pnIndie.rColor = Color.FromArgb(82, 79, 84, 92);
            clear();
            pnDisplay.Controls.Clear();
            if (dsAll != null)
            {
                nCount = dsIndie.Count;
            }
            else
            {
                nCount = 0;
            }
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
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
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
            pnDisplay.Controls.Clear();
            if(nCount != 0)
            {
                addToPanel(dstk);
            }
            else
            {
                NoData();
            }
        }
    }
}
