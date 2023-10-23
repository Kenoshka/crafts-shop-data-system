using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovik.Classes;
using Kursovik.Tools;
using System.Data.SqlClient;

namespace Kursovik.Tools
{
    static class TovarsDatabaseHelper
    {
        public static List<Tovar> GetTovars()
        {
            List<Tovar> tovars = new List<Tovar>();

            try
            {
                using (SqlConnection con = new SqlConnection(DBConnect.connect))
                {
                    con.Open();
                    string query = "select * from Tovars";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tovars.Add(new Tovar(
                                Convert.ToInt32(reader[0]),
                                reader[1].ToString(),
                                reader[2].ToString(),
                                Convert.ToDouble(reader[3]),
                                Convert.ToInt32(reader[4]),
                                reader[5].ToString()
                                ));
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }

            return tovars;
        }

        public static List<Tovar> FilteredLoadFromDB(string categName)
        {
            List<Tovar> tovars = new List<Tovar>();

            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnect.connect))
                {
                    connection.Open();
                    string query = "select * from Tovars where Categ = @categ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@categ", categName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tovars.Add(new Tovar(
                                Convert.ToInt32(reader[0]),
                                reader[1].ToString(),
                                reader[2].ToString(),
                                Convert.ToDouble(reader[3]),
                                Convert.ToInt32(reader[4]),
                                reader[5].ToString()
                            ));
                        }
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка SQL: " + ex.Message);
            }
            return tovars;
        }

        public static List<string> getCategs()
        {
            List<string> categs = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnect.connect))
                {
                    connection.Open();
                    string query = $"select * from Categories";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            categs.Add(reader[0].ToString());
                        }
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка SQL: " + ex.Message);
            }
            return categs;
        }

        public static Tovar getTovarByID(int id)
        {
            Tovar tov = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnect.connect))
                {
                    connection.Open();
                    string query = "select * from Tovars where TovarId = @id"; ;
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tov = new Tovar(
                                Convert.ToInt32(reader[0]),
                                reader[1].ToString(),
                                reader[2].ToString(),
                                Convert.ToDouble(reader[3]),
                                Convert.ToInt32(reader[4]),
                                reader[5].ToString()
                            );
                            tov.picPath = reader[5].ToString();
                        }
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка SQL: " + ex.Message);
            }
            return tov;
        }

        public static void addTovarDB(string tovarName, string tovarCateg, double tovarPrice, int daysToProduce, string path)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnect.connect))
                {
                    connection.Open();
                    string query = "insert Tovars values (@name, @cat, @price, @days, @pic)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", tovarName);
                    cmd.Parameters.AddWithValue("@cat", tovarCateg);
                    cmd.Parameters.AddWithValue("@price", tovarPrice);
                    cmd.Parameters.AddWithValue("@days", daysToProduce);
                    cmd.Parameters.AddWithValue("@pic", path);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Товар добавлен.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка SQL: " + ex.Message);
            }
        }

        public static void deleteTovarDB(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnect.connect))
                {
                    connection.Open();
                    string query = "delete Tovars where TovarId = @id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Товар удалён.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка SQL: " + ex.Message);
            }
        }

        public static void editTovarDB(int id, string tovarName, string tovarCateg, double tovarPrice, int daysToProduce, string path)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnect.connect))
                {
                    connection.Open();
                    string query = "update Tovars set TovarName = @name where TovarId = @id " +
                        "update Tovars set Categ = @cat where TovarId = @id " +
                        "update Tovars set Price = @price where TovarId = @id " +
                        "update Tovars set DaysToProduce = @days where TovarId = @id " +
                        "update Tovars set pathToPicture = @path where TovarId = @id ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", tovarName);
                    cmd.Parameters.AddWithValue("@cat", tovarCateg);
                    cmd.Parameters.AddWithValue("@price", tovarPrice);
                    cmd.Parameters.AddWithValue("@days", daysToProduce);
                    cmd.Parameters.AddWithValue("@path", path);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Товар обновлён.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка SQL: " + ex.Message);
            }
        }
    }
}
