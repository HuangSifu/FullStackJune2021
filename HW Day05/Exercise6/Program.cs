using System;
using System.Data.SqlClient;

namespace Exercise6
{
    class Program
    {
        public static void CreateCommand1(string MyconnectString)
        {
            SqlConnection conn = new SqlConnection(MyconnectString);
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static void CreateCommand2(string MyconnectString)
        {
            SqlConnection conn = new SqlConnection(MyconnectString);
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
