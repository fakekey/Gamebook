
namespace Server
{
    partial class lbBills
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.triangle1 = new Server.Triangle();
            this.panelRadius1 = new Server.PanelRadius();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelRadius1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.triangle1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 13, 0, 14);
            this.panel2.Size = new System.Drawing.Size(5, 37);
            this.panel2.TabIndex = 7;
            // 
            // triangle1
            // 
            this.triangle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangle1.Location = new System.Drawing.Point(0, 13);
            this.triangle1.Name = "triangle1";
            this.triangle1.rColor = System.Drawing.Color.Black;
            this.triangle1.Size = new System.Drawing.Size(5, 10);
            this.triangle1.TabIndex = 0;
            // 
            // panelRadius1
            // 
            this.panelRadius1.BackColor = System.Drawing.Color.Transparent;
            this.panelRadius1.Controls.Add(this.label1);
            this.panelRadius1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRadius1.Location = new System.Drawing.Point(5, 0);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Radius = 5;
            this.panelRadius1.rColor = System.Drawing.Color.Black;
            this.panelRadius1.rSize = new System.Drawing.Size(84, 36);
            this.panelRadius1.Size = new System.Drawing.Size(85, 37);
            this.panelRadius1.TabIndex = 8;
            this.panelRadius1.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(90, 37);
            this.Controls.Add(this.panelRadius1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(90, 37);
            this.Name = "lbBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "lbBills";
            this.panel2.ResumeLayout(false);
            this.panelRadius1.ResumeLayout(false);
            this.panelRadius1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Triangle triangle1;
        private PanelRadius panelRadius1;
        private System.Windows.Forms.Label label1;
    }
}