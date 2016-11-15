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


        public UserInformations info = new UserInformations();

        public Operations opr = new Operations();
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
                    Form1AdminServer form1Admin = new Form1AdminServer();
                    form1Admin.Show();
                    MessageBox.Show(dataTable.Rows[0][1].ToString());
                    this.Hide();

                }
                else
                {
                    // Take to Chart
                Form3ChatArea form3Chat = new Form3ChatArea();
                form3Chat.Show();
                this.Close();
            }

            }
                
            else
            {
                MessageBox.Show("User name not found in our database");
            }
        }

    }
}
