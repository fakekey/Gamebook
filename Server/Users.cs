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
using Server.Resources.Models;

namespace Server
{
    public partial class Users : Form
    {
        // khoi tao danh sach
        List<User> dsnv = new List<User>();
        List<User> dsuser = new List<User>();
        List<User> dsadmin = new List<User>();
        List<User> dsAll = new List<User>();
        public Users()
        {
            InitializeComponent();
            btnTatCa_Click(null, null);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox1.AutoSize = false;
            textBox1.Size = new Size(230, 22);
            dsnv = Controller.getNhanVien();
            dsuser = Controller.getKhach();
            dsadmin = Controller.getAdmin();
            if (dsnv != null && dsuser != null && dsadmin != null)
            {
                label3.Text = "("+dsadmin.Count.ToString()+")";
                label5.Text = "("+dsnv.Count.ToString()+")";
                label7.Text = "(" + dsuser.Count.ToString() + ")";
                dsAll.AddRange(dsadmin);
                dsAll.AddRange(dsnv);
                dsAll.AddRange(dsuser);
            }
            else
            {
                // show in label : no data found !
            }
            if (dsAll != null)
            {
                label2.Text = "("+dsAll.Count.ToString()+")";
                for (int i = dsAll.Count - 1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        pnDisplay.Controls.Add(new ListMember()
                        {
                            lTen = dsAll[i].Hoten,
                            lEmail = dsAll[i].Email,
                            lVaiTro = dsAll[i].Quyen,
                            bgColor = ListMember.FIRST_COLOR,
                            isNotAdmin = (dsAll[i].Quyen != "Admin") ? true : false
                        });
                    }
                    else
                    {
                        pnDisplay.Controls.Add(
                        new ListMember()
                        {
                            lTen = dsAll[i].Hoten,
                            lEmail = dsAll[i].Email,
                            lVaiTro = dsAll[i].Quyen,
                            bgColor = ListMember.SECOND_COLOR,
                            isNotAdmin = (dsAll[i].Quyen != "Admin") ? true : false
                        });
                    }
                }
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
        bool tatca = true;
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
            nUsers = dsAll.Count;
            ReSize();
            pnDisplay.Controls.Clear();
            for (int i = dsAll.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    pnDisplay.Controls.Add(new ListMember()
                    {
                        lTen = dsAll[i].Hoten,
                        lEmail = dsAll[i].Email,
                        lVaiTro = dsAll[i].Quyen,
                        bgColor = ListMember.FIRST_COLOR,
                        isNotAdmin = (dsAll[i].Quyen != "Admin") ? true : false
                    });
                }
                else
                {
                    pnDisplay.Controls.Add(
                    new ListMember()
                    {
                        lTen = dsAll[i].Hoten,
                        lEmail = dsAll[i].Email,
                        lVaiTro = dsAll[i].Quyen,
                        bgColor = ListMember.SECOND_COLOR,
                        isNotAdmin = (dsAll[i].Quyen != "Admin") ? true : false
                    });
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            tatca = nhanvien = khach = false;
            admin = true;
            clear();
            nUsers = dsadmin.Count;
            ReSize();
            pnDisplay.Controls.Clear();
            for (int i = dsadmin.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    pnDisplay.Controls.Add(new ListMember()
                    {
                        lTen = dsadmin[i].Hoten,
                        lEmail = dsadmin[i].Email,
                        lVaiTro = dsadmin[i].Quyen,
                        bgColor = ListMember.FIRST_COLOR,
                        isNotAdmin = (dsadmin[i].Quyen != "Admin") ? true : false
                    });
                }
                else
                {
                    pnDisplay.Controls.Add(
                    new ListMember()
                    {
                        lTen = dsadmin[i].Hoten,
                        lEmail = dsadmin[i].Email,
                        lVaiTro = dsadmin[i].Quyen,
                        bgColor = ListMember.SECOND_COLOR,
                        isNotAdmin = (dsadmin[i].Quyen != "Admin") ? true : false
                    });
                }
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            admin = tatca = khach = false;
            nhanvien = true;
            clear();
            nUsers = dsnv.Count;
            ReSize();
            pnDisplay.Controls.Clear();
            for (int i = dsnv.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    pnDisplay.Controls.Add(new ListMember()
                    {
                        lTen = dsnv[i].Hoten,
                        lEmail = dsnv[i].Email,
                        lVaiTro = dsnv[i].Quyen,
                        bgColor = ListMember.FIRST_COLOR,
                        isNotAdmin = (dsnv[i].Quyen != "Admin") ? true : false
                    });
                }
                else
                {
                    pnDisplay.Controls.Add(
                    new ListMember()
                    {
                        lTen = dsnv[i].Hoten,
                        lEmail = dsnv[i].Email,
                        lVaiTro = dsnv[i].Quyen,
                        bgColor = ListMember.SECOND_COLOR,
                        isNotAdmin = (dsnv[i].Quyen != "Admin") ? true : false
                    });
                }
            }
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            admin = nhanvien = tatca = false;
            khach = true;
            clear();
            nUsers = dsnv.Count;
            ReSize();
            pnDisplay.Controls.Clear();
            for (int i = dsuser.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    pnDisplay.Controls.Add(new ListMember()
                    {
                        lTen = dsuser[i].Hoten,
                        lEmail = dsuser[i].Email,
                        lVaiTro = dsuser[i].Quyen,
                        bgColor = ListMember.FIRST_COLOR,
                        isNotAdmin = (dsuser[i].Quyen != "Admin") ? true : false
                    });
                }
                else
                {
                    pnDisplay.Controls.Add(
                    new ListMember()
                    {
                        lTen = dsuser[i].Hoten,
                        lEmail = dsuser[i].Email,
                        lVaiTro = dsuser[i].Quyen,
                        bgColor = ListMember.SECOND_COLOR,
                        isNotAdmin = (dsuser[i].Quyen != "Admin") ? true : false
                    });
                }
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

        private void noFocusButton3_Click(object sender, EventArgs e)
        {
            string textFind = textBox1.Text;
            List<User> dstk = new List<User>();
            if(tatca == true)
            {
                foreach(User item in dsAll)
                {
                    if(item.Hoten.Contains(textFind) || item.Email.Contains(textFind) || item.Quyen.Contains(textFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (nhanvien == true)
            {
                foreach (User item in dsnv)
                {
                    if (item.Hoten.Contains(textFind) || item.Email.Contains(textFind) || item.Quyen.Contains(textFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if(khach == true)
            {
                foreach (User item in dsuser)
                {
                    if (item.Hoten.Contains(textFind) || item.Email.Contains(textFind) || item.Quyen.Contains(textFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            if (admin == true)
            {
                foreach (User item in dsadmin)
                {
                    if (item.Hoten.Contains(textFind) || item.Email.Contains(textFind) || item.Quyen.Contains(textFind))
                    {
                        dstk.Add(item);
                    }
                }
            }
            nUsers = dstk.Count;
            pnDisplay.Controls.Clear();
        }
    }
}
