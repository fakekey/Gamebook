using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Server
{
    static class Controller
    {
        public static string quyenLogin;
        public static int checkLogin(string email, string password)
        {
            // case = 0 : sai quyen
            // case = 1: dung
            // case = -1: sai tai khoan / mat khau
            // case = -99: loi ket noi database
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * from account where Email = @email and Password = @pass";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add(new MySqlParameter("@email", email));
                cmd.Parameters.Add(new MySqlParameter("@pass", WinAPI.CreateMD5(password)));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                int count_acc = int.Parse(dt.Rows.Count.ToString());
                if (count_acc == 0)
                {
                    return -1;
                }
                else if (count_acc == 1)
                {
                    quyenLogin = dt.Rows[0].ItemArray[2].ToString();
                    if (dt.Rows[0].ItemArray[2].ToString() == "1" || dt.Rows[0].ItemArray[2].ToString() == "2") return 1;
                    else return 0;
                }
            }
            catch
            {
                return -99;
            }
            return -99;
        }
        public static int checkEmail(string email)
        {
            // case -1: khong co tai khoan
            // case 1: dung tai khoan
            // case -99: loi he thong
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select Count(*) from account where Email = @email";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add(new MySqlParameter("@email", email));
                int rs = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();
                if (rs == 1) return 1;
                else if (rs != 1)
                {
                    return -1;
                }

            }
            catch
            {
                return -99;
            }
            return -99;
        }

        public static int changePassword(string email, string pass)
        {
            // case 1: thay doi thanh cong
            // case -1: thay doi khong thanh cong
            // case -99: loi ket noi
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "UPDATE account Set `Password` = @pass Where `Email` = @email";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add(new MySqlParameter("@email", email));
                cmd.Parameters.Add(new MySqlParameter("@pass", WinAPI.CreateMD5(pass)));
                int rs = cmd.ExecuteNonQuery();
                if (rs == 1) return 1;
                else
                    return -1;
            }
            catch
            {
                return -99;
            }
        }

        public static List<User> getNhanVien()
        {
            List<User> dsnv = new List<User>();
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From usernv where `Ten quyen`='Nhân Viên'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string Email = reader.GetString(0);
                    string Ten = reader.GetString(1);
                    string quyen = reader.GetString(2);
                    User nv = new User(Email, quyen, Ten);
                    dsnv.Add(nv);
                }
                return dsnv;
            }
            catch
            {
                return dsnv;
            }

        }
        public static List<User> getAdmin()
        {
            List<User> ds = new List<User>();
            try
            {

                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From usernv where `Ten quyen`='Admin'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string Email = reader.GetString(0);
                    string Ten = reader.GetString(1);
                    string quyen = reader.GetString(2);
                    User nv = new User(Email, quyen, Ten);
                    ds.Add(nv);
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }
        public static List<User> getKhach()
        {
            List<User> ds = new List<User>();
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From userkhach";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string Email = reader.GetString(0);
                    string Ten = reader.GetString(1);
                    string quyen = reader.GetString(2);
                    User nv = new User(Email, quyen, Ten);
                    ds.Add(nv);
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }
        public static void XoaNV(string email)
        {
            MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("xoanv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("A", email));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void XoaKhach(string email)
        {
            string makh = "";
            List<string> hd = new List<string>();
            MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
            // lay ra makh
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT MAKH from `khach hang` WHERE `khach hang`.Email = @email ", con);
            cmd.Parameters.Add(new MySqlParameter("@email", email));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                makh = reader.GetString(0);
            }
            con.Close();
            // lay ra mahd
            con.Open();
            cmd = new MySqlCommand("SELECT MAHD from `hoa don` WHERE `hoa don`.MAKH = @makh ", con);
            cmd.Parameters.Add(new MySqlParameter("@makh", makh));
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string x = reader.GetString(0);
                hd.Add(x);
            }
            con.Close();
            // xoa chi tiet hoa don
            foreach (string item in hd)
            {
                con.Open();
                cmd = new MySqlCommand("DELETE from `chi tiet hoa don` WHERE `chi tiet hoa don`.MAHD ='" + item + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            // xoa hoa don
            con.Open();
            cmd = new MySqlCommand("DELETE from `hoa don` WHERE `hoa don`.MAKH= '" + makh + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            // xoa khach hang 
            con.Open();
            cmd = new MySqlCommand("DELETE from `khach hang` WHERE `khach hang`.Email = '" + email + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            // xoa account 
            con.Open();
            cmd = new MySqlCommand("DELETE from account WHERE account.Email ='" + email + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int ThemUser(string email, string pass, string quyen, string hoten)
        {   // case 1: thanh cong
            // case 0: trung tai khoan
            // case -99: loi ket noi
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select Count(*) from account where Email = @email";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add(new MySqlParameter("@email", email));
                int rs = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();
                if (rs == 1)
                {
                    return 0;
                }
                if (quyen == "Khách Hàng")
                {
                        con.Open();
                        cmd = new MySqlCommand("INSERT INTO account(`Email`,`Password`,`ID_quyen`) VALUES ( @email, @pass,'3')", con);
                        cmd.Parameters.Add(new MySqlParameter("@pass", WinAPI.CreateMD5(pass)));
                        cmd.Parameters.Add(new MySqlParameter("@email", email));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        cmd = new MySqlCommand("INSERT INTO `khach hang`(`Email`, `Họ Tên`) VALUES (@email,@name);", con);
                        cmd.Parameters.Add(new MySqlParameter("@name", hoten));
                        cmd.Parameters.Add(new MySqlParameter("@email", email));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        return 1;
                }
                if(quyen == "Nhân Viên")
                {
                    con.Open();
                    cmd = new MySqlCommand("INSERT INTO account(`Email`,`Password`,`ID_quyen`) VALUES ( @email, @pass,'2')", con);
                    cmd.Parameters.Add(new MySqlParameter("@pass", WinAPI.CreateMD5(pass)));
                    cmd.Parameters.Add(new MySqlParameter("@email", email));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if(quyen == "Admin")
                {
                    con.Open();
                    cmd = new MySqlCommand("INSERT INTO account(`Email`,`Password`,`ID_quyen`) VALUES ( @email, @pass,'1')", con);
                    cmd.Parameters.Add(new MySqlParameter("@pass", WinAPI.CreateMD5(pass)));
                    cmd.Parameters.Add(new MySqlParameter("@email", email));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Open();
                cmd = new MySqlCommand("INSERT INTO `nhan vien`(`Email`, `Họ Tên`) VALUES (@email,@name);", con);
                cmd.Parameters.Add(new MySqlParameter("@name", hoten));
                cmd.Parameters.Add(new MySqlParameter("@email", email));
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;

            }
            catch
            {
                return -99;
            }
        }
        public static int SuaNV(string email, string hoten , string quyen)
        {
            // case 1: thanh cong
            // case -99: loi 
            try
            {
                if(quyen == "Khách Hàng")
                {

                    MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `khach hang` SET `khach hang`.`Họ Tên` = @hoten WHERE `khach hang`.Email = @email", con);
                    cmd.Parameters.Add(new MySqlParameter("@hoten", hoten ));
                    cmd.Parameters.Add(new MySqlParameter("@email", email));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `nhan vien` SET `nhan vien`.`Họ Tên` = @hoten WHERE `nhan vien`.Email = @email", con);
                    cmd.Parameters.Add(new MySqlParameter("@hoten", hoten));
                    cmd.Parameters.Add(new MySqlParameter("@email", email));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                
            }
            catch
            {
                return -99;
            }
        }
        public static List<Product> getSpAll()
        {
            List<Product> ds = new List<Product>();
            try
            {

                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From spAll";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt16(0);
                    string title = reader.GetString(1);
                    string cate = reader.GetString(2);
                    string version = reader.GetString(3);
                    string price = reader.GetValue(4).ToString();
                    string date = reader.GetString(5);
                    string img = reader.GetString(6);
                    ds.Add(new Product(id, title, cate, version, float.Parse(price), date, img));
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }
        public static List<Product> getSpAAA()
        {
            List<Product> ds = new List<Product>();
            try
            {

                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From spAAA";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt16(0);
                    string title = reader.GetString(1);
                    string cate = reader.GetString(2);
                    string version = reader.GetString(3);
                    string price = reader.GetValue(4).ToString();
                    string date = reader.GetString(5);
                    string img = reader.GetString(6);
                    ds.Add(new Product(id, title, cate, version, float.Parse(price), date, img));
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }
        public static List<Product> getSpIndie()
        {
            List<Product> ds = new List<Product>();
            try
            {

                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From spIndie";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt16(0);
                    string title = reader.GetString(1);
                    string cate = reader.GetString(2);
                    string version = reader.GetString(3);
                    string price = reader.GetValue(4).ToString();
                    string date = reader.GetString(5);
                    string img = reader.GetString(6);
                    ds.Add(new Product(id, title, cate, version, float.Parse(price), date, img));
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public static void XoaSP(int ID)
        {
            MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"DELETE from `chi tiet hoa don` WHERE `ID_sp` = '{ID}' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd = new MySqlCommand($"DELETE from `san pham` WHERE `ID_sp` = '{ID}' ", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public static int ThemSP(Product sp)
        {   
            // return 1: thanh cong
            //return -99: loi
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `san pham`(`title`, `category`, `version`, `price`, `date release`,`img_path`) VALUES ('{sp.Title}','{sp.Cate}','{sp.Version}','{sp.Price}','{sp.Daterelease}','{sp.Img}')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch
            {
                return -99;
            }
        }
        public static int SuaSP(Product sp)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `san pham` SET `title` = '{sp.Title}' , `category` = '{sp.Cate}', `version` = '{sp.Version}', `price` = '{sp.Price}', `date release` = '{sp.Daterelease}', `img_path` ='{sp.Img}' WHERE `ID_sp` = '{sp.Id_sp}'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch
            {
                return -99;
            }
        }

        public static void InDanhSachSP(List<Product> ds)
        {
            // khoi tao excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet ws = workbook.Sheets["Sheet1"];
            ws.Name = "Danh Sach San Pham";
            ws = workbook.ActiveSheet;
            app.Visible = true;
            // fill data
            ws.Cells[1, 4] = "Bảng Danh Sách Sản Phẩm Tổng Hợp ";
            ws.Cells[3, 2] = $"Hà Nội,ngày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year}";
            ws.Cells[4, 2] = "Người tạo: Admin";
            // bang
            ws.Cells[6, 1] = "STT";
            ws.Cells[6, 2] = "Mã SP";
            ws.Cells[6, 3] = "Tên SP";
            ws.Cells[6, 4] = "NSX";
            ws.Cells[6, 5] = "Phiên Bản";
            ws.Cells[6, 6] = "NPH";
            ws.Cells[6, 7] = "Giá";

            for (int i = 0; i < ds.Count; i++)
            {
                ws.Cells[i + 7, 1] = i + 1;
                ws.Cells[i + 7, 2] = ds[i].Id_sp;
                ws.Cells[i + 7, 3] = ds[i].Title;
                ws.Cells[i + 7, 4] = ds[i].Cate;
                ws.Cells[i + 7, 5] = ds[i].Version;
                ws.Cells[i + 7, 6] = ds[i].Daterelease;
                ws.Cells[i + 7, 7] = ds[i].Price + "$";
            }
            int cell = ds.Count + 8;
            ws.Cells[cell, 6] = "Chữ Ký Nhân Viên";


            // dinh dang
            ws.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            ws.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            ws.PageSetup.LeftMargin = 50;
            ws.PageSetup.RightMargin = 50;
            ws.PageSetup.TopMargin = 50;
            ws.PageSetup.BottomMargin = 50;

            ws.Range["A1"].ColumnWidth = 5.13;
            ws.Range["B1"].ColumnWidth = 7.5;
            ws.Range["C1"].ColumnWidth = 22.25;
            ws.Range["D1"].ColumnWidth = 7.75;
            ws.Range["E1"].ColumnWidth = 10.63;
            ws.Range["E1", "E100"].NumberFormat = "@";
            ws.Range["F1"].ColumnWidth = 13.25;
            ws.Range["F1", "F100"].NumberFormat = "dd/MM/yyyy";
            ws.Range["G1"].ColumnWidth = 8.38;
            ws.Range["A1", "G100"].Font.Name = "Times New Roman";
            ws.Range["A1", "G100"].Font.Size = 14;
            ws.Range["A7", "G" + (ds.Count + 6)].RowHeight = 30;
            ws.Range["A7", "G" + (ds.Count + 6)].Font.Size = 12;
            ws.Range["A7", "G" + (ds.Count + 6)].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            ws.Range["A7", "G" + (ds.Count + 6)].HorizontalAlignment = 3;
            ws.Range["C1", "C100"].WrapText = true;
            ws.Range["C1", "C100"].HorizontalAlignment = 2;
            ws.Range["A1", "G1"].MergeCells = true;
            ws.Range["A1", "G1"].Font.Bold = true;
            ws.Range["A1", "G1"].HorizontalAlignment = 3;
            ws.Range["A6", "G6"].Font.Bold = true;
            ws.Range["A6", "G6"].HorizontalAlignment = 3;
            ws.Range["A6", "G" + (ds.Count + 6)].Borders.LineStyle = 1;
            ws.Range["A" + cell, "E" + cell].Font.Size = 14;
            ws.Range["E" + cell].Font.Bold = true;
        }
    }
}
