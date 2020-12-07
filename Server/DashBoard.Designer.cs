
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new Server.NoFocusButton();
            this.btnMax = new Server.NoFocusButton();
            this.btnExit = new Server.NoFocusButton();
            this.lbName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Whitney Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "GAMEBOOK";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 738);
            this.panel2.TabIndex = 1;
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
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.lbName.Location = new System.Drawing.Point(1266, 0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(0, 5, 12, 0);
            this.lbName.Size = new System.Drawing.Size(12, 25);
            this.lbName.TabIndex = 5;
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
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1368, 768);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private NoFocusButton btnExit;
        private NoFocusButton btnMax;
        private NoFocusButton btnMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel3;
    }
}