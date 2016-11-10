using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIAChatMessengerLike
{
    public partial class MainForm1OnStart : Form
    {
        public MainForm1OnStart()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2CreateAccount form2CreateAccount = new Form2CreateAccount();
            form2CreateAccount.Show();
        }
    }
}
