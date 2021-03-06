﻿using MySql.Data.MySqlClient;
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
        public static List<Khach> getKhach2()
        {
            List<Khach> dsk = new List<Khach>();
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From `khach hang`";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MaKH = reader.GetString(0);
                    string Email = reader.GetString(1);
                    string HoTen = reader.GetString(2);
                    Khach nv = new Khach(MaKH, HoTen, Email);
                    dsk.Add(nv);
                }
                return dsk;
            }
            catch
            {
                return dsk;
            }
        }
        public static BillTemp getChitiettemp(string mahd)
        {
            string MaKH = "";
            string IDSanPham = "";
            string TenSP = "";
            MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
            con.Open();
            string query = $"Select * From `chitiethd` where MAHD ='{mahd}'";
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MaKH = reader.GetString(1);
                IDSanPham = reader.GetString(2);
                TenSP = reader.GetString(3);
            }
            BillTemp temp = new BillTemp(MaKH, IDSanPham, TenSP);
            return temp;
        }
        public static List<Game> getGames()
        {
            List<Game> dsk = new List<Game>();
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From `san pham`";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string IDGame = reader.GetString(0);
                    string TenGame = reader.GetString(1);
                    string DonGia = reader.GetString(4);
                    Game nv = new Game(IDGame, TenGame, DonGia);
                    dsk.Add(nv);
                }
                return dsk;
            }
            catch
            {
                return dsk;
            }
        }
        public static int getCountAllGame()
        {
            int n = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select Count(*) From `san pham`";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n = int.Parse(reader.GetString(0));
                }
                return n;
            }
            catch
            {
                return n;
            }
        }
        public static int getCountAAA()
        {
            int n = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select Count(*) From `san pham` where `category` = 'AAA'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n = int.Parse(reader.GetString(0));
                }
                return n;
            }
            catch
            {
                return n;
            }
        }
        public static int getCountIndie()
        {
            int n = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select Count(*) From `san pham` where `category` = 'Indie'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n = int.Parse(reader.GetString(0));
                }
                return n;
            }
            catch
            {
                return n;
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
                    cmd.Parameters.Add(new MySqlParameter("@pass", pass));
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
                if (quyen == "Nhân Viên")
                {
                    con.Open();
                    cmd = new MySqlCommand("INSERT INTO account(`Email`,`Password`,`ID_quyen`) VALUES ( @email, @pass,'2')", con);
                    cmd.Parameters.Add(new MySqlParameter("@pass", WinAPI.CreateMD5(pass)));
                    cmd.Parameters.Add(new MySqlParameter("@email", email));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (quyen == "Admin")
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
        public static int SuaNV(string email, string hoten, string quyen)
        {
            // case 1: thanh cong
            // case -99: loi 
            try
            {
                if (quyen == "Khách Hàng")
                {

                    MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `khach hang` SET `khach hang`.`Họ Tên` = @hoten WHERE `khach hang`.Email = @email", con);
                    cmd.Parameters.Add(new MySqlParameter("@hoten", hoten));
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

        public static List<Bill> GetBill()
        {
            List<Bill> ds = new List<Bill>();
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                string query = "Select * From vhoadon";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string _mahd = reader.GetString(0);
                    string _tenkhach = reader.GetString(1);
                    string _ngaymua = reader.GetString(2);
                    string _tongtien = reader.GetString(3);
                    string _matinhtrang = reader.GetString(4);
                    ds.Add(new Bill(_mahd, _tenkhach, _ngaymua, _tongtien, _matinhtrang));
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public static void HuyBill(string id)
        {
            MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"UPDATE `gamebookdata`.`hoa don` SET `ID_tinhtrang` = 3 WHERE `MAHD` = '{id}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void XoaBill(string id)
        {
            MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($" DELETE from `gamebookdata`.`chi tiet hoa don` WHERE `MAHD` = '{id}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd = new MySqlCommand($" DELETE from `gamebookdata`.`hoa don` WHERE `MAHD` = '{id}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SuaBill(string id, string tinhtrang)
        {
            MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"UPDATE `gamebookdata`.`hoa don` SET `ID_tinhtrang` = '{tinhtrang}' WHERE `MAHD` = '{id}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int CapNhatBill(string mahd, string makh, string id_sp, string gia, string date)
        {
            // 1: thanh cong
            // -99: loi he thong
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `gamebookdata`.`hoa don` SET `MAKH` = '{makh}', `Ngay Mua` = '{date}', `Tong Tien` = '{gia}' WHERE `MAHD` = {mahd}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                cmd = new MySqlCommand($"UPDATE `gamebookdata`.`chi tiet hoa don` SET `ID_sp` = '{id_sp}', `Don gia` = '{gia}' WHERE `MAHD` = {mahd}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch
            {
                return -99;
            }


        }
        public static int ThemBill(string id_sp, string id_khach, string gia, string ngay)
        {
            // 1: thanh cong
            // -99: loi he thong
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `gamebookdata`.`hoa don`(`MAKH`, `Ngay Mua` , `Tong Tien`) VALUES ('{id_khach}','{ngay}','{gia}')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                cmd = new MySqlCommand("select * from `hoa don`", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                string mahd = "";
                while (reader.Read())
                {
                    mahd = reader.GetString(0);
                }
                con.Close();
                con.Open();
                cmd = new MySqlCommand($"INSERT INTO `gamebookdata`.`chi tiet hoa don`(`MAHD`, `ID_sp`, `Don gia`) VALUES ('{mahd}','{id_sp}','{gia}')", con);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -99;
            }
        }

        public static List<string> getTongHoaDon(string thang, string nam)
        {
            List<string> ds = new List<string> { "0", "0" };
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(`hoa don`.MAHD) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = {thang} and YEAR(`hoa don`.`Ngay Mua`) = '{nam}'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        string rs = reader.GetString(0);
                        if (rs != null)
                        {
                            ds[0] = rs;

                        }
                    }
                }
                con.Close();
                con.Open();
                if (int.Parse(thang) - 1 == 0)
                {
                    cmd = new MySqlCommand($"SELECT COUNT(`hoa don`.MAHD) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = 12 and YEAR(`hoa don`.`Ngay Mua`) = {int.Parse(nam) - 1}", con);
                }
                else
                {
                    cmd = new MySqlCommand($"SELECT COUNT(`hoa don`.MAHD) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = {int.Parse(thang) - 1} and YEAR(`hoa don`.`Ngay Mua`) = {int.Parse(nam)}", con);
                }
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        string rs = reader.GetString(0);
                        if (rs != null)
                        {
                            ds[1] = rs;

                        }
                    }
                }
                con.Close();
                return ds;
            }
            catch
            {
                ds = new List<string> { "0", "0" };
                return ds;
            }
            
        }

        public static List<string> getHoaDonHuy(string thang, string nam)
        {
            List<string> ds = new List<string> { "0", "0" };
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(`hoa don`.MAHD) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = {thang} and YEAR(`hoa don`.`Ngay Mua`) = '{nam}' and `hoa don`.ID_tinhtrang = 3 ", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        string rs = reader.GetString(0);
                        if (rs != null)
                        {
                            ds[0] = rs;

                        }
                    }
                }
                con.Close();
                con.Open();
                if (int.Parse(thang) - 1 == 0)
                {
                    cmd = new MySqlCommand($"SELECT COUNT(`hoa don`.MAHD) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = 12 and YEAR(`hoa don`.`Ngay Mua`) = {int.Parse(nam) - 1} and `hoa don`.ID_tinhtrang = 3", con);
                }
                else
                {
                    cmd = new MySqlCommand($"SELECT COUNT(`hoa don`.MAHD) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = {int.Parse(thang) - 1} and YEAR(`hoa don`.`Ngay Mua`) = {int.Parse(nam)} and `hoa don`.ID_tinhtrang = 3", con);
                }
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        string rs = reader.GetString(0);
                        if (rs != null)
                        {
                            ds[1] = rs;

                        }
                    }
                }
                con.Close();
                return ds;
            }
            catch
            {
                ds = new List<string> { "0", "0" };
                return ds;
            }
           
        }

        public static List<string> getTongDoanhThu(string thang, string nam)
        {
            List<string> ds = new List<string> { "0", "0" };
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT Sum(`hoa don`.`Tong Tien`) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = {thang} and YEAR(`hoa don`.`Ngay Mua`) = '{nam}' and `hoa don`.ID_tinhtrang = 2 ", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        string rs = reader.GetString(0);
                        if (rs != null)
                        {
                            ds[0] = rs;

                        }
                    }
                }
                con.Close();
                con.Open();
                if (int.Parse(thang) - 1 == 0)
                {
                    cmd = new MySqlCommand($"SELECT Sum(`hoa don`.`Tong Tien`) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = 12 and YEAR(`hoa don`.`Ngay Mua`) = {int.Parse(nam) - 1} and `hoa don`.ID_tinhtrang = 2", con);
                }
                else
                {
                    cmd = new MySqlCommand($"SELECT Sum(`hoa don`.`Tong Tien`) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = {int.Parse(thang) - 1} and YEAR(`hoa don`.`Ngay Mua`) = {int.Parse(nam)} and `hoa don`.ID_tinhtrang = 2", con);
                }
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        string rs = reader.GetString(0);
                        if (rs != null)
                        {
                            ds[1] = rs;

                        }
                    }
                }
                con.Close();
                return ds;
            }
            catch
            {
                ds = new List<string> { "0", "0" };
                return ds;
            }
            
        }
        public static List<string> getKhachMua(string thang, string nam)
        {
            List<string> ds = new List<string> { "0", "0" };
            try
            {
                MySqlConnection con = new MySqlConnection(DBconfigs.ConnectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT count( DISTINCT `hoa don`.MAKH) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = {thang} and YEAR(`hoa don`.`Ngay Mua`) = '{nam}'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        string rs = reader.GetString(0);
                        if (rs != null)
                        {
                            ds[0] = rs;

                        }
                    }
                }
                con.Close();
                con.Open();
                if (int.Parse(thang) - 1 == 0)
                {
                    cmd = new MySqlCommand($"SELECT count( DISTINCT `hoa don`.MAKH) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = 12 and YEAR(`hoa don`.`Ngay Mua`) = {int.Parse(nam) - 1}", con);
                }
                else
                {
                    cmd = new MySqlCommand($"SELECT count( DISTINCT `hoa don`.MAKH) from `hoa don` WHERE MONTH(`hoa don`.`Ngay Mua`) = {int.Parse(thang) - 1} and YEAR(`hoa don`.`Ngay Mua`) = {int.Parse(nam)}", con);
                }
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        string rs = reader.GetString(0);
                        if (rs != null)
                        {
                            ds[1] = rs;

                        }
                    }
                }
                con.Close();
                return ds;
            }
            catch
            {
                ds = new List<string> { "0", "0" };
                return ds;
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

        public static void XuatBill(string mahd, string makh, string tenkh, string ten_sp, string gia, string ngaymua)
        {
            
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet ws = workbook.Sheets["Sheet1"];
            ws.Name = "Hoa Don";
            ws = workbook.ActiveSheet;
            app.Visible = true;
            ws.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            ws.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            ws.PageSetup.LeftMargin = 50;
            ws.PageSetup.RightMargin = 50;
            ws.PageSetup.TopMargin = 50;
            ws.PageSetup.BottomMargin = 50;

            ws.Range["A1"].ColumnWidth = 8.38;
            ws.Range["B1"].ColumnWidth = 8.38;
            ws.Range["C1"].ColumnWidth = 21.25;
            ws.Range["D1"].ColumnWidth = 11.75;
            ws.Range["E1"].ColumnWidth = 11.75;
            ws.Range["A10", "G10"].RowHeight = 35.25;
            ws.Range["A9", "G9"].Font.Bold = true;
            ws.Range["A9", "G9"].Font.Size = 14;
            ws.Range["A9", "G9"].HorizontalAlignment = 3;
            ws.Range["A10", "G10"].Font.Size = 12;
            ws.Range["A10", "G10"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            ws.Range["A10", "G10"].HorizontalAlignment = 3;
            ws.Range["B9", "E10"].Borders.LineStyle = 1;
            ws.Range["A1", "F1"].MergeCells = true;
            ws.Range["A1", "G1"].Font.Bold = true;
            ws.Range["A1", "G1"].HorizontalAlignment = 3;
            ws.Range["A1", "G1"].Font.Size = 16;

            ws.Cells[1, 5] = "HÓA ĐƠN MUA HÀNG ";
            ws.Cells[4, 3] = $"Mã Hóa Đơn: {mahd}";
            ws.Cells[5, 3] = $"Mã Khách Hàng: {makh}";
            ws.Cells[6, 3] = $"Họ Tên: {tenkh}";
            ws.Cells[7, 3] = $"Ngày Mua: {ngaymua}";
            ws.Cells[9, 2] = "STT";
            ws.Cells[9, 3] = "Tên Sản Phẩm";
            ws.Cells[9, 4] = "Giá";
            ws.Cells[9, 5] = "Tổng Tiền";
            ws.Cells[10, 2] = "1";
            ws.Cells[10, 3] = $"{ten_sp.ToUpper()}";
            ws.Range["C10"].WrapText = true;
            ws.Cells[10, 4] = $"{gia}$";
            ws.Cells[10, 5] = $"{gia}$";
            ws.Cells[14, 2] = "Người Mua Hàng";
            ws.Cells[14, 5] = "Nhân Viên Bán Hàng";
            ws.Cells[18, 2] = "Ký và ghi rõ họ tên";
            ws.Cells[18, 5] = "Ký và ghi rõ họ tên";
        }

        public static void InBaoCaoThang(string thang , string nam , Block tdt , Block thd , Block kh , Block hdh)
        {
            // tdt : tong doanh thu
            // thd: tong hoa don 
            // kh: khach hang
            // hdh: hoa don huy
            List<Block> dstc = new List<Block>();
            dstc.Add(kh);
            dstc.Add(thd);
            dstc.Add(hdh);
            dstc.Add(tdt);
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet ws = workbook.Sheets["Sheet1"];
            ws.Name = "Bao Cao";
            ws = workbook.ActiveSheet;
            app.Visible = true;
            ws.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            ws.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            ws.PageSetup.LeftMargin = 50;
            ws.PageSetup.RightMargin = 50;
            ws.PageSetup.TopMargin = 50;
            ws.PageSetup.BottomMargin = 50;

            ws.Range["A1"].ColumnWidth = 4.88;
            ws.Range["B1"].ColumnWidth = 11.63;
            ws.Range["C1"].ColumnWidth = 12.13;
            ws.Range["D1"].ColumnWidth = 13;
            ws.Range["E1"].ColumnWidth = 8.38;
            ws.Range["F1"].ColumnWidth = 13.38;
            ws.Range["G1"].ColumnWidth = 8.38;
            
            ws.Range["A1", "G1"].Font.Bold = true;
            ws.Range["A1", "G100"].Font.Size = 14;
            ws.Range["A3", "G7"].WrapText = true;
            ws.Range["A3", "G3"].RowHeight = 55;
            ws.Range["A3", "G7"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            ws.Range["A3", "G7"].HorizontalAlignment = 3;
            ws.Range["A3", "G7"].Borders.LineStyle = 1;
            ws.Range["A4", "G7"].RowHeight = 43.50;
            ws.Range["F1","F100"].NumberFormat = "@";
            ws.Cells[1, 3] = $@"Báo Cáo Doanh Số Thường Kì Tháng {thang}-{nam}";
            ws.Range["A1", "G1"].MergeCells = true;
            ws.Range["A1", "G1"].HorizontalAlignment = 3;

            ws.Cells[3, 1] = "STT";               
            ws.Cells[3, 2] = "Tiêu Chí Đánh Giá";
            ws.Cells[3, 3] = "Doanh Số Tháng Này";
            ws.Cells[3, 4] = "Doanh Số Tháng Trước";
            ws.Cells[3, 5] = "Đơn Vị Tính";
            ws.Cells[3, 6] = "So Với Tháng Trước";
            ws.Cells[3, 7] = "Tăng Trưởng";
            ws.Cells[4, 2] = "Khách Mua Hàng";
            ws.Cells[4, 5] = "Người";
            ws.Cells[5, 2] = "Đơn Đặt Hàng";
            ws.Cells[5, 5] = "Đơn";
            ws.Cells[6, 2] = "Đơn Bị Hủy";
            ws.Cells[6, 5] = "Đơn";
            ws.Cells[7, 2] = "Doanh Thu Tháng";
            ws.Cells[7, 5] = "$";
            for (int i = 1; i <= 4; i++)
            {
                ws.Cells[3 + i, 1] = i;
                ws.Cells[3 + i, 3] = dstc[i-1].Count;
                ws.Cells[3 + i, 4] = dstc[i-1].ThangTruoc;
                ws.Cells[3 + i, 6] = dstc[i - 1].SoVoiThangTruoc;
                ws.Cells[3 + i, 7] = dstc[i - 1].Percent;
            }


            ws.Cells[11, 6] = "Nhân Viên Tổng Hợp";
            ws.Cells[15, 6] = "Ký và ghi rõ họ tên";


        }
    }
}
