using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class DBHelper
{
    private static string connString = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;

    public static bool TestConnection()
    {
        try { using (SqlConnection conn = new SqlConnection(connString)) { conn.Open(); Console.WriteLine("Connection OK"); return true; } }
        catch (Exception ex) { Console.WriteLine($"Connection failed: {ex.Message}"); return false; }
    }

    public static DataTable ExecuteProcedure(string procName, params SqlParameter[] parameters)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //Console.WriteLine($"Procedure {procName} returned {dt.Rows.Count} rows"); 
                        return dt;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"DB Error: {ex.Message}");
            throw;
        }
    }
}