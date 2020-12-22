using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class Home : Form
    {
        private int monthNowSelected;
        private int yearNowSelected;
        public Home()
        {
            InitializeComponent();
            block1 = new Block() { LabelTitle = "Khách mua hàng", Location = new Point(6, 54) };
            block2 = new Block() { LabelTitle = "Đơn bị hủy", Location = new Point(6, 384) };
            block3 = new Block() { LabelTitle = "Đơn đặt hàng", Location = new Point(336, 54) };
            block4 = new Block() { LabelTitle = "Doanh thu tháng", Location = new Point(336, 384) };
            this.Controls.Add(block1);
            this.Controls.Add(block2);
            this.Controls.Add(block3);
            this.Controls.Add(block4);
            setBlock4(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
            setBlock2(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
            setBlock3(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
            setBlock1(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
            monthNowSelected = DateTime.Now.Month;
            yearNowSelected = DateTime.Now.Year;
        }

        private void setBlock4(string thang, string nam)
        {
            List<string> ds = Controller.getTongDoanhThu(thang, nam);
            block4.Count = ds[0].ToString();
            block4.ThangTruoc = ds[1].ToString();
            if (block4.ThangTruoc != "0")
            {
                string temp = $"{(float.Parse(block4.Count) - float.Parse(block4.ThangTruoc))}";
                block4.SoVoiThangTruoc = temp;
                float percent = (float.Parse(temp) / float.Parse(block4.ThangTruoc)) * 100;
                block4.Percent = $"{percent}";
                if (float.Parse(temp) > 0)
                {
                    block4.isTang = true;
                }
                else
                {
                    block4.isTang = false;
                }
            }
            else
            {
                string temp = $"{(float.Parse(block4.Count) - float.Parse(block4.ThangTruoc))}";
                block4.SoVoiThangTruoc = temp;
                float percent = (float.Parse(temp) / float.Parse(block4.ThangTruoc)) * 100;
                block4.Percent = $"{percent}";
                if (float.Parse(temp) > 0)
                {
                    block4.isTang = true;
                }
                else
                {
                    block4.isTang = false;
                }
            }
        }
        private void setBlock2(string thang, string nam)
        {
            List<string> ds = Controller.getHoaDonHuy(thang, nam);
            block2.Count = ds[0].ToString();
            block2.ThangTruoc = ds[1].ToString();
            if (block2.ThangTruoc != "0")
            {
                string temp = $"{(int.Parse(block2.Count) - int.Parse(block2.ThangTruoc))}";
                block2.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block2.ThangTruoc)) * 100;
                block2.Percent = $"{percent}";
                if (float.Parse(temp) > 0)
                {
                    block2.isTang = true;
                }
                else
                {
                    block2.isTang = false;
                }
            }
            else
            {
                string temp = $"{(int.Parse(block2.Count) - int.Parse(block2.ThangTruoc))}";
                block2.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block2.ThangTruoc)) * 100;
                block2.Percent = $"{percent}";
                if (float.Parse(temp) > 0)
                {
                    block2.isTang = true;
                }
                else
                {
                    block2.isTang = false;
                }
            }
        }
        private void setBlock1(string thang, string nam)
        {
            List<string> ds = Controller.getKhach(thang, nam);
            block1.Count = ds[0].ToString();
            block1.ThangTruoc = ds[1].ToString();
            if (block1.ThangTruoc != "0")
            {
                string temp = $"{(int.Parse(block1.Count) - int.Parse(block1.ThangTruoc))}";
                block1.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block1.ThangTruoc)) * 100;
                block1.Percent = $"{percent}";
                if (float.Parse(temp) > 0)
                {
                    block1.isTang = true;
                }
                else
                {
                    block1.isTang = false;
                }
            }
            else
            {
                string temp = $"{(int.Parse(block1.Count) - int.Parse(block1.ThangTruoc))}";
                block1.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block1.ThangTruoc)) * 100;
                block1.Percent = $"{percent}";
                if (float.Parse(temp) > 0)
                {
                    block1.isTang = true;
                }
                else
                {
                    block1.isTang = false;
                }
            }
        }
        private void setBlock3(string thang, string nam)
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
                if (float.Parse(temp) > 0)
                {
                    block3.isTang = true;
                }
                else
                {
                    block3.isTang = false;
                }
            }
            else
            {
                string temp = $"{(int.Parse(block3.Count) - int.Parse(block3.ThangTruoc))}";
                block3.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block3.ThangTruoc)) * 100;
                block3.Percent = $"{percent}";
                if (float.Parse(temp) > 0)
                {
                    block3.isTang = true;
                }
                else
                {
                    block3.isTang = false;
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            FillChart();
        }
        private void FillChart()
        {
            int monthtemp1 = (monthNowSelected - 2) % 12;
            int monthtemp2 = (monthNowSelected - 1) % 12;
            int monthtemp3 = monthNowSelected % 12;
            int monthtemp4 = (monthNowSelected + 1) % 12;
            int monthtemp5 = (monthNowSelected + 2) % 12;
            if (monthtemp1 == 0)
            {
                monthtemp1 = 12;
            }
            if (monthtemp2 == 0)
            {
                monthtemp2 = 12;
            }
            if (monthtemp3 == 0)
            {
                monthtemp3 = 12;
            }
            if (monthtemp4 == 0)
            {
                monthtemp4 = 12;
            }
            if (monthtemp5 == 0)
            {
                monthtemp5 = 12;
            }
            //Series là cột dữ liệu, Point.AddXY để thêm vào biểu đồ hoành độ vs tung độ bn thôi
            chart1.Series["Khách"].Points.AddXY(monthtemp1, 55);
            chart1.Series["Khách"].Points.AddXY(monthtemp2, 40);
            chart1.Series["Khách"].Points.AddXY(monthtemp3, 100);
            chart1.Series["Khách"].Points.AddXY(monthtemp4, 75);
            chart1.Series["Khách"].Points.AddXY(monthtemp5, 90);
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp1, 70);
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp2, 100);
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp3, 90);
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp4, 76);
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp5, 92);
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp1, 3);
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp2, 5);
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp3, 2);
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp4, 1);
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp5, 7);
        }
        public void ReSize()
        {
            if (this.Width == 1231)
            {
                panelRadius1.Size = new Size(563, 311);
                panelRadius1.rSize = new Size(562, 310);
                panelRadius1.Refresh();
            }
            else
            {
                panelRadius1.Size = new Size(1115, 311);
                panelRadius1.rSize = new Size(1114, 310);
                panelRadius1.Refresh();
            }
        }
        private Block block1;
        private Block block2;
        private Block block3;
        private Block block4;
    }
}