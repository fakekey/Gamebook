
namespace Server
{
    partial class AddBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBill));
            this.panelRadius1 = new Server.PanelRadius();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.btnClose = new Server.NoFocusButton();
            this.btnLogin = new Server.NoFocusButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ngay = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnam = new System.Windows.Forms.TextBox();
            this.tbthang = new System.Windows.Forms.TextBox();
            this.tbngay = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbngay = new System.Windows.Forms.Label();
            this.ngaylb = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gia = new System.Windows.Forms.Panel();
            this.tbgia = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbgia = new System.Windows.Forms.Label();
            this.gialb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tengame = new System.Windows.Forms.Panel();
            this.tbtengame = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbtengame = new System.Windows.Forms.Label();
            this.tengamelb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tenkh = new System.Windows.Forms.Panel();
            this.tbtenkh = new System.Windows.Forms.TextBox();
            this.tieudepn = new System.Windows.Forms.Panel();
            this.lbtenkh = new System.Windows.Forms.Label();
            this.tenkhlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelRadius1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.ngay.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gia.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tengame.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tenkh.SuspendLayout();
            this.tieudepn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRadius1
            // 
            this.panelRadius1.BackColor = System.Drawing.Color.Transparent;
            this.panelRadius1.Controls.Add(this.pnDisplay);
            this.panelRadius1.Controls.Add(this.btnClose);
            this.panelRadius1.Controls.Add(this.btnLogin);
            this.panelRadius1.Controls.Add(this.panel7);
            this.panelRadius1.Controls.Add(this.panel3);
            this.panelRadius1.Controls.Add(this.panel2);
            this.panelRadius1.Controls.Add(this.panel5);
            this.panelRadius1.Controls.Add(this.label1);
            this.panelRadius1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRadius1.Location = new System.Drawing.Point(0, 0);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Padding = new System.Windows.Forms.Padding(33, 0, 33, 0);
            this.panelRadius1.Radius = 6;
            this.panelRadius1.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelRadius1.rSize = new System.Drawing.Size(432, 586);
            this.panelRadius1.Size = new System.Drawing.Size(433, 587);
            this.panelRadius1.TabIndex = 1;
            this.panelRadius1.TopLeft = new System.Drawing.Point(0, 0);
            this.panelRadius1.Click += new System.EventHandler(this.panelRadius1_Click);
            // 
            // pnDisplay
            // 
            this.pnDisplay.AutoScroll = true;
            this.pnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.pnDisplay.Location = new System.Drawing.Point(371, 3);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Padding = new System.Windows.Forms.Padding(4);
            this.pnDisplay.Size = new System.Drawing.Size(366, 127);
            this.pnDisplay.TabIndex = 14;
            this.pnDisplay.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnDisplay_ControlRemoved);
            this.pnDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDisplay_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Server.Properties.Resources.icons8_back_arrow_32px;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.btnLogin.Location = new System.Drawing.Point(33, 507);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(366, 42);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Thêm ngay";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ngay);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Location = new System.Drawing.Point(33, 393);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(366, 98);
            this.panel7.TabIndex = 8;
            // 
            // ngay
            // 
            this.ngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ngay.Controls.Add(this.label4);
            this.ngay.Controls.Add(this.label2);
            this.ngay.Controls.Add(this.tbnam);
            this.ngay.Controls.Add(this.tbthang);
            this.ngay.Controls.Add(this.tbngay);
            this.ngay.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngay.Location = new System.Drawing.Point(0, 39);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(366, 42);
            this.ngay.TabIndex = 1;
            this.ngay.Paint += new System.Windows.Forms.PaintEventHandler(this.ngay_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(65, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(31, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // tbnam
            // 
            this.tbnam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbnam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnam.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbnam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbnam.Location = new System.Drawing.Point(76, 10);
            this.tbnam.Name = "tbnam";
            this.tbnam.Size = new System.Drawing.Size(41, 22);
            this.tbnam.TabIndex = 2;
            this.tbnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbnam.TextChanged += new System.EventHandler(this.tbnam_TextChanged);
            this.tbnam.Enter += new System.EventHandler(this.tbnam_Enter);
            this.tbnam.Leave += new System.EventHandler(this.tbnam_Leave);
            this.tbnam.MouseEnter += new System.EventHandler(this.tbnam_MouseEnter);
            this.tbnam.MouseLeave += new System.EventHandler(this.tbnam_MouseLeave);
            // 
            // tbthang
            // 
            this.tbthang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbthang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbthang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbthang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbthang.Location = new System.Drawing.Point(38, 10);
            this.tbthang.Name = "tbthang";
            this.tbthang.Size = new System.Drawing.Size(27, 22);
            this.tbthang.TabIndex = 1;
            this.tbthang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbthang.TextChanged += new System.EventHandler(this.tbthang_TextChanged);
            this.tbthang.Enter += new System.EventHandler(this.tbthang_Enter);
            this.tbthang.Leave += new System.EventHandler(this.tbthang_Leave);
            this.tbthang.MouseEnter += new System.EventHandler(this.tbthang_MouseEnter);
            this.tbthang.MouseLeave += new System.EventHandler(this.tbthang_MouseLeave);
            // 
            // tbngay
            // 
            this.tbngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbngay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbngay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbngay.Location = new System.Drawing.Point(12, 10);
            this.tbngay.Name = "tbngay";
            this.tbngay.Size = new System.Drawing.Size(19, 22);
            this.tbngay.TabIndex = 0;
            this.tbngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbngay.TextChanged += new System.EventHandler(this.tbngay_TextChanged);
            this.tbngay.Enter += new System.EventHandler(this.tbngay_Enter);
            this.tbngay.Leave += new System.EventHandler(this.tbngay_Leave);
            this.tbngay.MouseEnter += new System.EventHandler(this.tbngay_MouseEnter);
            this.tbngay.MouseLeave += new System.EventHandler(this.tbngay_MouseLeave);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lbngay);
            this.panel10.Controls.Add(this.ngaylb);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(366, 39);
            this.panel10.TabIndex = 0;
            // 
            // lbngay
            // 
            this.lbngay.AutoSize = true;
            this.lbngay.Font = new System.Drawing.Font("Quicksand", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbngay.Location = new System.Drawing.Point(95, 16);
            this.lbngay.Margin = new System.Windows.Forms.Padding(0);
            this.lbngay.Name = "lbngay";
            this.lbngay.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbngay.Size = new System.Drawing.Size(0, 23);
            this.lbngay.TabIndex = 1;
            this.lbngay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ngaylb
            // 
            this.ngaylb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngaylb.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ngaylb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.ngaylb.Location = new System.Drawing.Point(0, 0);
            this.ngaylb.Margin = new System.Windows.Forms.Padding(0);
            this.ngaylb.Name = "ngaylb";
            this.ngaylb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ngaylb.Size = new System.Drawing.Size(366, 39);
            this.ngaylb.TabIndex = 0;
            this.ngaylb.Text = "NGÀY MUA";
            this.ngaylb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gia);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Location = new System.Drawing.Point(33, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 98);
            this.panel3.TabIndex = 7;
            // 
            // gia
            // 
            this.gia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.gia.Controls.Add(this.tbgia);
            this.gia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gia.Location = new System.Drawing.Point(0, 39);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(366, 42);
            this.gia.TabIndex = 1;
            this.gia.Paint += new System.Windows.Forms.PaintEventHandler(this.gia_Paint);
            // 
            // tbgia
            // 
            this.tbgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbgia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbgia.Enabled = false;
            this.tbgia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbgia.Location = new System.Drawing.Point(10, 10);
            this.tbgia.Name = "tbgia";
            this.tbgia.Size = new System.Drawing.Size(340, 22);
            this.tbgia.TabIndex = 0;
            this.tbgia.Enter += new System.EventHandler(this.tbgia_Enter);
            this.tbgia.Leave += new System.EventHandler(this.tbgia_Leave);
            this.tbgia.MouseEnter += new System.EventHandler(this.tbgia_MouseEnter);
            this.tbgia.MouseLeave += new System.EventHandler(this.tbgia_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbgia);
            this.panel8.Controls.Add(this.gialb);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(366, 39);
            this.panel8.TabIndex = 0;
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.Font = new System.Drawing.Font("Quicksand", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbgia.Location = new System.Drawing.Point(22, 16);
            this.lbgia.Margin = new System.Windows.Forms.Padding(0);
            this.lbgia.Name = "lbgia";
            this.lbgia.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbgia.Size = new System.Drawing.Size(0, 23);
            this.lbgia.TabIndex = 0;
            this.lbgia.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // gialb
            // 
            this.gialb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gialb.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gialb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.gialb.Location = new System.Drawing.Point(0, 0);
            this.gialb.Margin = new System.Windows.Forms.Padding(0);
            this.gialb.Name = "gialb";
            this.gialb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.gialb.Size = new System.Drawing.Size(366, 39);
            this.gialb.TabIndex = 0;
            this.gialb.Text = "ĐƠN GIÁ";
            this.gialb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tengame);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(33, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 98);
            this.panel2.TabIndex = 5;
            // 
            // tengame
            // 
            this.tengame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tengame.Controls.Add(this.tbtengame);
            this.tengame.Dock = System.Windows.Forms.DockStyle.Top;
            this.tengame.Location = new System.Drawing.Point(0, 39);
            this.tengame.Name = "tengame";
            this.tengame.Size = new System.Drawing.Size(366, 42);
            this.tengame.TabIndex = 1;
            this.tengame.Paint += new System.Windows.Forms.PaintEventHandler(this.phienban_Paint);
            // 
            // tbtengame
            // 
            this.tbtengame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbtengame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtengame.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbtengame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbtengame.Location = new System.Drawing.Point(10, 10);
            this.tbtengame.Name = "tbtengame";
            this.tbtengame.Size = new System.Drawing.Size(340, 22);
            this.tbtengame.TabIndex = 0;
            this.tbtengame.TextChanged += new System.EventHandler(this.tbtengame_TextChanged);
            this.tbtengame.Enter += new System.EventHandler(this.tbphienban_Enter);
            this.tbtengame.Leave += new System.EventHandler(this.tbphienban_Leave);
            this.tbtengame.MouseEnter += new System.EventHandler(this.tbphienban_MouseEnter);
            this.tbtengame.MouseLeave += new System.EventHandler(this.tbphienban_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbtengame);
            this.panel4.Controls.Add(this.tengamelb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 39);
            this.panel4.TabIndex = 0;
            // 
            // lbtengame
            // 
            this.lbtengame.AutoSize = true;
            this.lbtengame.Font = new System.Drawing.Font("Quicksand", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbtengame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbtengame.Location = new System.Drawing.Point(63, 16);
            this.lbtengame.Margin = new System.Windows.Forms.Padding(0);
            this.lbtengame.Name = "lbtengame";
            this.lbtengame.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbtengame.Size = new System.Drawing.Size(0, 23);
            this.lbtengame.TabIndex = 0;
            this.lbtengame.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tengamelb
            // 
            this.tengamelb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tengamelb.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tengamelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.tengamelb.Location = new System.Drawing.Point(0, 0);
            this.tengamelb.Margin = new System.Windows.Forms.Padding(0);
            this.tengamelb.Name = "tengamelb";
            this.tengamelb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tengamelb.Size = new System.Drawing.Size(366, 39);
            this.tengamelb.TabIndex = 0;
            this.tengamelb.Text = "TÊN GAME";
            this.tengamelb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tenkh);
            this.panel5.Controls.Add(this.tieudepn);
            this.panel5.Location = new System.Drawing.Point(33, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 98);
            this.panel5.TabIndex = 4;
            // 
            // tenkh
            // 
            this.tenkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tenkh.Controls.Add(this.tbtenkh);
            this.tenkh.Dock = System.Windows.Forms.DockStyle.Top;
            this.tenkh.Location = new System.Drawing.Point(0, 39);
            this.tenkh.Name = "tenkh";
            this.tenkh.Size = new System.Drawing.Size(366, 42);
            this.tenkh.TabIndex = 1;
            this.tenkh.Paint += new System.Windows.Forms.PaintEventHandler(this.tieude_Paint);
            // 
            // tbtenkh
            // 
            this.tbtenkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbtenkh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtenkh.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbtenkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbtenkh.Location = new System.Drawing.Point(10, 10);
            this.tbtenkh.Name = "tbtenkh";
            this.tbtenkh.Size = new System.Drawing.Size(340, 22);
            this.tbtenkh.TabIndex = 0;
            this.tbtenkh.TextChanged += new System.EventHandler(this.tbtenkh_TextChanged);
            this.tbtenkh.Enter += new System.EventHandler(this.tbtieude_Enter);
            this.tbtenkh.Leave += new System.EventHandler(this.tbtieude_Leave);
            this.tbtenkh.MouseEnter += new System.EventHandler(this.tbtieude_MouseEnter);
            this.tbtenkh.MouseLeave += new System.EventHandler(this.tbtieude_MouseLeave);
            // 
            // tieudepn
            // 
            this.tieudepn.Controls.Add(this.lbtenkh);
            this.tieudepn.Controls.Add(this.tenkhlb);
            this.tieudepn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tieudepn.Location = new System.Drawing.Point(0, 0);
            this.tieudepn.Name = "tieudepn";
            this.tieudepn.Size = new System.Drawing.Size(366, 39);
            this.tieudepn.TabIndex = 0;
            // 
            // lbtenkh
            // 
            this.lbtenkh.AutoSize = true;
            this.lbtenkh.Font = new System.Drawing.Font("Quicksand", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbtenkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbtenkh.Location = new System.Drawing.Point(109, 16);
            this.lbtenkh.Margin = new System.Windows.Forms.Padding(0);
            this.lbtenkh.Name = "lbtenkh";
            this.lbtenkh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbtenkh.Size = new System.Drawing.Size(0, 23);
            this.lbtenkh.TabIndex = 0;
            this.lbtenkh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tenkhlb
            // 
            this.tenkhlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tenkhlb.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tenkhlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.tenkhlb.Location = new System.Drawing.Point(0, 0);
            this.tenkhlb.Margin = new System.Windows.Forms.Padding(0);
            this.tenkhlb.Name = "tenkhlb";
            this.tenkhlb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tenkhlb.Size = new System.Drawing.Size(366, 39);
            this.tenkhlb.TabIndex = 0;
            this.tenkhlb.Text = "TÊN KHÁCH HÀNG";
            this.tenkhlb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thêm hóa đơn mới";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 950;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // AddBill
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(433, 587);
            this.Controls.Add(this.panelRadius1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hóa đơn";
            this.Load += new System.EventHandler(this.AddBill_Load);
            this.panelRadius1.ResumeLayout(false);
            this.panelRadius1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ngay.ResumeLayout(false);
            this.ngay.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gia.ResumeLayout(false);
            this.gia.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tengame.ResumeLayout(false);
            this.tengame.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tenkh.ResumeLayout(false);
            this.tenkh.PerformLayout();
            this.tieudepn.ResumeLayout(false);
            this.tieudepn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelRadius panelRadius1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel tenkh;
        private System.Windows.Forms.TextBox tbtenkh;
        private System.Windows.Forms.Panel tieudepn;
        private System.Windows.Forms.Label lbtenkh;
        private System.Windows.Forms.Label tenkhlb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel tengame;
        private System.Windows.Forms.TextBox tbtengame;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tengamelb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel gia;
        private System.Windows.Forms.TextBox tbgia;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.Label gialb;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel ngay;
        private System.Windows.Forms.TextBox tbngay;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label ngaylb;
        private System.Windows.Forms.TextBox tbthang;
        private System.Windows.Forms.TextBox tbnam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private NoFocusButton btnLogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbngay;
        private NoFocusButton btnClose;
        private System.Windows.Forms.Label lbtengame;
        private System.Windows.Forms.Panel pnDisplay;
    }
}