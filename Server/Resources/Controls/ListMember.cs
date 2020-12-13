﻿using System;
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
    }
}