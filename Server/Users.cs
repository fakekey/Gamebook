using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class Users : Form
    {
        List<User> dsnv = new List<User>();
        List<User> dsuser = new List<User>();
        List<User> dsadmin = new List<User>();
        List<User> dsAll = new List<User>();
        public Users()
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
            dsnv = Controller.getNhanVien();
            dsuser = Controller.getKhach();
            dsadmin = Controller.getAdmin();
            if (dsnv != null && dsuser != null && dsadmin != null)
            {
                label3.Text = $"({dsadmin.Count.ToString()})";
                label5.Text = $"({dsnv.Count.ToString()})";
                label7.Text = $"({dsuser.Count.ToString()})";
                dsAll.AddRange(dsadmin);
                dsAll.AddRange(dsnv);
                dsAll.AddRange(dsuser);
            }
            else
            {
                btnAdmin.Enabled = false;
                btnKhach.Enabled = false;
                btnNhanVien.Enabled = false;

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
        private int nUsers;
        public int leftPaddingEmail
        {
            set
            {
                label6.Padding = new Padding(value, 0, 0, 0);
            }
        }
        public int leftPaddingVaiTro
        {
            set
            {
                label8.Padding = new Padding(value, 0, 0, 0);
            }
        }

        private void addToPanel(List<User> ds)
        {
            for (int i = ds.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    pnDisplay.Controls.Add(new ListMember()
                    {
                        lTen = ds[i].Hoten,
                        lEmail = ds[i].Email,
                        lVaiTro = ds[i].Quyen,
                        bgColor = ListMember.FIRST_COLOR,
                        isNotAdmin = (ds[i].Quyen != "Admin") ? true : false
                    });
                }
                else
                {
                    pnDisplay.Controls.Add(
                    new ListMember()
                    {
                        lTen = ds[i].Hoten,
                        lEmail = ds[i].Email,
                        lVaiTro = ds[i].Quyen,
                        bgColor = ListMember.SECOND_COLOR,
                        isNotAdmin = (ds[i].Quyen != "Admin") ? true : false
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

        private void btnAdmin_MouseEnter(object sender, EventArgs e)
        {
            if (admin == false)
            {
                btnAdmin.ForeColor = Color.White;
                pnAdmin.rColor = Color.FromArgb(82, 79, 84, 92);
                pnAdmin.Refresh();
            }
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            if (admin == false)
            {
                btnAdmin.ForeColor = Color.FromArgb(220, 221, 222);
                pnAdmin.rColor = Color.Transparent;
                pnAdmin.Refresh();
            }
        }

        private void btnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            if (nhanvien == false)
            {
                btnNhanVien.ForeColor = Color.White;
                pnNhanVien.rColor = Color.FromArgb(82, 79, 84, 92);
                pnNhanVien.Refresh();
            }
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            if (nhanvien == false)
            {
                btnNhanVien.ForeColor = Color.FromArgb(220, 221, 222);
                pnNhanVien.rColor = Color.Transparent;
                pnNhanVien.Refresh();
            }
        }

        private void btnKhach_MouseEnter(object sender, EventArgs e)
        {
            if (khach == false)
            {
                btnKhach.ForeColor = Color.White;
                pnKhach.rColor = Color.FromArgb(82, 79, 84, 92);
                pnKhach.Refresh();
            }
        }

        private void btnKhach_MouseLeave(object sender, EventArgs e)
        {
            if (khach == false)
            {
                btnKhach.ForeColor = Color.FromArgb(220, 221, 222);
                pnKhach.rColor = Color.Transparent;
                pnKhach.Refresh();
            }
        }
        bool tatca = false;
        bool admin = false;
        bool nhanvien = false;
        bool khach = false;
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            reload();
            admin = nhanvien = khach = false;
            tatca = true;
            btnTatCa.ForeColor = Color.White;
            pnTatCa.rColor = Color.FromArgb(82, 79, 84, 92);
            clear();
            nUsers = dsAll.Count;
            ReSize();
            timer1.Enabled = true;
            timer1_Tick(null, null);
            timer2.Enabled = true;
            pnDisplay.Controls.Clear();
            if (nUsers != 0)
            {
                addToPanel(dsAll);
            }
            else
            {
                NoData();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            reload();
            tatca = nhanvien = khach = false;
            admin = true;
            clear();
            nUsers = dsadmin.Count;
            ReSize();
            timer1.Enabled = true;
            timer1_Tick(null, null);
            timer2.Enabled = true;
            pnDisplay.Controls.Clear();
            if (nUsers != 0)
            {
                addToPanel(dsadmin);
            }
            else
            {
                NoData();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            reload();
            admin = tatca = khach = false;
            nhanvien = true;
            clear();
            nUsers = dsnv.Count;
            ReSize();
            timer1.Enabled = true;
            timer1_Tick(null, null);
            timer2.Enabled = true;
            pnDisplay.Controls.Clear();
            if (nUsers != 0)
            {
                addToPanel(dsnv);
            }
            else
            {
                NoData();
            }
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            CheckClass.count = 0;
            reload();
            admin = nhanvien = tatca = false;
            khach = true;
            clear();
            nUsers = dsuser.Count;
            ReSize();
            timer1.Enabled = true;
            timer1_Tick(null, null);
            timer2.Enabled = true;
            pnDisplay.Controls.Clear();
            if (nUsers != 0)
            {
                addToPanel(dsuser);
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
            if (admin == false)
            {
                btnAdmin.ForeColor = Color.FromArgb(220, 221, 222);
                pnAdmin.rColor = Color.Transparent;
                pnAdmin.Refresh();
            }
            if (nhanvien == false)
            {
                btnNhanVien.ForeColor = Color.FromArgb(220, 221, 222);
                pnNhanVien.rColor = Color.Transparent;
                pnNhanVien.Refresh();
            }
            if (khach == false)
            {
                btnKhach.ForeColor = Color.FromArgb(220, 221, 222);
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
            if (this.Width == 1111)
            {
                loadOverlay.Bounds = new Rectangle(0, 251, 1111, 447);
                loadOverlay.Padding = new Padding(505, 132, 505, 200);
            }
            else if (this.Width == 1231)
            {
                loadOverlay.Bounds = new Rectangle(0, 251, 1231, 447);
                loadOverlay.Padding = new Padding(565, 132, 565, 200);
            }
            else if (this.Width == 1783)
            {
                loadOverlay.Bounds = new Rectangle(0, 251, 1783, 759);
                loadOverlay.Padding = new Padding(760, 200, 760, 300);
            }
            else
            {
                loadOverlay.Bounds = new Rectangle(0, 251, 1663, 759);
                loadOverlay.Padding = new Padding(700, 200, 700, 300);
            }
            if (nUsers < 7)
            {
                leftPaddingEmail = 44;
                leftPaddingVaiTro = 34;
            }
            if (nUsers >= 7 && nUsers < 11)
            {
                if (this.Width == 1111)
                {
                    leftPaddingEmail = 38;
                    leftPaddingVaiTro = 22;
                }
                else
                {
                    leftPaddingEmail = 44;
                    leftPaddingVaiTro = 34;
                }
            }
            else if (nUsers >= 11)
            {
                leftPaddingEmail = 38;
                leftPaddingVaiTro = 22;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListMember item in pnDisplay.Controls)
            {
                item.isChecked = checkBox1.Checked ? true : false;
            }
        }

        private void noFocusButton3_Click(object sender, EventArgs e)
        {
            string txtFind = textBox1.Text;
            textBox1.Text = "";
            List<User> dstk = new List<User>(0);
            if (tatca == true)
            {
                foreach (User item in dsAll)
                {
                    if (item.Hoten.Contains(txtFind) || item.Email.Contains(txtFind) || item.Quyen.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (admin == true)
            {
                foreach (User item in dsadmin)
                {
                    if (item.Hoten.Contains(txtFind) || item.Email.Contains(txtFind) || item.Quyen.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (nhanvien == true)
            {
                foreach (User item in dsnv)
                {
                    if (item.Hoten.Contains(txtFind) || item.Email.Contains(txtFind) || item.Quyen.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (khach == true)
            {
                foreach (User item in dsuser)
                {
                    if (item.Hoten.Contains(txtFind) || item.Email.Contains(txtFind) || item.Quyen.Contains(txtFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            clear();
            nUsers = dstk.Count;
            ReSize();
            timer1.Enabled = true;
            timer1_Tick(null, null);
            timer2.Enabled = true;
            pnDisplay.Controls.Clear();
            if (nUsers != 0)
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
            pnDisplay.Visible = false;
            loadOverlay.Visible = true;
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
                    else if (admin == true)
                    {
                        if (dsadmin.Count != 0)
                        {
                            Xoa();
                        }
                    }
                    else if (nhanvien == true)
                    {
                        if (dsnv.Count != 0)
                        {
                            Xoa();
                        }
                    }
                    else if (khach == true)
                    {
                        if (dsuser.Count != 0)
                        {
                            Xoa();
                        }
                    }
                }
            }
        }
        private void Xoa()
        {
            foreach (ListMember item in pnDisplay.Controls)
            {
                if (item.isChecked == true && item.lVaiTro == "Nhân Viên")
                {
                    Controller.XoaNV(item.lEmail);
                }
                if (item.isChecked == true && item.lVaiTro == "Khách Hàng")
                {
                    Controller.XoaKhach(item.lEmail);
                }
            }
            reload();
            if (tatca == true)
            {
                btnTatCa_Click(null, null);
            }
            if (admin == true)
            {
                btnAdmin_Click(null, null);
            }
            if (nhanvien == true)
            {
                btnNhanVien_Click(null, null);
            }
            if (khach == true)
            {
                btnKhach_Click(null, null);
            }
        }
        private void reload()
        {
            dsadmin = dsuser = dsnv = null;
            dsAll.Clear();
            dsnv = Controller.getNhanVien();
            dsuser = Controller.getKhach();
            dsadmin = Controller.getAdmin();
            if (dsnv != null && dsuser != null && dsadmin != null)
            {
                label3.Text = "(" + dsadmin.Count.ToString() + ")";
                label5.Text = "(" + dsnv.Count.ToString() + ")";
                label7.Text = "(" + dsuser.Count.ToString() + ")";
                dsAll.AddRange(dsadmin);
                dsAll.AddRange(dsnv);
                dsAll.AddRange(dsuser);
            }
            else
            {
                btnAdmin.Enabled = false;
                btnKhach.Enabled = false;
                btnNhanVien.Enabled = false;

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
                nUsers = dsAll.Count;
                ReSize();
                addToPanel(dsAll);
            }
            if (admin == true)
            {
                nUsers = dsadmin.Count;
                ReSize();
                addToPanel(dsadmin);
            }
            if (nhanvien == true)
            {
                nUsers = dsnv.Count;
                ReSize();
                addToPanel(dsnv);
            }
            if (khach == true)
            {
                nUsers = dsuser.Count;
                ReSize();
                addToPanel(dsuser);
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
                if (admin == true)
                {
                    btnAdmin_Click(sender, e);
                }
                if (nhanvien == true)
                {
                    btnNhanVien_Click(null, null);
                }
                if (khach == true)
                {
                    btnKhach_Click(null, null);
                }
            }
        }
        private Form f;

        private void Users_Load(object sender, EventArgs e)
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
    }
}
