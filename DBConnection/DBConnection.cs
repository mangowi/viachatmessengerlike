using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace DataBaseAccessLibray
{
    public class DBConnection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=desktop-36vt444\sqlexpress;Initial Catalog=chatfinalmessenger;Integrated Security=True");


        /// <summary>
        /// For getting connection
        /// </summary>
        /// <returns></returns>
        public SqlConnection getConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                // Connectíon works fine
                conn.Open();
            }

            return conn;
        }

        /// <summary>
        /// For inserting purpose it can also be used for update or delete
        /// </summary>
        /// <param name="cmd">
        /// Sql command using for preparing an SQL statement-StoredProcedure that be excute on SQL Server database
        /// </param>
        /// <returns></returns>
        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getConnection();
            int rowsaffected = -1;

            // I get an error here
            rowsaffected = cmd.ExecuteNonQuery(); //
            conn.Close();
            return rowsaffected;
        }


        /// <summary>
        /// Returning a single -scalar value
        /// If return total number of rows in a table
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = getConnection();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            conn.Close();
            return obj;
        }


        /// <summary>
        /// Returns more than a single value i.e number of rows of data
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>
        /// rows of data
        /// </returns>
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
