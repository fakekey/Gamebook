using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            FillChart1();
        }
        private void FillChart1()
        {
            chart1.Series["Khách"].Points.AddXY("8", 55);
            chart1.Series["Khách"].Points.AddXY("9", 40);
            chart1.Series["Khách"].Points.AddXY("10", 100);
            chart1.Series["Khách"].Points.AddXY("11", 75);
            chart1.Series["Khách"].Points.AddXY("12", 90);
        }
    }
}