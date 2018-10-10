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
    public partial class FormEditMovie : Form
    {
        private MySQLDatabaseInterface mdi;
        private DataTable moviesDT;
        Movie movie;

        /* ------------------------------------------------*/
        /* CONSTRUCTOR */
        /* ------------------------------------------------*/
        public FormEditMovie()
        {
            InitializeComponent();
        }

        public FormEditMovie(Movie m)
        {
            InitializeComponent();
            this.movie = m;
            showEditedMovieDatas();
        }


        /* ------------------------------------------------*/
        /* EVENTS */
        /* ------------------------------------------------*/
        public void showEditedMovieDatas()
        {
            labelMovieId.Text = Convert.ToString(movie.getMovieId());
            textBoxTitle.Text = Convert.ToString(movie.getTitle());
            textBoxDirector.Text = Convert.ToString(movie.getDirectorId());
            textBoxReleaseDate.Text = Convert.ToString(movie.getReleaseDate());
            textBoxImdb.Text = Convert.ToString(movie.getImdb());
            textBoxDescription.Text = Convert.ToString(movie.getDescription());
            
        }

 
        public Movie getEditedMovie()
        {
            return movie;
        }

        #region Data Format Checking
        private bool checkText(string s)
        {
            if (s == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkImdb(double d)
        {
            d = Convert.ToDouble(textBoxImdb.Text);
            if (d < 1 || d > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkReleaseDate(string s)
        {
            int r = Convert.ToInt32(textBoxReleaseDate.Text);
            if (s == string.Empty || r < 1920 || r > 2018)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        /* ------------------------------------------------*/
        /* BUTTONS */
        /* ------------------------------------------------*/
        private void buttonSave_Click(object sender, EventArgs e)
        {
            movie.setMovieId(Convert.ToInt32(labelMovieId.Text));
            movie.setTitle(textBoxTitle.Text);
            movie.setDirectorId(Convert.ToInt32(textBoxDirector.Text));
            movie.setReleaseDate(Convert.ToInt32(textBoxReleaseDate.Text));
            movie.setImdb(Convert.ToDouble(textBoxImdb.Text));
            movie.setDescription(textBoxDescription.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String userSelectedFilePath = ofd.FileName;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            /*
            Database d = new Database();
            mdi = d.connect();
            mdi.open();
            moviesDT = mdi.getToDataTable("SELECT * FROM movies");
            dataGridViewMovies.DataSource = moviesDT;

            buttonNew.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;

            dataGridViewMovies.ReadOnly = true;
            dataGridViewMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormEditMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
