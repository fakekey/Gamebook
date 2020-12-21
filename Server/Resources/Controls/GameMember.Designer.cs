
namespace Server
{
    partial class GameMember
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
            this.panelRadius1 = new Server.PanelRadius();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRadius1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRadius1
            // 
            this.panelRadius1.Controls.Add(this.label2);
            this.panelRadius1.Controls.Add(this.label1);
            this.panelRadius1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelRadius1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRadius1.Location = new System.Drawing.Point(0, 0);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 0);
            this.panelRadius1.Radius = 3;
            this.panelRadius1.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.panelRadius1.rSize = new System.Drawing.Size(357, 39);
            this.panelRadius1.Size = new System.Drawing.Size(358, 40);
            this.panelRadius1.TabIndex = 0;
            this.panelRadius1.TopLeft = new System.Drawing.Point(0, 0);
            this.panelRadius1.Click += new System.EventHandler(this.panelRadius1_Click);
            this.panelRadius1.MouseEnter += new System.EventHandler(this.panelRadius1_MouseEnter);
            this.panelRadius1.MouseLeave += new System.EventHandler(this.panelRadius1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(323, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên game";
            // 
            // GameMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelRadius1);
            this.Name = "GameMember";
            this.Size = new System.Drawing.Size(358, 40);
            this.panelRadius1.ResumeLayout(false);
            this.panelRadius1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelRadius panelRadius1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
