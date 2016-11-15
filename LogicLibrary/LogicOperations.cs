using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationLibrary;
using DataBaseAccessLibray;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;


/// <summary>
/// This class has all logic operation on what our database does
/// </summary>

namespace LogicLibrary
{

    
    public class LogicOperations
    {

        /// <summary>
        /// Connection to the databse and also the information user class
        /// </summary>
       public DBConnection db = new DBConnection();
        public  UserInformations userInfo = new UserInformations();

        /// <summary>
        /// Inserting value to databse
        /// We use stored procedure that is in sql server
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int insertNewUserData(UserInformations userInfo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure; // StoredProcedure is on the SQL Server
            cmd.CommandText = "spRegisterUserDefaultU";
            cmd.Parameters.AddWithValue("@email", userInfo.email);
            cmd.Parameters.AddWithValue("@password", userInfo.password);
            cmd.Parameters.AddWithValue("@userName", userInfo.userName);
            return db.ExeNonQuery(cmd);
        }


        /// <summary>
        /// Login user using the parameters
        /// </summary>
        /// <param name="userInfoinfo"></param>
        /// <returns></returns>

        public DataTable loginUser(UserInformations userInfo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetuserNameWithPassword"; 
            cmd.Parameters.AddWithValue("@userName", userInfo.userName);
            cmd.Parameters.AddWithValue("@password", userInfo.password);

            return db.ExeReader(cmd); //Better to use Scalar
        }


        /// <summary>
        ///  Viewing all users type U
        ///  shows only username, email and type of user
        /// </summary>
        /// <param name="userInformations"></param>
        /// <returns></returns>
        public DataTable viewAllUsers(UserInformations userInformations)
        {
          SqlCommand cmd = new SqlCommand();
            cmd.CommandType =CommandType.StoredProcedure;
            cmd.CommandText = "spSelectAllUsersU"; 
            return db.ExeReader(cmd);

        }
    }
}
