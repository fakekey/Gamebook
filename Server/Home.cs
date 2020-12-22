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
            chart1.Series["Khách"].Points.AddXY("8", 55);
            chart1.Series["Khách"].Points.AddXY("9", 40);
            chart1.Series["Khách"].Points.AddXY("10", 100);
            chart1.Series["Khách"].Points.AddXY("11", 75);
            chart1.Series["Khách"].Points.AddXY("12", 90);
        }

        private Block block1;
        private Block block2;
        private Block block3;
        private Block block4;
    }
}