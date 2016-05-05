#r "System.Configuration"
#r "System.Data"

using System.Configuration;
using System.Data.SqlClient;

public static void Run(TimerInfo myTimer, TraceWriter log) 
{
    log.Verbose($"Function started at: {DateTime.Now}");
    
    using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ASPState"].ConnectionString))
    {
        try
        {
            // Open the connection         
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("DeleteExpiredSessions", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();
            log.Verbose($"SP executed at: {DateTime.Now}"); 

        }
        catch (SqlException ex)
        {
            log.Verbose($"SP error: {ex.Message}");
            // Add exception handling
        }
    }
}