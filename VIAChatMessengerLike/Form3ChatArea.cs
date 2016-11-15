using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Important
using InformationLibrary;
using LogicLibrary;

namespace VIAChatMessengerLike
{
    public partial class Form3ChatArea : Form
    {

        /// <summary>
        ///  Class userInformation adn Operations
        /// </summary>
        public UserInformations info = new UserInformations();
        public LogicOperations opr = new LogicOperations();
        public Form3ChatArea()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3ChatArea_Load(object sender, EventArgs e)
        {
            label1UserNameDisplay.Text = info.userName;
          
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
