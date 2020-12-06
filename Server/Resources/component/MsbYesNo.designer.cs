using System.Drawing;

namespace Server
{
    partial class MsbYesNo
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
        private void InitializeUI()
        {
            BorderRadius.SetBorderRadius(btnYes, 5, 5);
            pnDrop1.BackColor = Color.FromArgb(15, 204, 41, 47);
            BorderRadius.SetBorderRadius(pnDrop1, 10, 10);
            pnDrop2.BackColor = Color.FromArgb(25, 204, 41, 47);
            BorderRadius.SetBorderRadius(pnDrop2, 10, 10);
            pnDrop3.BackColor = Color.FromArgb(35, 204, 41, 47);
            BorderRadius.SetBorderRadius(pnDrop3, 10, 10);
            pnDrop4.BackColor = Color.FromArgb(45, 204, 41, 47);
            BorderRadius.SetBorderRadius(pnDrop4, 10, 10);
            BorderRadius.SetBorderRadius(btnNo, 5, 5);
            panel4.BackColor = Color.FromArgb(15, 204, 41, 47);
            BorderRadius.SetBorderRadius(panel4, 10, 10);
            panel5.BackColor = Color.FromArgb(25, 204, 41, 47);
            BorderRadius.SetBorderRadius(panel5, 10, 10);
            panel6.BackColor = Color.FromArgb(35, 204, 41, 47);
            BorderRadius.SetBorderRadius(panel6, 10, 10);
            panel7.BackColor = Color.FromArgb(45, 204, 41, 47);
            BorderRadius.SetBorderRadius(panel7, 10, 10);
            BorderRadius.SetBorderRadius(this, 30, 30);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsbYesNo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.pnDrop1 = new System.Windows.Forms.Panel();
            this.pnDrop2 = new System.Windows.Forms.Panel();
            this.pnDrop3 = new System.Windows.Forms.Panel();
            this.pnDrop4 = new System.Windows.Forms.Panel();
            this.btnYes = new Server.NoFocusButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnNo = new Server.NoFocusButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnDrop1.SuspendLayout();
            this.pnDrop2.SuspendLayout();
            this.pnDrop3.SuspendLayout();
            this.pnDrop4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 109);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(179, 13);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(96, 96);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 42);
            this.panel2.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(455, 42);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "title";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbMessage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 84);
            this.panel3.TabIndex = 4;
            // 
            // lbMessage
            // 
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("Quicksand", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(0, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbMessage.Size = new System.Drawing.Size(455, 84);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "message";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnDrop1
            // 
            this.pnDrop1.Controls.Add(this.pnDrop2);
            this.pnDrop1.Location = new System.Drawing.Point(99, 241);
            this.pnDrop1.Name = "pnDrop1";
            this.pnDrop1.Size = new System.Drawing.Size(118, 53);
            this.pnDrop1.TabIndex = 6;
            // 
            // pnDrop2
            // 
            this.pnDrop2.Controls.Add(this.pnDrop3);
            this.pnDrop2.Location = new System.Drawing.Point(1, 1);
            this.pnDrop2.Name = "pnDrop2";
            this.pnDrop2.Size = new System.Drawing.Size(116, 51);
            this.pnDrop2.TabIndex = 7;
            // 
            // pnDrop3
            // 
            this.pnDrop3.Controls.Add(this.pnDrop4);
            this.pnDrop3.Location = new System.Drawing.Point(1, 1);
            this.pnDrop3.Name = "pnDrop3";
            this.pnDrop3.Size = new System.Drawing.Size(114, 49);
            this.pnDrop3.TabIndex = 8;
            // 
            // pnDrop4
            // 
            this.pnDrop4.Controls.Add(this.btnYes);
            this.pnDrop4.Location = new System.Drawing.Point(1, 1);
            this.pnDrop4.Name = "pnDrop4";
            this.pnDrop4.Size = new System.Drawing.Size(112, 47);
            this.pnDrop4.TabIndex = 103;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(1, 1);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(110, 45);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Có";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(238, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 53);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(116, 51);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 49);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnNo);
            this.panel7.Location = new System.Drawing.Point(1, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(112, 47);
            this.panel7.TabIndex = 103;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(1, 1);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(110, 45);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "Không";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // MsbYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 311);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnDrop1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MsbYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnDrop1.ResumeLayout(false);
            this.pnDrop2.ResumeLayout(false);
            this.pnDrop3.ResumeLayout(false);
            this.pnDrop4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel pnDrop1;
        private System.Windows.Forms.Panel pnDrop2;
        private System.Windows.Forms.Panel pnDrop3;
        private System.Windows.Forms.Panel pnDrop4;
        private NoFocusButton btnYes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private NoFocusButton btnNo;
    }
}