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
    public partial class Form1AdminServer : Form

    {
       
        public Form1AdminServer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displaying all users in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsers viewUsers = new ViewUsers();
            viewUsers.MdiParent = this;
            viewUsers.Show();
        }
    }
}
