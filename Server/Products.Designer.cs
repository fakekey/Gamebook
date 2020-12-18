namespace Server
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.usertb = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.noFocusButton3 = new Server.NoFocusButton();
            this.noFocusButton1 = new Server.NoFocusButton();
            this.pnIndie = new Server.PanelRadius();
            this.btnIndie = new System.Windows.Forms.Label();
            this.pnAAA = new Server.PanelRadius();
            this.btnAAA = new System.Windows.Forms.Label();
            this.pnTatCa = new Server.PanelRadius();
            this.btnTatCa = new System.Windows.Forms.Label();
            this.panelRadius1 = new Server.PanelRadius();
            this.btnAdd = new System.Windows.Forms.Label();
            this.usertb.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnIndie.SuspendLayout();
            this.pnAAA.SuspendLayout();
            this.pnTatCa.SuspendLayout();
            this.panelRadius1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usertb
            // 
            this.usertb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usertb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.usertb.Controls.Add(this.textBox1);
            this.usertb.Location = new System.Drawing.Point(767, 26);
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(260, 33);
            this.usertb.TabIndex = 4;
            this.usertb.Paint += new System.Windows.Forms.PaintEventHandler(this.usertb_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBox1.Location = new System.Drawing.Point(10, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chức năng...",
            "Xóa"});
            this.comboBox1.Location = new System.Drawing.Point(1, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 31);
            this.comboBox1.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.noFocusButton3);
            this.panel13.Controls.Add(this.usertb);
            this.panel13.Controls.Add(this.noFocusButton1);
            this.panel13.Controls.Add(this.comboBox1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 112);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel13.Size = new System.Drawing.Size(1151, 82);
            this.panel13.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1151, 68);
            this.panel2.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.pnIndie);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(339, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(178, 48);
            this.panel9.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.label5.Location = new System.Drawing.Point(121, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "(0)";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(338, 20);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel7.Size = new System.Drawing.Size(1, 48);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 24);
            this.panel8.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pnAAA);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(161, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 48);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.label3.Location = new System.Drawing.Point(121, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "(0)";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(160, 20);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel4.Size = new System.Drawing.Size(1, 48);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 24);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pnTatCa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 48);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(106, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "(0)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelRadius1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 44);
            this.panel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 194);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 57);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1027, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(121, 57);
            this.label10.TabIndex = 18;
            this.label10.Text = "Giá";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(835, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(186, 57);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày sản xuất";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(643, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(186, 57);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phiên bản";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(451, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(186, 57);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nhà sản xuất";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(191, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(254, 57);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiêu đề";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(29, 6, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(42, 51);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pnDisplay
            // 
            this.pnDisplay.AutoScroll = true;
            this.pnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDisplay.Location = new System.Drawing.Point(0, 251);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Padding = new System.Windows.Forms.Padding(16, 10, 16, 16);
            this.pnDisplay.Size = new System.Drawing.Size(1151, 487);
            this.pnDisplay.TabIndex = 13;
            // 
            // timer3
            // 
            this.timer3.Interval = 250;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // noFocusButton3
            // 
            this.noFocusButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noFocusButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.noFocusButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noFocusButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.noFocusButton3.FlatAppearance.BorderSize = 0;
            this.noFocusButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.noFocusButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.noFocusButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noFocusButton3.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.noFocusButton3.ForeColor = System.Drawing.Color.White;
            this.noFocusButton3.Location = new System.Drawing.Point(1034, 26);
            this.noFocusButton3.Name = "noFocusButton3";
            this.noFocusButton3.Size = new System.Drawing.Size(115, 32);
            this.noFocusButton3.TabIndex = 5;
            this.noFocusButton3.Text = "Tìm kiếm";
            this.noFocusButton3.UseVisualStyleBackColor = false;
            this.noFocusButton3.Click += new System.EventHandler(this.noFocusButton3_Click);
            // 
            // noFocusButton1
            // 
            this.noFocusButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.noFocusButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noFocusButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.noFocusButton1.FlatAppearance.BorderSize = 0;
            this.noFocusButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.noFocusButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.noFocusButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noFocusButton1.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.noFocusButton1.ForeColor = System.Drawing.Color.White;
            this.noFocusButton1.Location = new System.Drawing.Point(197, 27);
            this.noFocusButton1.Name = "noFocusButton1";
            this.noFocusButton1.Size = new System.Drawing.Size(110, 32);
            this.noFocusButton1.TabIndex = 1;
            this.noFocusButton1.Text = "Áp dụng";
            this.noFocusButton1.UseVisualStyleBackColor = false;
            // 
            // pnIndie
            // 
            this.pnIndie.BackColor = System.Drawing.Color.Transparent;
            this.pnIndie.Controls.Add(this.btnIndie);
            this.pnIndie.Location = new System.Drawing.Point(15, 11);
            this.pnIndie.Name = "pnIndie";
            this.pnIndie.Radius = 5;
            this.pnIndie.rColor = System.Drawing.Color.Transparent;
            this.pnIndie.rSize = new System.Drawing.Size(101, 24);
            this.pnIndie.Size = new System.Drawing.Size(102, 25);
            this.pnIndie.TabIndex = 1;
            this.pnIndie.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // btnIndie
            // 
            this.btnIndie.BackColor = System.Drawing.Color.Transparent;
            this.btnIndie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIndie.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnIndie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.btnIndie.Location = new System.Drawing.Point(0, 0);
            this.btnIndie.Name = "btnIndie";
            this.btnIndie.Size = new System.Drawing.Size(102, 25);
            this.btnIndie.TabIndex = 0;
            this.btnIndie.Text = "Indie Games";
            this.btnIndie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIndie.Click += new System.EventHandler(this.btnIndie_Click);
            this.btnIndie.MouseEnter += new System.EventHandler(this.btnIndie_MouseEnter);
            this.btnIndie.MouseLeave += new System.EventHandler(this.btnIndie_MouseLeave);
            // 
            // pnAAA
            // 
            this.pnAAA.BackColor = System.Drawing.Color.Transparent;
            this.pnAAA.Controls.Add(this.btnAAA);
            this.pnAAA.Location = new System.Drawing.Point(15, 11);
            this.pnAAA.Name = "pnAAA";
            this.pnAAA.Radius = 5;
            this.pnAAA.rColor = System.Drawing.Color.Transparent;
            this.pnAAA.rSize = new System.Drawing.Size(101, 24);
            this.pnAAA.Size = new System.Drawing.Size(102, 25);
            this.pnAAA.TabIndex = 1;
            this.pnAAA.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // btnAAA
            // 
            this.btnAAA.BackColor = System.Drawing.Color.Transparent;
            this.btnAAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAAA.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.btnAAA.Location = new System.Drawing.Point(0, 0);
            this.btnAAA.Name = "btnAAA";
            this.btnAAA.Size = new System.Drawing.Size(102, 25);
            this.btnAAA.TabIndex = 0;
            this.btnAAA.Text = "AAA Games";
            this.btnAAA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAAA.Click += new System.EventHandler(this.btnAAA_Click);
            this.btnAAA.MouseEnter += new System.EventHandler(this.btnAAA_MouseEnter);
            this.btnAAA.MouseLeave += new System.EventHandler(this.btnAAA_MouseLeave);
            // 
            // pnTatCa
            // 
            this.pnTatCa.BackColor = System.Drawing.Color.Transparent;
            this.pnTatCa.Controls.Add(this.btnTatCa);
            this.pnTatCa.Location = new System.Drawing.Point(0, 11);
            this.pnTatCa.Name = "pnTatCa";
            this.pnTatCa.Radius = 5;
            this.pnTatCa.rColor = System.Drawing.Color.Transparent;
            this.pnTatCa.rSize = new System.Drawing.Size(101, 24);
            this.pnTatCa.Size = new System.Drawing.Size(102, 25);
            this.pnTatCa.TabIndex = 1;
            this.pnTatCa.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.Transparent;
            this.btnTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTatCa.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.btnTatCa.Location = new System.Drawing.Point(0, 0);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(102, 25);
            this.btnTatCa.TabIndex = 0;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            this.btnTatCa.MouseEnter += new System.EventHandler(this.btnTatCa_MouseEnter);
            this.btnTatCa.MouseLeave += new System.EventHandler(this.btnTatCa_MouseLeave);
            // 
            // panelRadius1
            // 
            this.panelRadius1.Controls.Add(this.btnAdd);
            this.panelRadius1.Location = new System.Drawing.Point(153, 0);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Radius = 0;
            this.panelRadius1.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.panelRadius1.rSize = new System.Drawing.Size(114, 37);
            this.panelRadius1.Size = new System.Drawing.Size(115, 38);
            this.panelRadius1.TabIndex = 1;
            this.panelRadius1.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1151, 738);
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.usertb.ResumeLayout(false);
            this.usertb.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnIndie.ResumeLayout(false);
            this.pnAAA.ResumeLayout(false);
            this.pnTatCa.ResumeLayout(false);
            this.panelRadius1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel usertb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel13;
        private NoFocusButton noFocusButton3;
        private NoFocusButton noFocusButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private PanelRadius pnIndie;
        private System.Windows.Forms.Label btnIndie;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private PanelRadius pnAAA;
        private System.Windows.Forms.Label btnAAA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private PanelRadius pnTatCa;
        private System.Windows.Forms.Label btnTatCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private PanelRadius panelRadius1;
        private System.Windows.Forms.Label btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer4;
    }
}