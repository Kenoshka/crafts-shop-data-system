using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovik.Classes;

namespace Kursovik.Tools
{
    static class UserDBHelper
    {
        public static User AuthCheck(string login, string pass)
        {
            User usr = null;

            try
            {
                using (SqlConnection con = new SqlConnection(DBConnect.connect))
                {
                    con.Open();
                    string query = "select * from UsersList where Login = @l and Password = @p";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@l", login);
                    cmd.Parameters.AddWithValue("@p", pass);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString());
                        usr = new User(
                            Convert.ToInt32(reader[0]),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            Convert.ToDouble(reader[4]));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
            return usr;
        }

        public static void updateFunds(int userId, double money)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DBConnect.connect))
                {
                    con.Open();
                    string query = "update UsersList set Balance = Balance + @sum where UserId = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@sum", money);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }

        public static void setLoginNpassword(int id, string login, string pass)
        {
                using (SqlConnection con = new SqlConnection(DBConnect.connect))
                {
                    con.Open();
                    string query = "exec UpdateLoginAndData @id, @login, @pass";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.ExecuteNonQuery();
                }
        }
    }
}
