using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace DataBaseAccessLibray
{
    public class DBConnection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=desktop-36vt444\sqlexpress;Initial Catalog=chatfinalmessenger;Integrated Security=True");


        // Connection
        public SqlConnection getConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                // Connectíon works fine
                conn.Open();
            }

            return conn;
        }


        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getConnection();
            int rowsaffected = -1;

            // I get an error here
            rowsaffected = cmd.ExecuteNonQuery(); //
            conn.Close();
            return rowsaffected;
        }


        // Retriving value from dabase single on

        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = getConnection();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            conn.Close();
            return obj;
        }


        // Selecting Query using ExeReader
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getConnection();
            SqlDataReader sdReader;
            DataTable dataTable =  new DataTable();

            sdReader = cmd.ExecuteReader();
            dataTable.Load(sdReader);
            conn.Close();
            return dataTable;
        }
    }
}
