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
        /// <summary>
        ///  Class userInformation adn Operations
        /// </summary>
        public UserInformations info = new UserInformations();
         public LogicOperations opr = new LogicOperations();
       

        public Form2CreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Creatred account for the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1CreateAccountAccess_Click(object sender, EventArgs e)
        {
          
           


            if (textBox1UserName.Text.Trim().Equals(' '))
            {
                MessageBox.Show("Data username or password can not be black");
            }

            else
            {
                 info.email = textBox2Email.Text;
                info.password = textBoxPassword.Text;
                info.userName = textBox1UserName.Text;

                int rows = opr.insertNewUserData(info);

                if (rows > 0)
                {
                    MessageBox.Show("Data Served");
                    this.Close();
                    MainForm1OnStart form1OnStart = new MainForm1OnStart();
                    form1OnStart.Show();
                }
                else
                {
                    MessageBox.Show("User data not saved");
                }
            }
            
           
        }

        private void label1UserName_Click(object sender, EventArgs e)
        {

        }

        private void button1BackToMenu(object sender, EventArgs e)
        {
            this.Close();
            MainForm1OnStart form1OnStart = new MainForm1OnStart();
            form1OnStart.Show();
            this.Close();
        }

        private void Form2CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
