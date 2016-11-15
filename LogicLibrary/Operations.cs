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


namespace LogicLibrary
{

    
    public class Operations
    {
       public DBConnection db = new DBConnection();
        public  UserInformations userInfo = new UserInformations();

        // Queries and db operation need for the Messenger
        public int insertNewUserData(UserInformations informations)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text; //CommandType.StoredProcedure
            cmd.CommandText = "INSERT INTO Users VALUES ('"+userInfo.email +"','"+userInfo.password+ "', '" + userInfo.userName+"', 'U')";

            return db.ExeNonQuery(cmd);
        }

        public DataTable loginUser(UserInformations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Users WHERE UserName = '" + userInfo.userName + "' AND PASSWORD='" +
                              userInfo.password + "'";

            return db.ExeReader(cmd);
        }

        public DataTable viewAllUsers(UserInformations userInformations)
        {
          SqlCommand cmd = new SqlCommand();
            cmd.CommandType =CommandType.Text;
            cmd.CommandText = "SELECT * FROM USERS WHERE USERTYPE = 'U'";
            return db.ExeReader(cmd);

        }
    }
}
