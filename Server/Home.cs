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
            setBlock4("12","2020");
            setBlock2("12", "2020");
            setBlock3("12","2020");
            setBlock1("12", "2020");
        }

        private void setBlock4(string thang , string nam)
        {
            List<string> ds = Controller.getTongDoanhThu(thang, nam);
            block4.Count = ds[0].ToString();
            block4.ThangTruoc = ds[1].ToString();
            if (block4.ThangTruoc != "0")
            {
                string temp = $"{(int.Parse(block4.Count) - int.Parse(block4.ThangTruoc))}";
                block4.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block4.ThangTruoc)) * 100;
                block4.Percent = $"{percent}";
            }

        }
        private void setBlock2(string thang, string nam)
        {
            List<string> ds = Controller.getHoaDonHuy(thang, nam);
            block2.Count = ds[0].ToString();
            block2.ThangTruoc = ds[1].ToString();
            if(block2.ThangTruoc != "0")
            {
                string temp = $"{(int.Parse(block2.Count) - int.Parse(block2.ThangTruoc))}";
                block2.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block2.ThangTruoc)) * 100;
                block2.Percent = $"{percent}";
            }
        }
        private void setBlock1(string thang , string nam)
        {
            List<string> ds = Controller.getKhach(thang, nam);
            block1.Count = ds[0].ToString();
            block1.ThangTruoc = ds[1].ToString();
            if (block1.ThangTruoc != "0")
            {
                string temp = $"{(int.Parse(block1.Count) - int.Parse(block1.ThangTruoc))}";
                block1.SoVoiThangTruoc = temp;
                float percent = ((float) int.Parse(temp) / int.Parse(block1.ThangTruoc)) * 100;
                block1.Percent = $"{percent}";
            }
        }
        private void setBlock3(string thang , string nam)
        {
            List<string> ds = Controller.getTongHoaDon(thang, nam);
            block3.Count = ds[0].ToString();
            block3.ThangTruoc = ds[1].ToString();
            if (block3.ThangTruoc != "0")
            {
                string temp = $"{(int.Parse(block3.Count) - int.Parse(block3.ThangTruoc))}";
                block3.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block3.ThangTruoc)) * 100;
                block3.Percent = $"{percent}";
            }
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