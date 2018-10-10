using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//SHOW: userId, Username, Password and if he has, then all the profile data: zipcode,
namespace MovieDatabaseV04
{
    public partial class FormUsers : Form
    {
        public List<User> listUsers;
        DataTable dataTable;

        /* ------------------------------------------------*/
        /* CONSTRUCTOR*/
        /* ------------------------------------------------*/
        public FormUsers()
        {
            InitializeComponent();
        }

        public FormUsers(List<User> listUsers)
        {
            this.listUsers = listUsers;
            InitializeComponent();

            listViewUsers.Columns.Add("User ID");
            listViewUsers.Columns.Add("Username");
            listViewUsers.Columns.Add("Password");
            listViewUsers.Columns.Add("E-mail");


            listViewUsers.Columns[0].Width = 60;
            listViewUsers.Columns[1].Width = 150;
            listViewUsers.Columns[2].Width = 100;
            listViewUsers.Columns[3].Width = 150;
            loadListViewUsers();

            listViewUsers.View = View.Details;
        }

        /* ------------------------------------------------*/
        /* EVENTS */
        /* ------------------------------------------------*/
        public void loadListViewUsers()
        {
            
            foreach (User u in listUsers)
            {
                ListViewItem dr =new ListViewItem(u.getUserId().ToString());
                dr.SubItems.Add(u.getUsername());
                dr.SubItems.Add(u.getPassword());
                dr.SubItems.Add(u.getEmail());
                listViewUsers.Items.Add(dr);
            }
            
        }
       


    }
}
