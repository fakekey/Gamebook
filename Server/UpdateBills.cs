using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Server
{
    public partial class UpdateBills : Form
    {
        private List<Khach> dsAll = new List<Khach>();
        private List<Game> dsGame = new List<Game>();
        public UpdateBills(string mahd, string tenkhach, string ngaymua, string tongtien, string tinhtrang)
        {
            InitializeComponent();
            MaHD = mahd;
            BillTemp temp = Controller.getChitiettemp(mahd);
            ID_Khach = temp._makh;
            ID_SanPham = temp._idsanpham;
            tbtenkh.Text = tenkhach;
            tbtengame.Text = temp._tengame;
            tbgia.Text = tongtien.Remove(tongtien.IndexOf('$'));
            DateTime dt = DateTime.ParseExact(ngaymua, "dd/MM/yyyy", null);
            tbngay.Text = dt.Day.ToString();
            tbthang.Text = dt.Month.ToString();
            tbnam.Text = dt.Year.ToString();
            dsAll = Controller.getKhach2();
            dsGame = Controller.getGames();
            if (tinhtrang == "3")
            {
                tbtenkh.Enabled = false;
                tbtengame.Enabled = false;
                tbgia.Enabled = false;
                tbngay.Enabled = false;
                tbthang.Enabled = false;
                tbnam.Enabled = false;
                btnLogin.Enabled = false;
            }
        }
        private string MaHD;
        private void VeBorder(Control control, PaintEventArgs e, int r, int g, int b)
        {
            ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.FromArgb(r, g, b), ButtonBorderStyle.Solid);
        }
        private void tieude_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(tenkh, e, 34, 36, 40);
        }

        private void phienban_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(tengame, e, 34, 36, 40);
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
                PaintEventArgs eventArgs = new PaintEventArgs(tenkh.CreateGraphics(), tenkh.ClientRectangle);
                VeBorder(tenkh, eventArgs, 4, 4, 5);
            }
        }

        private void tbtieude_MouseLeave(object sender, EventArgs e)
        {
            if (tbTieuDeDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(tenkh.CreateGraphics(), tenkh.ClientRectangle);
                VeBorder(tenkh, eventArgs, 34, 36, 40);
            }
        }
        private bool tenkhIsFocus = false;
        private bool tengameIsFocus = false;
        private void tbtieude_Enter(object sender, EventArgs e)
        {
            tbTieuDeDontHandle = true;
            tenkhIsFocus = true;
            PaintEventArgs eventArgs = new PaintEventArgs(tenkh.CreateGraphics(), tenkh.ClientRectangle);
            VeBorder(tenkh, eventArgs, 114, 137, 218);
            if (tbtenkh.Text.IndexOf('@') == 0)
            {
                pnDisplay.Location = new Point(33, 179);
                pnDisplay.Visible = true;
            }
            else
            {
                pnDisplay.Location = new Point(33, 179);
                pnDisplay.Visible = false;
            }
        }

        private void tbtieude_Leave(object sender, EventArgs e)
        {
            tenkhIsFocus = false;
            PaintEventArgs eventArgs = new PaintEventArgs(tenkh.CreateGraphics(), tenkh.ClientRectangle);
            VeBorder(tenkh, eventArgs, 34, 36, 40);
            tbTieuDeDontHandle = false;
            pnDisplay.Visible = false;
        }

        private void tbphienban_MouseEnter(object sender, EventArgs e)
        {
            if (tbPhienBanDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(tengame.CreateGraphics(), tengame.ClientRectangle);
                VeBorder(tengame, eventArgs, 4, 4, 5);
            }
        }

        private void tbphienban_MouseLeave(object sender, EventArgs e)
        {
            if (tbPhienBanDontHandle == false)
            {
                PaintEventArgs eventArgs = new PaintEventArgs(tengame.CreateGraphics(), tengame.ClientRectangle);
                VeBorder(tengame, eventArgs, 34, 36, 40);
            }
        }

        private void tbphienban_Enter(object sender, EventArgs e)
        {
            tengameIsFocus = true;
            tbPhienBanDontHandle = true;
            PaintEventArgs eventArgs = new PaintEventArgs(tengame.CreateGraphics(), tengame.ClientRectangle);
            VeBorder(tengame, eventArgs, 114, 137, 218);
            if (tbtengame.Text.IndexOf('@') == 0)
            {
                pnDisplay.Location = new Point(33, 100);
                pnDisplay.Visible = true;
            }
            else
            {
                pnDisplay.Location = new Point(33, 100);
                pnDisplay.Visible = false;
            }
        }

        private void tbphienban_Leave(object sender, EventArgs e)
        {
            tengameIsFocus = false;
            PaintEventArgs eventArgs = new PaintEventArgs(tengame.CreateGraphics(), tengame.ClientRectangle);
            VeBorder(tengame, eventArgs, 34, 36, 40);
            tbPhienBanDontHandle = false;
            pnDisplay.Visible = false;
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
            tbtenkh.Enabled = true;
            tbtengame.Enabled = true;
            tbgia.Enabled = false;
            tbngay.Enabled = true;
            tbthang.Enabled = true;
            tbnam.Enabled = true;
            timerIsAlive = false;
        }

        private void ShowKQ(int rs)
        {
            if (rs == 1)
            {
                lbtenkh.Text = "- Thêm thành công";
                lbtenkh.ForeColor = Color.FromArgb(77, 222, 19);
                tenkhlb.ForeColor = Color.FromArgb(77, 222, 19);
                PaintEventArgs eventArgs = new PaintEventArgs(tenkh.CreateGraphics(), tenkh.ClientRectangle);
                VeBorder(tenkh, eventArgs, 77, 222, 19);
                tbTieuDeDontHandle = true;
                lbtengame.ForeColor = Color.FromArgb(77, 222, 19);
                tengamelb.ForeColor = Color.FromArgb(77, 222, 19);
                PaintEventArgs eventArgs1 = new PaintEventArgs(tengame.CreateGraphics(), tengame.ClientRectangle);
                VeBorder(tengame, eventArgs1, 77, 222, 19);
                tbPhienBanDontHandle = true;
                gialb.ForeColor = Color.FromArgb(77, 222, 19);
                ngaylb.ForeColor = Color.FromArgb(77, 222, 19);
                PaintEventArgs eventArgs3 = new PaintEventArgs(ngay.CreateGraphics(), ngay.ClientRectangle);
                VeBorder(ngay, eventArgs3, 77, 222, 19);
                tbNgayDontHandle = true;
                tbtengame.Text = "";
                tbtenkh.Text = "";
                ID_Khach = null;
                ID_SanPham = null;
            }
            else
            {
                lbtenkh.Text = "- Thêm thất bại";
                lbtenkh.ForeColor = Color.FromArgb(240, 71, 71);
                tenkhlb.ForeColor = Color.FromArgb(240, 71, 71);
                PaintEventArgs eventArgs = new PaintEventArgs(tenkh.CreateGraphics(), tenkh.ClientRectangle);
                VeBorder(tenkh, eventArgs, 240, 71, 71);
                tbTieuDeDontHandle = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string id_sp = null;
            string makh = null;
            if (tbtenkh.Text != string.Empty && tbtengame.Text != string.Empty)
            {
                if (ID_SanPham != null && ID_Khach != null)
                {
                    id_sp = ID_SanPham;
                    makh = ID_Khach;
                    string id_hd = MaHD;
                    string gia = tbgia.Text;
                    string date = $"{tbnam.Text}/{tbthang.Text}/{tbngay.Text}";
                    int rs = Controller.CapNhatBill(id_hd,makh ,id_sp, gia, date);
                    ShowKQ(rs);
                }
                else
                {
                    foreach (var item in dsGame)
                    {
                        if (item.TenGame.ToLower().Equals(tbtengame.Text.ToLower()))
                        {
                            id_sp = item.IDGame;
                        }
                    }
                    foreach (var item in dsAll)
                    {
                        if (item.HoTen.ToLower().Equals(tbtenkh.Text.ToLower()))
                        {
                            makh = item.IDKhach;
                        }
                    }

                    if (id_sp == null || makh == null)
                    {
                        if (makh == null)
                        {
                            lbtenkh.Text = "- Không tồn tại khách hàng";
                            lbtenkh.ForeColor = Color.FromArgb(240, 71, 71);
                            tenkhlb.ForeColor = Color.FromArgb(240, 71, 71);
                            PaintEventArgs eventArgs = new PaintEventArgs(tenkh.CreateGraphics(), tenkh.ClientRectangle);
                            VeBorder(tenkh, eventArgs, 240, 71, 71);
                            tbTieuDeDontHandle = true;
                        }
                        if (id_sp == null)
                        {
                            lbtengame.Text = "- Không tồn tại sản phẩm";
                            tengamelb.ForeColor = Color.FromArgb(240, 71, 71);
                            PaintEventArgs eventArgs = new PaintEventArgs(tengame.CreateGraphics(), tengame.ClientRectangle);
                            VeBorder(tengame, eventArgs, 240, 71, 71);
                            tbPhienBanDontHandle = true;
                        }
                    }
                    else
                    {
                        string id_hd = MaHD;
                        string gia = tbgia.Text;
                        string date = $"{tbnam.Text}/{tbthang.Text}/{tbngay.Text}";
                        int rs = Controller.ThemBill(id_sp, makh, gia, date);
                        ShowKQ(rs);
                    }
                }
            }
            else
            {
                if (tbtenkh.Text == string.Empty)
                {
                    lbtenkh.Text = "- Mục này không thể bỏ trống";
                    lbtenkh.ForeColor = Color.FromArgb(240, 71, 71);
                    tenkhlb.ForeColor = Color.FromArgb(240, 71, 71);
                    PaintEventArgs eventArgs = new PaintEventArgs(tenkh.CreateGraphics(), tenkh.ClientRectangle);
                    VeBorder(tenkh, eventArgs, 240, 71, 71);
                    tbTieuDeDontHandle = true;
                }
                if (tbtengame.Text == string.Empty)
                {
                    lbtengame.Text = "- Mục này không thể bỏ trống";
                    tengamelb.ForeColor = Color.FromArgb(240, 71, 71);
                    PaintEventArgs eventArgs = new PaintEventArgs(tengame.CreateGraphics(), tengame.ClientRectangle);
                    VeBorder(tengame, eventArgs, 240, 71, 71);
                    tbPhienBanDontHandle = true;
                }
            }

            timer3.Stop();
        }

        private void UpdateBills_Load(object sender, EventArgs e)
        {
            tbtenkh.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (timerIsAlive == false)
            {
                lbtenkh.Text = "";
                lbtengame.Text = "";
                lbgia.Text = "";
                lbngay.Text = "";
                lbtenkh.ForeColor = Color.FromArgb(240, 71, 71);
                lbtengame.ForeColor = Color.FromArgb(240, 71, 71);
                tenkhlb.ForeColor = Color.FromArgb(138, 142, 147);
                tengamelb.ForeColor = Color.FromArgb(138, 142, 147);
                gialb.ForeColor = Color.FromArgb(138, 142, 147);
                ngaylb.ForeColor = Color.FromArgb(138, 142, 147);
                timerIsAlive = true;
                timer1.Enabled = true;
                timer1_Tick(null, null);
                timer2.Enabled = true;
                timer3.Enabled = true;
                tbtenkh.Enabled = false;
                tbtengame.Enabled = false;
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

        private void pnDisplay_Paint(object sender, PaintEventArgs e)
        {
            VeBorder(pnDisplay, e, 34, 36, 40);
        }

        private void tbtenkh_TextChanged(object sender, EventArgs e)
        {
            if (tbtenkh.Text.IndexOf('@') == 0)
            {
                CheckClass.count = 0;
                pnDisplay.Location = new Point(33, 179);
                pnDisplay.Visible = true;
                string txtFind = tbtenkh.Text.Replace("@", "");
                List<Khach> dstk = new List<Khach>(0);
                foreach (Khach item in dsAll)
                {
                    if (item.IDKhach.Contains(txtFind) || item.HoTen.Contains(txtFind) || item.Email.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
                pnDisplay.Controls.Clear();
                if (dstk.Count != 0)
                {
                    for (int i = dstk.Count - 1; i >= 0; i--)
                    {
                        pnDisplay.Controls.Add(new KhachMember()
                        {
                            ID_Khach = dstk[i].IDKhach,
                            TenKhach = dstk[i].HoTen,
                            EmailKhach = dstk[i].Email,
                        });
                    }
                }
                else
                {
                    pnDisplay.Controls.Add(new Label()
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Fill,
                        Font = new Font("Quicksand", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0),
                        ForeColor = Color.White,
                        Padding = new Padding(0, 0, 0, 20),
                        Text = "Không tìm thấy dữ liệu",
                        TextAlign = ContentAlignment.MiddleCenter,
                    });
                }
            }
            else
            {
                pnDisplay.Location = new Point(33, 179);
                pnDisplay.Visible = false;
            }
        }

        private void tbtengame_TextChanged(object sender, EventArgs e)
        {
            if (tbtengame.Text.IndexOf('@') == 0)
            {
                CheckClass.count = 0;
                pnDisplay.Location = new Point(33, 100);
                pnDisplay.Visible = true;
                string txtFind = tbtengame.Text.Replace("@", "");
                List<Game> dstk = new List<Game>(0);
                foreach (Game item in dsGame)
                {
                    if (item.IDGame.Contains(txtFind) || item.TenGame.Contains(txtFind) || item.DonGia.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
                pnDisplay.Controls.Clear();
                if (dstk.Count != 0)
                {
                    for (int i = dstk.Count - 1; i >= 0; i--)
                    {
                        pnDisplay.Controls.Add(new GameMember()
                        {
                            ID_Game = dstk[i].IDGame,
                            TenGame = dstk[i].TenGame,
                            Gia = dstk[i].DonGia,
                        });
                    }
                }
                else
                {
                    pnDisplay.Controls.Add(new Label()
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Fill,
                        Font = new Font("Quicksand", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0),
                        ForeColor = Color.White,
                        Padding = new Padding(0, 0, 0, 20),
                        Text = "Không tìm thấy dữ liệu",
                        TextAlign = ContentAlignment.MiddleCenter,
                    });
                }
            }
            else
            {
                tbgia.Text = "0";
                pnDisplay.Location = new Point(33, 100);
                pnDisplay.Visible = false;
            }
        }

        private void panelRadius1_Click(object sender, EventArgs e)
        {
            panelRadius1.Select();
        }
        private string ID_Khach;
        private string ID_SanPham;
        private void pnDisplay_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (CheckClass.count == 1)
            {
                if (tenkhIsFocus == true)
                {
                    ID_Khach = CheckClass.IDKhachNowSelected;
                    tbtenkh.Text = CheckClass.TenKhachNowSelected;
                }
                if (tengameIsFocus == true)
                {
                    ID_SanPham = CheckClass.IDGameNowSelected;
                    tbtengame.Text = CheckClass.TenGameNowSelected;
                    tbgia.Text = CheckClass.DonGiaNowSelected;
                }
            }
        }
    }
}
