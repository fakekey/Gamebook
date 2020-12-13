using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transitions;
using Transitions.TransitionTypes;
using System.Windows.Forms;

namespace Server
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            btnTatCa_Click(null, null);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox1.AutoSize = false;
            textBox1.Size = new Size(230, 22);
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
        //demo
        struct MayThangNgu
        {
            public string HoTen;
            public string Email;
            public string VaiTro;
            public MayThangNgu(string a, string b, string c)
            {
                HoTen = a;
                Email = b;
                VaiTro = c;
            }
        }
        MayThangNgu[] ds = new MayThangNgu[] {
            new MayThangNgu("Admin","admin","Admin"),
            new MayThangNgu("Nguyễn Thế Trường","truongnt@gmail.com","Nhân viên"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
            new MayThangNgu("Ngọc Hoàng","ngochoang@gmail.com","Khách hàng"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
            new MayThangNgu("Ngọc Hoàng","ngochoang@gmail.com","Khách hàng"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
            new MayThangNgu("Ngọc Hoàng","ngochoang@gmail.com","Khách hàng"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
            new MayThangNgu("Ngọc Hoàng","ngochoang@gmail.com","Khách hàng"),
        };
        MayThangNgu[] ds1 = new MayThangNgu[] {
            new MayThangNgu("Admin","admin","Admin"),
            new MayThangNgu("Nguyễn Thế Trường","truongnt@gmail.com","Nhân viên"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
            new MayThangNgu("Ngọc Hoàng","ngochoang@gmail.com","Khách hàng"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
            new MayThangNgu("Ngọc Hoàng","ngochoang@gmail.com","Khách hàng"),
            new MayThangNgu("Trần Ngọc Anh","anhnt@gmail.com","Nhân viên"),
        };
        MayThangNgu[] ds2 = new MayThangNgu[0];
        public void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm(new AddUser());
        }
        private void AddForm(Form form)
        {
            this.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            form.Show();
        }

        private void btnTatCa_MouseEnter(object sender, EventArgs e)
        {
            if (tatca == false)
            {
                Transition t = new Transition(new EaseInEaseOut(400));
                t.Add(btnTatCa, "ForeColor", Color.White);
                t.Run();
                pnTatCa.rColor = Color.FromArgb(82, 79, 84, 92);
                pnTatCa.Refresh();
            }
        }

        private void btnTatCa_MouseLeave(object sender, EventArgs e)
        {
            if (tatca == false)
            {
                Transition t = new Transition(new EaseInEaseOut(400));
                t.Add(btnTatCa, "ForeColor", Color.FromArgb(220, 221, 222));
                t.Run();
                pnTatCa.rColor = Color.Transparent;
                pnTatCa.Refresh();
            }
        }

        private void btnAdmin_MouseEnter(object sender, EventArgs e)
        {
            if (admin == false)
            {
                Transition t = new Transition(new EaseInEaseOut(400));
                t.Add(btnAdmin, "ForeColor", Color.White);
                t.Run();
                pnAdmin.rColor = Color.FromArgb(82, 79, 84, 92);
                pnAdmin.Refresh();
            }
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            if (admin == false)
            {
                Transition t = new Transition(new EaseInEaseOut(400));
                t.Add(btnAdmin, "ForeColor", Color.FromArgb(220, 221, 222));
                t.Run();
                pnAdmin.rColor = Color.Transparent;
                pnAdmin.Refresh();
            }
        }

        private void btnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            if (nhanvien == false)
            {
                Transition t = new Transition(new EaseInEaseOut(400));
                t.Add(btnNhanVien, "ForeColor", Color.White);
                t.Run();
                pnNhanVien.rColor = Color.FromArgb(82, 79, 84, 92);
                pnNhanVien.Refresh();
            }
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            if (nhanvien == false)
            {
                Transition t = new Transition(new EaseInEaseOut(400));
                t.Add(btnNhanVien, "ForeColor", Color.FromArgb(220, 221, 222));
                t.Run();
                pnNhanVien.rColor = Color.Transparent;
                pnNhanVien.Refresh();
            }
        }

        private void btnKhach_MouseEnter(object sender, EventArgs e)
        {
            if (khach == false)
            {
                Transition t = new Transition(new EaseInEaseOut(400));
                t.Add(btnKhach, "ForeColor", Color.White);
                t.Run();
                pnKhach.rColor = Color.FromArgb(82, 79, 84, 92);
                pnKhach.Refresh();
            }
        }

        private void btnKhach_MouseLeave(object sender, EventArgs e)
        {
            if (khach == false)
            {
                Transition t = new Transition(new EaseInEaseOut(400));
                t.Add(btnKhach, "ForeColor", Color.FromArgb(220, 221, 222));
                t.Run();
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
            admin = nhanvien = khach = false;
            tatca = true;
            btnTatCa.ForeColor = Color.White;
            pnTatCa.rColor = Color.FromArgb(82, 79, 84, 92);
            clear();
            nUsers = ds.Length;
            ReSize();
            pnDisplay.Controls.Clear();
            if (nUsers != 0)
            {
                for (int i = ds.Length - 1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        pnDisplay.Controls.Add(new ListMember()
                        {
                            lTen = ds[i].HoTen,
                            lEmail = ds[i].Email,
                            lVaiTro = ds[i].VaiTro,
                            bgColor = ListMember.FIRST_COLOR,
                            isNotAdmin = (ds[i].VaiTro != "Admin") ? true : false
                        });
                    }
                    else
                    {
                        pnDisplay.Controls.Add(
                        new ListMember()
                        {
                            lTen = ds[i].HoTen,
                            lEmail = ds[i].Email,
                            lVaiTro = ds[i].VaiTro,
                            bgColor = ListMember.SECOND_COLOR,
                            isNotAdmin = (ds[i].VaiTro != "Admin") ? true : false
                        });
                    }
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
                    Padding = new Padding(0, 0, 0, 50),
                    Text = "Không tìm thấy dữ liệu",
                    TextAlign = ContentAlignment.MiddleCenter,
                });
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            tatca = nhanvien = khach = false;
            admin = true;
            clear();
            nUsers = ds1.Length;
            ReSize();
            pnDisplay.Controls.Clear();
            if (nUsers != 0)
            {
                for (int i = ds1.Length - 1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        pnDisplay.Controls.Add(new ListMember()
                        {
                            lTen = ds1[i].HoTen,
                            lEmail = ds1[i].Email,
                            lVaiTro = ds1[i].VaiTro,
                            bgColor = ListMember.FIRST_COLOR,
                            isNotAdmin = (ds1[i].VaiTro != "Admin") ? true : false
                        });
                    }
                    else
                    {
                        pnDisplay.Controls.Add(
                        new ListMember()
                        {
                            lTen = ds1[i].HoTen,
                            lEmail = ds1[i].Email,
                            lVaiTro = ds1[i].VaiTro,
                            bgColor = ListMember.SECOND_COLOR,
                            isNotAdmin = (ds1[i].VaiTro != "Admin") ? true : false
                        });
                    }
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
                    Padding = new Padding(0, 0, 0, 50),
                    Text = "Không tìm thấy dữ liệu",
                    TextAlign = ContentAlignment.MiddleCenter,
                });
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            admin = tatca = khach = false;
            nhanvien = true;
            clear();
            nUsers = ds2.Length;
            ReSize();
            pnDisplay.Controls.Clear();
            if (nUsers != 0)
            {
                for (int i = ds2.Length - 1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        pnDisplay.Controls.Add(new ListMember()
                        {
                            lTen = ds2[i].HoTen,
                            lEmail = ds2[i].Email,
                            lVaiTro = ds2[i].VaiTro,
                            bgColor = ListMember.FIRST_COLOR,
                            isNotAdmin = (ds2[i].VaiTro != "Admin") ? true : false
                        });
                    }
                    else
                    {
                        pnDisplay.Controls.Add(
                        new ListMember()
                        {
                            lTen = ds2[i].HoTen,
                            lEmail = ds2[i].Email,
                            lVaiTro = ds2[i].VaiTro,
                            bgColor = ListMember.SECOND_COLOR,
                            isNotAdmin = (ds2[i].VaiTro != "Admin") ? true : false
                        });
                    }
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
                    Padding = new Padding(0, 0, 0, 50),
                    Text = "Không tìm thấy dữ liệu",
                    TextAlign = ContentAlignment.MiddleCenter,
                });
            }
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            admin = nhanvien = tatca = false;
            khach = true;
            clear();
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
    }
}
