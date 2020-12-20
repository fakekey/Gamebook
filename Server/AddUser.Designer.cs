
namespace Server
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelRadius1 = new Server.PanelRadius();
            this.btnClose = new Server.NoFocusButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnLogin = new Server.NoFocusButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vaitrolb = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbPass = new System.Windows.Forms.Label();
            this.passlb = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mail = new System.Windows.Forms.Panel();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.userlb = new System.Windows.Forms.Panel();
            this.lbMail = new System.Windows.Forms.Label();
            this.mailb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRadius1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pass.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.name.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.mail.SuspendLayout();
            this.userlb.SuspendLayout();
            this.SuspendLayout();
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
            // panelRadius1
            // 
            this.panelRadius1.BackColor = System.Drawing.Color.Transparent;
            this.panelRadius1.Controls.Add(this.btnClose);
            this.panelRadius1.Controls.Add(this.panel2);
            this.panelRadius1.Controls.Add(this.label1);
            this.panelRadius1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRadius1.Location = new System.Drawing.Point(0, 0);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Padding = new System.Windows.Forms.Padding(33, 0, 33, 0);
            this.panelRadius1.Radius = 6;
            this.panelRadius1.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelRadius1.rSize = new System.Drawing.Size(480, 561);
            this.panelRadius1.Size = new System.Drawing.Size(481, 562);
            this.panelRadius1.TabIndex = 0;
            this.panelRadius1.TopLeft = new System.Drawing.Point(0, 0);
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
            this.btnClose.TabIndex = 14;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(33, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 464);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 439);
            this.panel3.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnLogin);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 355);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel9.Size = new System.Drawing.Size(415, 84);
            this.panel9.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.btnLogin.Location = new System.Drawing.Point(0, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(415, 48);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Thêm ngay bây giờ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 294);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(415, 61);
            this.panel6.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.comboBox1);
            this.panel11.Controls.Add(this.vaitrolb);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(415, 39);
            this.panel11.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Nhân Viên",
            "Khách Hàng"});
            this.comboBox1.Location = new System.Drawing.Point(76, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vaitrolb
            // 
            this.vaitrolb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaitrolb.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.vaitrolb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.vaitrolb.Location = new System.Drawing.Point(0, 0);
            this.vaitrolb.Margin = new System.Windows.Forms.Padding(0);
            this.vaitrolb.Name = "vaitrolb";
            this.vaitrolb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.vaitrolb.Size = new System.Drawing.Size(415, 39);
            this.vaitrolb.TabIndex = 0;
            this.vaitrolb.Text = "VAI TRÒ";
            this.vaitrolb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pass);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 196);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(415, 98);
            this.panel8.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.pass.Controls.Add(this.tbPass);
            this.pass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pass.Location = new System.Drawing.Point(0, 39);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(415, 42);
            this.pass.TabIndex = 1;
            this.pass.Paint += new System.Windows.Forms.PaintEventHandler(this.pass_Paint);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbPass.Location = new System.Drawing.Point(10, 10);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '•';
            this.tbPass.Size = new System.Drawing.Size(0, 22);
            this.tbPass.TabIndex = 0;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            this.tbPass.Enter += new System.EventHandler(this.tbPass_Enter);
            this.tbPass.Leave += new System.EventHandler(this.tbPass_Leave);
            this.tbPass.MouseEnter += new System.EventHandler(this.tbPass_MouseEnter);
            this.tbPass.MouseLeave += new System.EventHandler(this.tbPass_MouseLeave);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lbPass);
            this.panel10.Controls.Add(this.passlb);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(415, 39);
            this.panel10.TabIndex = 0;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Quicksand", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbPass.Location = new System.Drawing.Point(64, 16);
            this.lbPass.Margin = new System.Windows.Forms.Padding(0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbPass.Size = new System.Drawing.Size(0, 23);
            this.lbPass.TabIndex = 0;
            this.lbPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // passlb
            // 
            this.passlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passlb.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.passlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.passlb.Location = new System.Drawing.Point(0, 0);
            this.passlb.Margin = new System.Windows.Forms.Padding(0);
            this.passlb.Name = "passlb";
            this.passlb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.passlb.Size = new System.Drawing.Size(415, 39);
            this.passlb.TabIndex = 0;
            this.passlb.Text = "MẬT KHẨU";
            this.passlb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.name);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 98);
            this.panel4.TabIndex = 1;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.name.Controls.Add(this.tbName);
            this.name.Dock = System.Windows.Forms.DockStyle.Top;
            this.name.Location = new System.Drawing.Point(0, 39);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(415, 42);
            this.name.TabIndex = 1;
            this.name.Paint += new System.Windows.Forms.PaintEventHandler(this.name_Paint);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbName.Location = new System.Drawing.Point(10, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(0, 22);
            this.tbName.TabIndex = 0;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            this.tbName.MouseEnter += new System.EventHandler(this.tbName_MouseEnter);
            this.tbName.MouseLeave += new System.EventHandler(this.tbName_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbName);
            this.panel7.Controls.Add(this.namelb);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 39);
            this.panel7.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Quicksand", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbName.Location = new System.Drawing.Point(47, 16);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbName.Size = new System.Drawing.Size(0, 23);
            this.lbName.TabIndex = 0;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // namelb
            // 
            this.namelb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namelb.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.namelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.namelb.Location = new System.Drawing.Point(0, 0);
            this.namelb.Margin = new System.Windows.Forms.Padding(0);
            this.namelb.Name = "namelb";
            this.namelb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.namelb.Size = new System.Drawing.Size(415, 39);
            this.namelb.TabIndex = 0;
            this.namelb.Text = "HỌ TÊN";
            this.namelb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mail);
            this.panel5.Controls.Add(this.userlb);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 98);
            this.panel5.TabIndex = 0;
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.mail.Controls.Add(this.tbMail);
            this.mail.Dock = System.Windows.Forms.DockStyle.Top;
            this.mail.Location = new System.Drawing.Point(0, 39);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(415, 42);
            this.mail.TabIndex = 1;
            this.mail.Paint += new System.Windows.Forms.PaintEventHandler(this.mail_Paint);
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbMail.Location = new System.Drawing.Point(10, 10);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(0, 22);
            this.tbMail.TabIndex = 0;
            this.tbMail.Enter += new System.EventHandler(this.tbMail_Enter);
            this.tbMail.Leave += new System.EventHandler(this.tbMail_Leave);
            this.tbMail.MouseEnter += new System.EventHandler(this.tbMail_MouseEnter);
            this.tbMail.MouseLeave += new System.EventHandler(this.tbMail_MouseLeave);
            // 
            // userlb
            // 
            this.userlb.Controls.Add(this.lbMail);
            this.userlb.Controls.Add(this.mailb);
            this.userlb.Dock = System.Windows.Forms.DockStyle.Top;
            this.userlb.Location = new System.Drawing.Point(0, 0);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(415, 39);
            this.userlb.TabIndex = 0;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Quicksand", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbMail.Location = new System.Drawing.Point(38, 16);
            this.lbMail.Margin = new System.Windows.Forms.Padding(0);
            this.lbMail.Name = "lbMail";
            this.lbMail.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbMail.Size = new System.Drawing.Size(0, 23);
            this.lbMail.TabIndex = 0;
            this.lbMail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mailb
            // 
            this.mailb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailb.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mailb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.mailb.Location = new System.Drawing.Point(0, 0);
            this.mailb.Margin = new System.Windows.Forms.Padding(0);
            this.mailb.Name = "mailb";
            this.mailb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.mailb.Size = new System.Drawing.Size(415, 39);
            this.mailb.TabIndex = 0;
            this.mailb.Text = "EMAIL";
            this.mailb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm thành viên mới";
            // 
            // AddUser
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(481, 562);
            this.Controls.Add(this.panelRadius1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm thành viên";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panelRadius1.ResumeLayout(false);
            this.panelRadius1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pass.ResumeLayout(false);
            this.pass.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.name.ResumeLayout(false);
            this.name.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.mail.ResumeLayout(false);
            this.mail.PerformLayout();
            this.userlb.ResumeLayout(false);
            this.userlb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelRadius panelRadius1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel mail;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Panel userlb;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label mailb;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label passlb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel name;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label vaitrolb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel9;
        private NoFocusButton btnLogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private NoFocusButton btnClose;
    }
}