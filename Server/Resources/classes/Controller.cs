using MySql.Data.MySqlClient;
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
                return null;
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
                return null;
            }
        }
        public static List<User> getKhach()
        {
            try
            {
                List<User> ds = new List<User>();
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
                return null;
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
    }
}
