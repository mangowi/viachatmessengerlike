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
    public partial class Form2CreateAccount : Form
    {
        public Form2CreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1BackToMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm1OnStart form1OnStart = new MainForm1OnStart();
            form1OnStart.Show();
            this.Close();
        }

        private void panel2Back_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1CreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void button1CreateAccountAccess_Click(object sender, EventArgs e)
        {
            Form3ChatArea form3ChatArea = new Form3ChatArea();
            form3ChatArea.Show();
            this.Close();
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
    }
}
