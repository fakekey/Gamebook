
namespace Server
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelRadius1 = new Server.PanelRadius();
            this.block4 = new Server.Resources.Controls.Block();
            this.block3 = new Server.Resources.Controls.Block();
            this.block2 = new Server.Resources.Controls.Block();
            this.block1 = new Server.Resources.Controls.Block();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trang chủ";
            // 
            // panelRadius1
            // 
            this.panelRadius1.Location = new System.Drawing.Point(667, 54);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Radius = 8;
            this.panelRadius1.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panelRadius1.rSize = new System.Drawing.Size(562, 310);
            this.panelRadius1.Size = new System.Drawing.Size(563, 311);
            this.panelRadius1.TabIndex = 6;
            this.panelRadius1.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // block4
            // 
            this.block4.Count = "0$";
            this.block4.LabelTitle = "Doanh thu tháng";
            this.block4.Location = new System.Drawing.Point(337, 381);
            this.block4.Name = "block4";
            this.block4.Percent = "0";
            this.block4.Size = new System.Drawing.Size(311, 311);
            this.block4.SoVoiThangTruoc = "+ 0$";
            this.block4.TabIndex = 5;
            this.block4.ThangTruoc = "0$";
            // 
            // block3
            // 
            this.block3.Count = "0";
            this.block3.LabelTitle = "Đơn đặt hàng";
            this.block3.Location = new System.Drawing.Point(337, 54);
            this.block3.Name = "block3";
            this.block3.Percent = "0";
            this.block3.Size = new System.Drawing.Size(311, 311);
            this.block3.SoVoiThangTruoc = "+ 0";
            this.block3.TabIndex = 4;
            this.block3.ThangTruoc = "0";
            // 
            // block2
            // 
            this.block2.Count = "0";
            this.block2.LabelTitle = "Đơn bị hủy";
            this.block2.Location = new System.Drawing.Point(6, 381);
            this.block2.Name = "block2";
            this.block2.Percent = "0";
            this.block2.Size = new System.Drawing.Size(311, 311);
            this.block2.SoVoiThangTruoc = "+ 0";
            this.block2.TabIndex = 3;
            this.block2.ThangTruoc = "0";
            // 
            // block1
            // 
            this.block1.Count = "0";
            this.block1.LabelTitle = "Khách hàng";
            this.block1.Location = new System.Drawing.Point(6, 54);
            this.block1.Name = "block1";
            this.block1.Percent = "0";
            this.block1.Size = new System.Drawing.Size(311, 311);
            this.block1.SoVoiThangTruoc = "+ 0";
            this.block1.TabIndex = 2;
            this.block1.ThangTruoc = "0";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1231, 738);
            this.Controls.Add(this.panelRadius1);
            this.Controls.Add(this.block4);
            this.Controls.Add(this.block3);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Resources.Controls.Block block1;
        private Resources.Controls.Block block2;
        private Resources.Controls.Block block3;
        private Resources.Controls.Block block4;
        private PanelRadius panelRadius1;
    }
}