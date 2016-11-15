using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Important
using InformationLibrary;
using LogicLibrary;

namespace VIAChatMessengerLike
{
    public partial class Form2CreateAccount : Form
    {
        // Should reference to the InformationLibray(User) and also the LogicLibray

        // Storage for IDENTITY values returned from database, information object
        public UserInformations info = new UserInformations();

        // I implement the 3 tier application so all this has been moved to Information
        //private string username;
        //private string parsedMessageID;
        //private string password;

       
        public Operations opr = new Operations();
        // Connetion string
        //private string connectionstring = VIAChatMessengerLike.Utility.GetConnectionString();

        public Form2CreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Create account
        private void button1CreateAccountAccess_Click(object sender, EventArgs e)
        {
          
            info.email = textBox2Email.Text;
            info.password = textBoxPassword.Text;
            info.userName = textBox1UserName.Text;

            int rows = opr.insertNewUserData(info);

            if (rows > 0)
            {
                MessageBox.Show("Data Served");
            }

           
        }

        private void label1UserName_Click(object sender, EventArgs e)
        {

        }

        private void button1BackToMenu(object sender, EventArgs e)
        {
            MainForm1OnStart form1OnStart = new MainForm1OnStart();
            form1OnStart.Show();
            this.Close();
        }

        private void Form2CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
