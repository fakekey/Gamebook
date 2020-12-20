using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            tbgia.Text = "0";
            tbngay.Text = DateTime.Now.Day.ToString();
            tbthang.Text = DateTime.Now.Month.ToString();
            tbnam.Text = DateTime.Now.Year.ToString();
        }
        private void VeBorder(Control control, PaintEventArgs e, int r, int g, int b)
        {
            ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.FromArgb(r, g, b), ButtonBorderStyle.Solid);
        }
        private void tieude_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(tieude, e, 34, 36, 40);
        }

        private void phienban_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(phienban, e, 34, 36, 40);
        }

        private void gia_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(gia, e, 34, 36, 40);
        }

        private void ngay_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(ngay, e, 34, 36, 40);
        }
        bool tbTieuDeDontHandle = false;
        bool tbPhienBanDontHandle = false;
        bool tbGiaDontHandle = false;
        bool tbNgayDontHandle = false;

        private void tbtieude_MouseEnter(object sender, EventArgs e)
        {
            if (tbTieuDeDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(tieude.CreateGraphics(), tieude.ClientRectangle);
                VeBorder(tieude, eventArgs, 4, 4, 5);
            }
        }

        private void tbtieude_MouseLeave(object sender, EventArgs e)
        {
            if (tbTieuDeDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(tieude.CreateGraphics(), tieude.ClientRectangle);
                VeBorder(tieude, eventArgs, 34, 36, 40);
            }
        }

        private void tbtieude_Enter(object sender, EventArgs e)
        {
            tbTieuDeDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(tieude.CreateGraphics(), tieude.ClientRectangle);
            VeBorder(tieude, eventArgs, 114, 137, 218);
        }

        private void tbtieude_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(tieude.CreateGraphics(), tieude.ClientRectangle);
            VeBorder(tieude, eventArgs, 34, 36, 40);
            tbTieuDeDontHandle = false;
        }

        private void tbphienban_MouseEnter(object sender, EventArgs e)
        {
            if (tbPhienBanDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(phienban.CreateGraphics(), phienban.ClientRectangle);
                VeBorder(phienban, eventArgs, 4, 4, 5);
            }
        }

        private void tbphienban_MouseLeave(object sender, EventArgs e)
        {
            if (tbPhienBanDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(phienban.CreateGraphics(), phienban.ClientRectangle);
                VeBorder(phienban, eventArgs, 34, 36, 40);
            }
        }

        private void tbphienban_Enter(object sender, EventArgs e)
        {
            tbPhienBanDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(phienban.CreateGraphics(), phienban.ClientRectangle);
            VeBorder(phienban, eventArgs, 114, 137, 218);
        }

        private void tbphienban_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(phienban.CreateGraphics(), phienban.ClientRectangle);
            VeBorder(phienban, eventArgs, 34, 36, 40);
            tbPhienBanDontHandle = false;
        }

        private void tbgia_MouseEnter(object sender, EventArgs e)
        {
            if (tbGiaDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(gia.CreateGraphics(), gia.ClientRectangle);
                VeBorder(gia, eventArgs, 4, 4, 5);
            }
        }

        private void tbgia_MouseLeave(object sender, EventArgs e)
        {
            if (tbGiaDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(gia.CreateGraphics(), gia.ClientRectangle);
                VeBorder(gia, eventArgs, 34, 36, 40);
            }
        }

        private void tbgia_Enter(object sender, EventArgs e)
        {
            tbGiaDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(gia.CreateGraphics(), gia.ClientRectangle);
            VeBorder(gia, eventArgs, 114, 137, 218);
        }

        private void tbgia_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(gia.CreateGraphics(), gia.ClientRectangle);
            VeBorder(gia, eventArgs, 34, 36, 40);
            tbGiaDontHandle = false;
        }

        private void tbngay_MouseEnter(object sender, EventArgs e)
        {
            if (tbNgayDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(ngay.CreateGraphics(), ngay.ClientRectangle);
                VeBorder(ngay, eventArgs, 4, 4, 5);
            }
        }

        private void tbngay_MouseLeave(object sender, EventArgs e)
        {
            if (tbNgayDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(ngay.CreateGraphics(), ngay.ClientRectangle);
                VeBorder(ngay, eventArgs, 34, 36, 40);
            }
        }

        private void tbngay_Enter(object sender, EventArgs e)
        {
            tbNgayDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(ngay.CreateGraphics(), ngay.ClientRectangle);
            VeBorder(ngay, eventArgs, 114, 137, 218);
        }

        private void tbngay_Leave(object sender, EventArgs e)
        {
            PaintEventArgs eventArgs = new PaintEventArgs(ngay.CreateGraphics(), ngay.ClientRectangle);
            VeBorder(ngay, eventArgs, 34, 36, 40);
            tbNgayDontHandle = false;
        }

        private void tbthang_MouseEnter(object sender, EventArgs e)
        {
            tbngay_MouseEnter(null, null);
        }

        private void tbthang_MouseLeave(object sender, EventArgs e)
        {
            tbngay_MouseLeave(null, null);
        }

        private void tbthang_Enter(object sender, EventArgs e)
        {
            tbngay_Enter(null, null);
        }

        private void tbthang_Leave(object sender, EventArgs e)
        {
            tbngay_Leave(null, null);
        }

        private void tbnam_MouseEnter(object sender, EventArgs e)
        {
            tbngay_MouseEnter(null, null);
        }

        private void tbnam_MouseLeave(object sender, EventArgs e)
        {
            tbngay_MouseLeave(null, null);
        }

        private void tbnam_Enter(object sender, EventArgs e)
        {
            tbngay_Enter(null, null);
        }

        private void tbnam_Leave(object sender, EventArgs e)
        {
            tbngay_Leave(null, null);
        }
        int ngayresult;
        private void tbngay_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbngay.Text, out ngayresult) == false)
            {
                tbngay.Text = "1";
            }
            else
            {
                if (namresult % 4 == 0)
                {
                    if (thangresult == 1 || thangresult == 3 || thangresult == 5 || thangresult == 7 || thangresult == 8 || thangresult == 10 || thangresult == 12)
                    {
                        if (ngayresult > 31)
                        {
                            tbngay.Text = "31";
                        }
                        else if (ngayresult <= 0)
                        {
                            tbngay.Text = "1";
                        }
                    }
                    else if (thangresult == 2)
                    {
                        if (ngayresult > 29)
                        {
                            tbngay.Text = "29";
                        }
                        else if (ngayresult <= 0)
                        {
                            tbngay.Text = "1";
                        }
                    }
                    else
                    {
                        if (ngayresult > 30)
                        {
                            tbngay.Text = "30";
                        }
                        else if (ngayresult <= 0)
                        {
                            tbngay.Text = "1";
                        }
                    }
                }
                else
                {
                    if (thangresult == 1 || thangresult == 3 || thangresult == 5 || thangresult == 7 || thangresult == 8 || thangresult == 10 || thangresult == 12)
                    {
                        if (ngayresult > 31)
                        {
                            tbngay.Text = "31";
                        }
                        else if (ngayresult <= 0)
                        {
                            tbngay.Text = "1";
                        }
                    }
                    else if (thangresult == 2)
                    {
                        if (ngayresult > 28)
                        {
                            tbngay.Text = "28";
                        }
                        else if (ngayresult <= 0)
                        {
                            tbngay.Text = "1";
                        }
                    }
                    else
                    {
                        if (ngayresult > 30)
                        {
                            tbngay.Text = "30";
                        }
                        else if (ngayresult <= 0)
                        {
                            tbngay.Text = "1";
                        }
                    }
                }
            }
        }
        int thangresult;
        private void tbthang_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbthang.Text, out thangresult) == false)
            {
                tbthang.Text = "1";
            }
            else
            {
                if (thangresult > 12)
                {
                    tbthang.Text = "12";
                    thangresult = 12;
                }
                else if (thangresult <= 0)
                {
                    tbthang.Text = "1";
                    thangresult = 1;
                }
            }
        }
        int namresult;
        private void tbnam_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbnam.Text, out namresult) == false)
            {
                tbnam.Text = "2020";
                namresult = 2020;
            }
            else
            {
                if (namresult > 9999)
                {
                    tbnam.Text = "9999";
                    namresult = 9999;
                }
            }
            if (namresult % 4 != 0 && tbthang.Text == "2" && tbngay.Text == "29")
            {
                tbngay.Text = "28";
            }
        }
        string fileName; //dung cai bien nay ma them vao sql, no la duong dan den file da chon
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    panel9.BackgroundImage = Image.FromFile(fileName);
                }
            }
        }
        int j = 0;
        string[] dotArr = new string[] { "•", "• •", "• • •" };
        bool timerIsAlive = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            j = j % 3;
            btnLogin.Text = dotArr[j];
            j++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            j = 0;
            btnLogin.Text = "Thêm ngay";
            tbtieude.Enabled = true;
            tbphienban.Enabled = true;
            tbgia.Enabled = true;
            tbngay.Enabled = true;
            tbthang.Enabled = true;
            tbnam.Enabled = true;
            timerIsAlive = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (tbtieude.Text != string.Empty && tbphienban.Text != string.Empty)
            {
                string ngayt = $"{tbnam.Text}/{tbthang.Text}/{tbngay.Text}";
                string cate = comboBox1.SelectedItem.ToString();
                float giaca = float.Parse(tbgia.Text);
                string path = "";
                if (fileName != null)
                {
                    path = fileName.Replace(@"\", @"\\");
                }
                Product sp = new Product(0, tbtieude.Text, cate, tbphienban.Text, giaca, ngayt, path);
                int rs = Controller.ThemSP(sp);
                if (rs == 1)
                {
                    lbtieude.ForeColor = Color.FromArgb(77, 222, 19);
                    lbtieude.Text = "- Thêm thành công";
                    tieudelb.ForeColor = Color.FromArgb(77, 222, 19);
                    PaintEventArgs eventArgs = new PaintEventArgs(tieude.CreateGraphics(), tieude.ClientRectangle);
                    VeBorder(tieude, eventArgs, 77, 222, 19);
                    tbTieuDeDontHandle = true;
                    pblb.ForeColor = Color.FromArgb(77, 222, 19);
                    PaintEventArgs eventArgs1 = new PaintEventArgs(phienban.CreateGraphics(), phienban.ClientRectangle);
                    VeBorder(phienban, eventArgs1, 77, 222, 19);
                    tbPhienBanDontHandle = true;
                    gialb.ForeColor = Color.FromArgb(77, 222, 19);
                    PaintEventArgs eventArgs2 = new PaintEventArgs(gia.CreateGraphics(), gia.ClientRectangle);
                    VeBorder(gia, eventArgs2, 77, 222, 19);
                    tbGiaDontHandle = true;
                    ngaylb.ForeColor = Color.FromArgb(77, 222, 19);
                    PaintEventArgs eventArgs3 = new PaintEventArgs(ngay.CreateGraphics(), ngay.ClientRectangle);
                    VeBorder(ngay, eventArgs3, 77, 222, 19);
                    tbNgayDontHandle = true;
                    anhlb.ForeColor = Color.FromArgb(77, 222, 19);
                    nsxlb.ForeColor = Color.FromArgb(77, 222, 19);
                }
                else
                {
                    lbtieude.Text = "- Thêm thất bại";
                    tieudelb.ForeColor = Color.FromArgb(240, 71, 71);
                    PaintEventArgs eventArgs = new PaintEventArgs(tieude.CreateGraphics(), tieude.ClientRectangle);
                    VeBorder(tieude, eventArgs, 240, 71, 71);
                    tbTieuDeDontHandle = true;
                }

            }
            else
            {
                if (tbtieude.Text == string.Empty)
                {
                    lbtieude.Text = "- Mục này không thể bỏ trống";
                    tieudelb.ForeColor = Color.FromArgb(240, 71, 71);
                    PaintEventArgs eventArgs = new PaintEventArgs(tieude.CreateGraphics(), tieude.ClientRectangle);
                    VeBorder(tieude, eventArgs, 240, 71, 71);
                    tbTieuDeDontHandle = true;
                }
                if (tbphienban.Text == string.Empty)
                {
                    lbphienban.Text = "- Mục này không thể bỏ trống";
                    pblb.ForeColor = Color.FromArgb(240, 71, 71);
                    PaintEventArgs eventArgs = new PaintEventArgs(phienban.CreateGraphics(), phienban.ClientRectangle);
                    VeBorder(phienban, eventArgs, 240, 71, 71);
                    tbPhienBanDontHandle = true;
                }
            }
            timer3.Stop();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            tbtieude.Select();
            comboBox1.SelectedIndex = 0;
        }
        private void tbgia_TextChanged(object sender, EventArgs e)
        {
            float cost;
            if (float.TryParse(tbgia.Text, out cost) == false)
            {
                tbgia.Text = "0";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (timerIsAlive == false)
            {
                lbtieude.Text = "";
                lbphienban.Text = "";
                lbgia.Text = "";
                lbngay.Text = "";
                lbtieude.ForeColor = Color.FromArgb(240, 71, 71);
                tieudelb.ForeColor = Color.FromArgb(138, 142, 147);
                pblb.ForeColor = Color.FromArgb(138, 142, 147);
                gialb.ForeColor = Color.FromArgb(138, 142, 147);
                ngaylb.ForeColor = Color.FromArgb(138, 142, 147);
                anhlb.ForeColor = Color.FromArgb(138, 142, 147);
                nsxlb.ForeColor = Color.FromArgb(138, 142, 147);
                timerIsAlive = true;
                timer1.Enabled = true;
                timer1_Tick(null, null);
                timer2.Enabled = true;
                timer3.Enabled = true;
                tbtieude.Enabled = false;
                tbphienban.Enabled = false;
                tbgia.Enabled = false;
                tbngay.Enabled = false;
                tbthang.Enabled = false;
                tbnam.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
