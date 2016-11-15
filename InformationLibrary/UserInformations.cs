using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///  Namespace Information Library that has the UserInformation and Message information
/// </summary>
namespace InformationLibrary
{
    /// <summary>
    ///  Class UserInformation
    /// </summary>
    public class UserInformations
    {

        // Variable used in the applicaiton, User and Message
        // For various database operation
        public string email { get; set; }
        public string password { get; set; }
        public string userName { get; set; }
        public virtual List<Message> Messages { get; set; }

    }


    /// <summary>
    /// Class Message
    /// </summary>
    public class Message

    {
        public int messageID { get; set; }
        public string messageBody { get; set; }
        public virtual UserInformations User { get; set; }

    }


}
