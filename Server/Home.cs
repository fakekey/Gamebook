﻿using System;
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
                block4.Percent = $"{Math.Round(percent, 2)}";
                if (float.Parse(temp) >= 0)
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
                block4.Percent = $"{Math.Round(percent, 2)}";
                if (float.Parse(temp) >= 0)
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
                block2.Percent = $"{Math.Round(percent, 2)}";
                if (float.Parse(temp) >= 0)
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
                block2.Percent = $"{Math.Round(percent, 2)}";
                if (float.Parse(temp) >= 0)
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
            List<string> ds = Controller.getKhachMua(thang, nam);
            block1.Count = ds[0].ToString();
            block1.ThangTruoc = ds[1].ToString();
            if (block1.ThangTruoc != "0")
            {
                string temp = $"{(int.Parse(block1.Count) - int.Parse(block1.ThangTruoc))}";
                block1.SoVoiThangTruoc = temp;
                float percent = ((float)int.Parse(temp) / int.Parse(block1.ThangTruoc)) * 100;
                block1.Percent = $"{Math.Round(percent, 2)}";
                if (float.Parse(temp) >= 0)
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
                block1.Percent = $"{Math.Round(percent, 2)}";
                if (float.Parse(temp) >= 0)
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
                block3.Percent = $"{Math.Round(percent, 2)}";
                if (float.Parse(temp) >= 0)
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
                block3.Percent = $"{Math.Round(percent, 2)}";
                if (float.Parse(temp) >= 0)
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
            timer1.Enabled = true;
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
            chart1.Series["Khách"].Points.AddXY(monthtemp1, int.Parse(Controller.getKhachMua(monthtemp1.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Khách"].Points.AddXY(monthtemp2, int.Parse(Controller.getKhachMua(monthtemp2.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Khách"].Points.AddXY(monthtemp3, int.Parse(Controller.getKhachMua(monthtemp3.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Khách"].Points.AddXY(monthtemp4, int.Parse(Controller.getKhachMua(monthtemp4.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Khách"].Points.AddXY(monthtemp5, int.Parse(Controller.getKhachMua(monthtemp5.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp1, int.Parse(Controller.getTongHoaDon(monthtemp1.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp2, int.Parse(Controller.getTongHoaDon(monthtemp2.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp3, int.Parse(Controller.getTongHoaDon(monthtemp3.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp4, int.Parse(Controller.getTongHoaDon(monthtemp4.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn đặt"].Points.AddXY(monthtemp5, int.Parse(Controller.getTongHoaDon(monthtemp5.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp1, int.Parse(Controller.getHoaDonHuy(monthtemp1.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp2, int.Parse(Controller.getHoaDonHuy(monthtemp2.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp3, int.Parse(Controller.getHoaDonHuy(monthtemp3.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp4, int.Parse(Controller.getHoaDonHuy(monthtemp4.ToString(), yearNowSelected.ToString())[0]));
            chart1.Series["Đơn hủy"].Points.AddXY(monthtemp5, int.Parse(Controller.getHoaDonHuy(monthtemp5.ToString(), yearNowSelected.ToString())[0]));
            chart2.Series["Tổng Doanh Thu"].Points.AddXY(monthtemp1, Math.Round(float.Parse(Controller.getTongDoanhThu(monthtemp1.ToString(), yearNowSelected.ToString())[0]), 2));
            chart2.Series["Tổng Doanh Thu"].Points.AddXY(monthtemp2, Math.Round(float.Parse(Controller.getTongDoanhThu(monthtemp2.ToString(), yearNowSelected.ToString())[0]), 2));
            chart2.Series["Tổng Doanh Thu"].Points.AddXY(monthtemp3, Math.Round(float.Parse(Controller.getTongDoanhThu(monthtemp3.ToString(), yearNowSelected.ToString())[0]), 2));
            chart2.Series["Tổng Doanh Thu"].Points.AddXY(monthtemp4, Math.Round(float.Parse(Controller.getTongDoanhThu(monthtemp4.ToString(), yearNowSelected.ToString())[0]), 2));
            chart2.Series["Tổng Doanh Thu"].Points.AddXY(monthtemp5, Math.Round(float.Parse(Controller.getTongDoanhThu(monthtemp5.ToString(), yearNowSelected.ToString())[0]), 2));
        }
        public void ReSize()
        {
            if (this.Width == 1231)
            {
                panelRadius1.Size = new Size(563, 311);
                panelRadius1.rSize = new Size(562, 310);
                panelRadius1.Refresh();
                panelRadius3.Size = new Size(563, 311);
                panelRadius3.rSize = new Size(562, 310);
                panelRadius3.Refresh();
            }
            else
            {
                panelRadius1.Size = new Size(1115, 311);
                panelRadius1.rSize = new Size(1114, 310);
                panelRadius1.Refresh();
                panelRadius3.Size = new Size(1115, 311);
                panelRadius3.rSize = new Size(1114, 310);
                panelRadius3.Refresh();
            }
        }
        private Block block1;
        private Block block2;
        private Block block3;
        private Block block4;

        private void reload(string thang, string nam)
        {
            setBlock1(thang, nam);
            setBlock2(thang, nam);
            setBlock3(thang, nam);
            setBlock4(thang, nam);
            monthNowSelected = int.Parse(thang);
            yearNowSelected = int.Parse(nam);
            chart1.Series["Khách"].Points.Clear();
            chart1.Series["Đơn đặt"].Points.Clear();
            chart1.Series["Đơn hủy"].Points.Clear();
            chart2.Series["Tổng Doanh Thu"].Points.Clear();
            FillChart();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            reload(dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Year.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            ReSize();
        }

        private void panelRadius4_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panelRadius4_MouseEnter(object sender, EventArgs e)
        {
            panelRadius4.rColor = Color.FromArgb(32, 34, 37);
            panelRadius4.Refresh();
        }

        private void panelRadius4_MouseLeave(object sender, EventArgs e)
        {
            panelRadius4.rColor = Color.FromArgb(41, 43, 47);
            panelRadius4.Refresh();
        }

        private void chart1_MouseEnter(object sender, EventArgs e)
        {
            panelRadius1.rColor = Color.FromArgb(32, 34, 37);
            panelRadius1.Refresh();
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {
            panelRadius1.rColor = Color.FromArgb(41, 43, 47);
            panelRadius1.Refresh();
        }

        private void chart2_MouseEnter(object sender, EventArgs e)
        {
            panelRadius3.rColor = Color.FromArgb(32, 34, 37);
            panelRadius3.Refresh();
        }

        private void chart2_MouseLeave(object sender, EventArgs e)
        {
            panelRadius3.rColor = Color.FromArgb(41, 43, 47);
            panelRadius3.Refresh();
        }
    }
}