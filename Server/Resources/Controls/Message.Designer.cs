
namespace Server
{
    partial class Message
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.triangle1 = new Server.Triangle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRadius1 = new Server.PanelRadius();
            this.lbText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRadius1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.triangle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 28, 0, 28);
            this.panel1.Size = new System.Drawing.Size(6, 68);
            this.panel1.TabIndex = 0;
            // 
            // triangle1
            // 
            this.triangle1.BackColor = System.Drawing.Color.Transparent;
            this.triangle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangle1.Location = new System.Drawing.Point(0, 28);
            this.triangle1.Name = "triangle1";
            this.triangle1.rColor = System.Drawing.Color.Black;
            this.triangle1.Size = new System.Drawing.Size(6, 12);
            this.triangle1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelRadius1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.panel2.Size = new System.Drawing.Size(201, 68);
            this.panel2.TabIndex = 1;
            // 
            // panelRadius1
            // 
            this.panelRadius1.Controls.Add(this.lbText);
            this.panelRadius1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRadius1.Location = new System.Drawing.Point(0, 16);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Padding = new System.Windows.Forms.Padding(5, 4, 0, 0);
            this.panelRadius1.Radius = 5;
            this.panelRadius1.rColor = System.Drawing.Color.Black;
            this.panelRadius1.rSize = new System.Drawing.Size(0, 0);
            this.panelRadius1.Size = new System.Drawing.Size(201, 36);
            this.panelRadius1.TabIndex = 0;
            this.panelRadius1.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbText.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(5, 4);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(56, 24);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Home";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(207, 68);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelRadius1.ResumeLayout(false);
            this.panelRadius1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Triangle triangle1;
        private System.Windows.Forms.Panel panel2;
        private PanelRadius panelRadius1;
        private System.Windows.Forms.Label lbText;
    }
}
