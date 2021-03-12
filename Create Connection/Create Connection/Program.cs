using System;
using System.Data.SqlClient;
namespace Create_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Server= WILSON; Database= Demodb; Integrated Security=True;");
                SqlCommand cm = new SqlCommand("select * from Customer", con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["Name"]+" "+sdr["Date"]+" "+sdr["ID"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went Wrong" + e);
            }

            finally
            {
                con.Close();
            }
        }
    }
}
