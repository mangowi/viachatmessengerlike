using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationLibrary;
using LogicLibrary;

namespace VIAChatMessengerLike
{
    public partial class MainForm1OnStart : Form
    {

        /// <summary>
        /// 
        /// </summary>
        public UserInformations info = new UserInformations();

        public LogicOperations opr = new LogicOperations();
        DataTable dataTable = new DataTable();

        public string typeUser;

        public MainForm1OnStart()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            this.Hide();
            Form2CreateAccount form2CreateAccount = new Form2CreateAccount();
            form2CreateAccount.Show();
        }

        private void button1LoginSucess_Click(object sender, EventArgs e)
        {
            info.userName = textBox1UserName.Text;
            info.password = textBox2Password.Text;

            dataTable= opr.loginUser(info);
            if (dataTable.Rows.Count > 0)
            {


                typeUser = dataTable.Rows[0][3].ToString().Trim();
                if (typeUser=="A")
                {
                    this.Hide();
                    Form1AdminServer form1Admin = new Form1AdminServer();
                    form1Admin.Show();
                    MessageBox.Show(dataTable.Rows[0][1].ToString());
                   

                }
                else
                {
                    // Take to Chart
                    this.Hide();
                Form3ChatArea form3Chat = new Form3ChatArea();
                form3Chat.Show();
                
            }

            }   else
            {
                MessageBox.Show("User name not found in our database");
            }
        }

    }
}
