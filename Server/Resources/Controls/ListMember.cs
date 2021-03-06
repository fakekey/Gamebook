﻿using System;
using System.Drawing;
using System.Windows.Forms;
namespace Server
{
    public partial class ListMember : UserControl
    {
        public static Color FIRST_COLOR = Color.FromArgb(52, 55, 60);
        public static Color SECOND_COLOR = Color.FromArgb(54, 57, 63);
        public ListMember()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }
        public Color bgColor { get => this.BackColor; set => this.BackColor = value; }
        public bool isChecked { get => checkBox2.Checked; set => checkBox2.Checked = value; }
        public string lTen { get => label1.Text; set => label1.Text = value; }
        public string lEmail { get => label10.Text; set => label10.Text = value; }
        public string lVaiTro { get => label9.Text; set => label9.Text = value; }
        public bool isNotAdmin { get => btnXoa.Visible; set => btnXoa.Visible = value; }

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
            if (Messagebox.Show("CẢNH BÁO", "Bạn có chắc muốn xóa không ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CheckClass.count = 1;
                if (this.lVaiTro == "Nhân Viên")
                {
                    Controller.XoaNV(this.lEmail);
                }
                if (this.lVaiTro == "Khách Hàng")
                {
                    Controller.XoaKhach(this.lEmail);
                }
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
                using (EditUser fOverlay = new EditUser(lEmail, lTen, lVaiTro))
                {
                    f.Show();
                    fOverlay.Owner = f;
                    fOverlay.ShowDialog();
                    CheckClass.count = 1;
                    this.Dispose();
                }
            }
        }
    }
}
