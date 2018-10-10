using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseV04
{
    public partial class FormLogin : Form
    {
        /* ------------------------------------------------*/
        /* CONSTRUCTOR*/
        /* ------------------------------------------------*/

        Check cs;
        public FormLogin()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;

        }

        /* ------------------------------------------------*/
        /* BUTTONS */
        /* ------------------------------------------------*/
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {

            Database d = new Database();
            MySQLDatabaseInterface mdi = d.connect();
            mdi.makeConnectionToDatabase();
            mdi.open();
            DataTable datatable;
            String query = " SELECT username, password,isAdmin FROM `users` WHERE isAdmin = true;";
            datatable = mdi.getToDataTable(query);

            foreach (DataRow row in datatable.Rows)
            {

                User u = new User(Convert.ToBoolean((row["isAdmin"])));

                foreach (DataRow row2 in datatable.Rows)
                {
                    if (row2["username"].ToString() == textBoxUsername.Text && (row2["password"].ToString() == textBoxPassword.Text))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                       MessageBox.Show(
                       "Wrong username or password!",
                       "Wrong Data!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        
                    }
                }
            }
            
            Check cs = new Check();
            if (!cs.checkNameIsNoEmpty(textBoxUsername.Text))
            {
                errorProviderLoginUser.SetError(textBoxUsername, "The username can't be empty!");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (!cs.checkPasswordInNotEmpty(textBoxPassword.Text))
            {
                errorProviderLoginPassword.SetError(textBoxPassword,"The password can't be empty!");
                this.DialogResult = DialogResult.None;
                return;
            }
        }
    }
}

