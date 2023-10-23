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
    static class ZakazDBHandler
    {
        public static int getZakazId()
        {
            int id = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(DBConnect.connect))
                {
                    con.Open();
                    string query = "select dbo.newZakazId()";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader[0]);
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }

        public static void createZakaz(int id, List<TovarCheck> tc, int userId, double sum)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DBConnect.connect))
                {
                    con.Open();
                    string query = "exec createZakaz @id, @user, @sum, 'Баланс'; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@user", userId);
                    cmd.Parameters.AddWithValue("@sum", sum);
                    cmd.ExecuteNonQuery();
                    fillZakaz(id, tc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void fillZakaz(int id, List<TovarCheck> tc)
        {
            foreach (TovarCheck tov in tc)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(DBConnect.connect))
                    {
                        con.Open();
                        string zapros = "insert ZakazContent values (@id, @tovId, @amount, 1, @sum)";
                        SqlCommand command = new SqlCommand(zapros, con);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@tovId", tov.Id);
                        command.Parameters.AddWithValue("@amount", tov.Amount);
                        command.Parameters.AddWithValue("@sum", tov.Price);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }

/*                        foreach (TovarCheck tov in tc)
                    {
                        string zapros = "insert ZakazContent values (@id, @tovId, @amount, 1, @sum)";
    SqlCommand command = new SqlCommand(zapros, con);
    cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@tov", tov.Id);
                        cmd.Parameters.AddWithValue("@amount", tov.Amount);
                        cmd.Parameters.AddWithValue("@sum", tov.Price);
                        command.ExecuteNonQuery();
                    }*/
}
