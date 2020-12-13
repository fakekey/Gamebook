using MySql.Data.MySqlClient;
using Server.Resources.Models;
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
    }
}
