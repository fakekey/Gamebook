﻿
namespace Server
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.btnMin = new Server.NoFocusButton();
            this.btnMax = new Server.NoFocusButton();
            this.btnExit = new Server.NoFocusButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.icoBill = new Server.PanelRadius();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.active4 = new Server.PanelRadius();
            this.panel11 = new System.Windows.Forms.Panel();
            this.icoProduct = new Server.PanelRadius();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.active3 = new Server.PanelRadius();
            this.panel8 = new System.Windows.Forms.Panel();
            this.icoUser = new Server.PanelRadius();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.active2 = new Server.PanelRadius();
            this.panel4 = new System.Windows.Forms.Panel();
            this.icoHome = new Server.PanelRadius();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelsd = new System.Windows.Forms.Panel();
            this.active1 = new Server.PanelRadius();
            this.line1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.icoBill.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel11.SuspendLayout();
            this.icoProduct.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel8.SuspendLayout();
            this.icoUser.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.icoHome.SuspendLayout();
            this.panelsd.SuspendLayout();
            this.line1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(97, 30);
            this.panel7.TabIndex = 7;
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "GAMEBOOK";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Server.Properties.Resources.icons8_customer_18px;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1236, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbName.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(1266, 0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(0, 2, 12, 0);
            this.lbName.Size = new System.Drawing.Size(12, 25);
            this.lbName.TabIndex = 5;
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::Server.Properties.Resources.icons8_minimize_window_18;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnMin.Location = new System.Drawing.Point(1278, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackgroundImage = global::Server.Properties.Resources.icons8_maximize_button_18;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnMax.Location = new System.Drawing.Point(1308, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 1;
            this.btnMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Server.Properties.Resources.icons8_multiply_20;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnExit.Location = new System.Drawing.Point(1338, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 738);
            this.panel2.TabIndex = 1;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.icoBill);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 204);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(97, 68);
            this.panel14.TabIndex = 3;
            this.panel14.Click += new System.EventHandler(this.panel14_Click);
            this.panel14.MouseEnter += new System.EventHandler(this.panel14_MouseEnter);
            this.panel14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel14_MouseMove);
            // 
            // icoBill
            // 
            this.icoBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoBill.Controls.Add(this.panel15);
            this.icoBill.Location = new System.Drawing.Point(22, 9);
            this.icoBill.Name = "icoBill";
            this.icoBill.Padding = new System.Windows.Forms.Padding(10);
            this.icoBill.Radius = 48;
            this.icoBill.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.icoBill.rSize = new System.Drawing.Size(48, 48);
            this.icoBill.Size = new System.Drawing.Size(49, 49);
            this.icoBill.TabIndex = 1;
            this.icoBill.TopLeft = new System.Drawing.Point(0, 0);
            this.icoBill.Click += new System.EventHandler(this.icoBill_Click);
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = global::Server.Properties.Resources.icons8_bill_48px;
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(10, 10);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(29, 29);
            this.panel15.TabIndex = 0;
            this.panel15.Click += new System.EventHandler(this.panel15_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.active4);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(0, 26, 0, 26);
            this.panel16.Size = new System.Drawing.Size(8, 68);
            this.panel16.TabIndex = 1;
            // 
            // active4
            // 
            this.active4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.active4.Location = new System.Drawing.Point(0, 26);
            this.active4.Name = "active4";
            this.active4.Radius = 6;
            this.active4.rColor = System.Drawing.Color.Empty;
            this.active4.rSize = new System.Drawing.Size(12, 15);
            this.active4.Size = new System.Drawing.Size(8, 16);
            this.active4.TabIndex = 1;
            this.active4.TopLeft = new System.Drawing.Point(-7, 0);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.icoProduct);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 136);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(97, 68);
            this.panel11.TabIndex = 2;
            this.panel11.Click += new System.EventHandler(this.panel11_Click);
            this.panel11.MouseEnter += new System.EventHandler(this.panel11_MouseEnter);
            this.panel11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel11_MouseMove);
            // 
            // icoProduct
            // 
            this.icoProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoProduct.Controls.Add(this.panel12);
            this.icoProduct.Location = new System.Drawing.Point(22, 9);
            this.icoProduct.Name = "icoProduct";
            this.icoProduct.Padding = new System.Windows.Forms.Padding(10);
            this.icoProduct.Radius = 48;
            this.icoProduct.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.icoProduct.rSize = new System.Drawing.Size(48, 48);
            this.icoProduct.Size = new System.Drawing.Size(49, 49);
            this.icoProduct.TabIndex = 1;
            this.icoProduct.TopLeft = new System.Drawing.Point(0, 0);
            this.icoProduct.Click += new System.EventHandler(this.icoProduct_Click);
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::Server.Properties.Resources.icons8_game_controller_48px;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(10, 10);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(29, 29);
            this.panel12.TabIndex = 0;
            this.panel12.Click += new System.EventHandler(this.panel12_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.active3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 26, 0, 26);
            this.panel13.Size = new System.Drawing.Size(8, 68);
            this.panel13.TabIndex = 1;
            // 
            // active3
            // 
            this.active3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.active3.Location = new System.Drawing.Point(0, 26);
            this.active3.Name = "active3";
            this.active3.Radius = 6;
            this.active3.rColor = System.Drawing.Color.Empty;
            this.active3.rSize = new System.Drawing.Size(12, 15);
            this.active3.Size = new System.Drawing.Size(8, 16);
            this.active3.TabIndex = 1;
            this.active3.TopLeft = new System.Drawing.Point(-7, 0);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.icoUser);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(97, 68);
            this.panel8.TabIndex = 1;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            this.panel8.MouseEnter += new System.EventHandler(this.panel8_MouseEnter);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseMove);
            // 
            // icoUser
            // 
            this.icoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoUser.Controls.Add(this.panel9);
            this.icoUser.Location = new System.Drawing.Point(23, 9);
            this.icoUser.Name = "icoUser";
            this.icoUser.Padding = new System.Windows.Forms.Padding(10);
            this.icoUser.Radius = 48;
            this.icoUser.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.icoUser.rSize = new System.Drawing.Size(48, 48);
            this.icoUser.Size = new System.Drawing.Size(49, 49);
            this.icoUser.TabIndex = 1;
            this.icoUser.TopLeft = new System.Drawing.Point(0, 0);
            this.icoUser.Click += new System.EventHandler(this.icoUser_Click);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::Server.Properties.Resources.icons8_user_48px;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(29, 29);
            this.panel9.TabIndex = 0;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.active2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 26, 0, 26);
            this.panel10.Size = new System.Drawing.Size(8, 68);
            this.panel10.TabIndex = 1;
            // 
            // active2
            // 
            this.active2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.active2.Location = new System.Drawing.Point(0, 26);
            this.active2.Name = "active2";
            this.active2.Radius = 6;
            this.active2.rColor = System.Drawing.Color.Empty;
            this.active2.rSize = new System.Drawing.Size(12, 15);
            this.active2.Size = new System.Drawing.Size(8, 16);
            this.active2.TabIndex = 1;
            this.active2.TopLeft = new System.Drawing.Point(-7, 0);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.icoHome);
            this.panel4.Controls.Add(this.panelsd);
            this.panel4.Controls.Add(this.line1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 68);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // icoHome
            // 
            this.icoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoHome.Controls.Add(this.panel5);
            this.icoHome.Location = new System.Drawing.Point(23, 9);
            this.icoHome.Name = "icoHome";
            this.icoHome.Padding = new System.Windows.Forms.Padding(10);
            this.icoHome.Radius = 48;
            this.icoHome.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.icoHome.rSize = new System.Drawing.Size(48, 48);
            this.icoHome.Size = new System.Drawing.Size(49, 49);
            this.icoHome.TabIndex = 1;
            this.icoHome.TopLeft = new System.Drawing.Point(0, 0);
            this.icoHome.Click += new System.EventHandler(this.icoHome_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Server.Properties.Resources.icons8_home_48px;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 29);
            this.panel5.TabIndex = 0;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panelsd
            // 
            this.panelsd.Controls.Add(this.active1);
            this.panelsd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsd.Location = new System.Drawing.Point(0, 0);
            this.panelsd.Name = "panelsd";
            this.panelsd.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.panelsd.Size = new System.Drawing.Size(8, 66);
            this.panelsd.TabIndex = 1;
            // 
            // active1
            // 
            this.active1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.active1.Location = new System.Drawing.Point(0, 25);
            this.active1.Name = "active1";
            this.active1.Radius = 6;
            this.active1.rColor = System.Drawing.Color.Empty;
            this.active1.rSize = new System.Drawing.Size(12, 15);
            this.active1.Size = new System.Drawing.Size(8, 16);
            this.active1.TabIndex = 0;
            this.active1.TopLeft = new System.Drawing.Point(-7, 0);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Controls.Add(this.panel6);
            this.line1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line1.Location = new System.Drawing.Point(0, 66);
            this.line1.Name = "line1";
            this.line1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.line1.Size = new System.Drawing.Size(97, 2);
            this.line1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(20, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 2);
            this.panel6.TabIndex = 0;
            // 
            // pnDisplay
            // 
            this.pnDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDisplay.Location = new System.Drawing.Point(97, 30);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Padding = new System.Windows.Forms.Padding(20);
            this.pnDisplay.Size = new System.Drawing.Size(1271, 738);
            this.pnDisplay.TabIndex = 2;
            this.pnDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel23_MouseMove);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1368, 768);
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điều khiển";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.icoBill.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.icoProduct.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.icoUser.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.icoHome.ResumeLayout(false);
            this.panelsd.ResumeLayout(false);
            this.line1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private NoFocusButton btnExit;
        private NoFocusButton btnMax;
        private NoFocusButton btnMin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelsd;
        private PanelRadius icoHome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private PanelRadius icoUser;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private PanelRadius icoProduct;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private PanelRadius icoBill;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnDisplay;
        private PanelRadius active1;
        private PanelRadius active4;
        private PanelRadius active3;
        private PanelRadius active2;
    }
}