using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseV04
{
    public partial class FormMovieDatabaseProject : Form
    {
        private DataContainer datacontainer;

        /* ------------------------------------------------*/
        /* CONSTRUCTOR */
        /* ------------------------------------------------*/
        public FormMovieDatabaseProject()
        {
            InitializeComponent();
            this.Hide();
            FormLogin fl = new FormLogin();
            if (fl.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            this.Show();
            datacontainer = new DataContainer();
            datacontainer.uploadDataFromDatabase();
            uploadFormMovies();
            uploadFormUsers();
            uploadFormOrders();
        }

        /* ------------------------------------------------*/
        /* EVENTS */
        /* ------------------------------------------------*/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();


        }
        public void uploadFormMovies()
        {

            tabControlMovieDatabaseProject.SelectedIndex = 0;
            FormMovies formMovies = new FormMovies(datacontainer.getListMovies());

            formMovies.TopLevel = false;
            formMovies.Visible = true;
            formMovies.FormBorderStyle = FormBorderStyle.None;
            formMovies.Dock = DockStyle.Fill;
            formMovies.Parent = tabPageMovies;
        }
        #region upload Forms to Base Form
        public void uploadFormUsers()
        {
            tabControlMovieDatabaseProject.SelectedIndex = 1;
            FormUsers formUsers = new FormUsers(datacontainer.getListUsers());

            formUsers.TopLevel = false;
            formUsers.Visible = true;
            formUsers.FormBorderStyle = FormBorderStyle.None;
            formUsers.Dock = DockStyle.Fill;
            formUsers.Parent = tabPageUsers;
        }

        public void uploadFormOrders()
        {
            tabControlMovieDatabaseProject.SelectedIndex = 2;
            FormOrders formOrders = new FormOrders(datacontainer.getListOrders());

            formOrders.TopLevel = false;
            formOrders.Visible = true;
            formOrders.FormBorderStyle = FormBorderStyle.None;
            formOrders.Dock = DockStyle.Fill;
            formOrders.Parent = tabPageOrders;
        }
        #endregion

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAboutUs().ShowDialog();
        }
    }
}