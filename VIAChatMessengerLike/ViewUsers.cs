using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;
using InformationLibrary;
namespace VIAChatMessengerLike
{
    public partial class ViewUsers : Form
    {
        public Operations operations = new Operations();
        public UserInformations userInformations = new UserInformations();
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataTable dataTable = new DataTable();
            dataTable = operations.viewAllUsers(userInformations);
            dataGridViewUsers.DataSource = dataTable;
        }
    }
}
