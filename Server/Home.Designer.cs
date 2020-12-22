
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRadius1 = new Server.PanelRadius();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelRadius2 = new Server.PanelRadius();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRadius1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelRadius2.SuspendLayout();
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
            this.panelRadius1.Controls.Add(this.chart1);
            this.panelRadius1.Location = new System.Drawing.Point(668, 54);
            this.panelRadius1.Name = "panelRadius1";
            this.panelRadius1.Radius = 8;
            this.panelRadius1.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panelRadius1.rSize = new System.Drawing.Size(562, 310);
            this.panelRadius1.Size = new System.Drawing.Size(563, 311);
            this.panelRadius1.TabIndex = 7;
            this.panelRadius1.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.IsLabelAutoFit = false;
            chartArea7.AxisX.LabelStyle.Font = new System.Drawing.Font("Quicksand", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            chartArea7.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea7.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea7.AxisX.Title = "Tháng";
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea7.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea7.AxisY.LabelStyle.Font = new System.Drawing.Font("Quicksand", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            chartArea7.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea7.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            chartArea7.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea7.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea7.AxisY.TitleFont = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            chartArea7.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea7.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea7.BorderColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            chartArea7.Position.Auto = false;
            chartArea7.Position.Height = 90F;
            chartArea7.Position.Width = 94F;
            chartArea7.Position.X = 1F;
            chartArea7.Position.Y = 5F;
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.BackColor = System.Drawing.Color.Transparent;
            legend7.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            legend7.ForeColor = System.Drawing.Color.White;
            legend7.IsTextAutoFit = false;
            legend7.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend7.Name = "Legend1";
            legend7.TitleBackColor = System.Drawing.Color.Transparent;
            legend7.TitleFont = new System.Drawing.Font("Quicksand", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            legend7.TitleForeColor = System.Drawing.Color.White;
            legend7.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series7.BackSecondaryColor = System.Drawing.Color.Transparent;
            series7.BorderColor = System.Drawing.Color.White;
            series7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            series7.CustomProperties = "LabelStyle=Top";
            series7.Font = new System.Drawing.Font("Quicksand", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            series7.IsValueShownAsLabel = true;
            series7.IsXValueIndexed = true;
            series7.LabelForeColor = System.Drawing.Color.White;
            series7.Legend = "Legend1";
            series7.MarkerBorderWidth = 0;
            series7.Name = "Khách";
            series7.ShadowColor = System.Drawing.Color.Empty;
            series7.SmartLabelStyle.Enabled = false;
            series7.YValuesPerPoint = 6;
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(563, 311);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // panelRadius2
            // 
            this.panelRadius2.Controls.Add(this.label4);
            this.panelRadius2.Location = new System.Drawing.Point(144, 3);
            this.panelRadius2.Name = "panelRadius2";
            this.panelRadius2.Radius = 4;
            this.panelRadius2.rColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.panelRadius2.rSize = new System.Drawing.Size(128, 37);
            this.panelRadius2.Size = new System.Drawing.Size(129, 38);
            this.panelRadius2.TabIndex = 8;
            this.panelRadius2.TopLeft = new System.Drawing.Point(0, 0);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xuất báo cáo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1231, 738);
            this.Controls.Add(this.panelRadius2);
            this.Controls.Add(this.panelRadius1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelRadius1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelRadius2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PanelRadius panelRadius1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private PanelRadius panelRadius2;
        private System.Windows.Forms.Label label4;
    }
}