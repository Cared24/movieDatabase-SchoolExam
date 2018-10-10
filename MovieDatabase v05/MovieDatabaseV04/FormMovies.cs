using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseV04
{
    public partial class FormMovies : Form
    {
        private MySQLDatabaseInterface mdi;
        private DataTable moviesDT;
        bool editMade = false;
        List<Movie> listMovies;

        /* ------------------------------------------------*/
        /* CONSTRUCTOR */
        /* ------------------------------------------------*/
        public FormMovies()
        {
            InitializeComponent();
        }

        public FormMovies(List<Movie> listMovies)
        {
            InitializeComponent();
            this.listMovies = listMovies; 
            dataGridViewMovies.DataSource = listMovies;
            dataGridViewMovies.AllowUserToAddRows = false;
            dataGridViewMovies.AllowUserToDeleteRows = false;
        }

        /* ------------------------------------------------*/
        /* BUTTONS*/
        /* ------------------------------------------------*/
      
        //BUTTON LOAD
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Database d = new Database();
            mdi = d.connect();
            mdi.open();
            moviesDT = mdi.getToDataTable("SELECT movies.movieId, movies.title, directors.name, movies.releaseDate, " +
                " movies.imdb, movies.poster, movies.description FROM directors, movies WHERE movies.directorId LIKE " +
                " directors.directorsId" );

            dataGridViewMovies.DataSource = moviesDT;
            this.dataGridViewMovies.Columns["poster"].Visible = false;
            this.dataGridViewMovies.Columns["description"].Visible = false;

            dataGridViewMovies.Columns[0].Width = 50;
            dataGridViewMovies.Columns[1].Width = 300;
            dataGridViewMovies.Columns[2].Width = 150;
            dataGridViewMovies.Columns[3].Width = 50;
            dataGridViewMovies.Columns[4].Width = 50;

            this.dataGridViewMovies.Columns["movieId"].HeaderText = "Movie ID";
            this.dataGridViewMovies.Columns["title"].HeaderText = "Movie Title";
            this.dataGridViewMovies.Columns["name"].HeaderText = "Director";
            this.dataGridViewMovies.Columns["releaseDate"].HeaderText = "Release Date";
            this.dataGridViewMovies.Columns["imdb"].HeaderText = "IMDB Score";

            buttonNew.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;

            dataGridViewMovies.ReadOnly = true;
            dataGridViewMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        //BUTTON EDIT
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //double click to edit
        }

  
        //BUTTON EXIT
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (editMade == true)
            {
                if (MessageBox.Show(
                    "There are unsaved data! Are you sure you want to quit?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mdi.close();
                    this.Close();
                }
            }
        }

        //BUTTON DELETE
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                 "Are you sure you want to delete the selected row?",
                 "Delete",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Asterisk
                 ) == DialogResult.Yes)
            {
                try
                {
                    int movieCode = Convert.ToInt32(dataGridViewMovies.SelectedRows[0].Cells[0].Value);
                    int index = listMovies.FindIndex(x => x.getMovieId() == movieCode);
                    listMovies.RemoveAt(index);
                    Database d = new Database();
                    MySQLDatabaseInterface mdi = d.connect();
                    mdi.open();
                    string query = "DELETE FROM movies WHERE movieId=" + movieCode;
                    mdi.executeDMQuery(query);
                    mdi.close();
                    index = dataGridViewMovies.SelectedRows[0].Index;
                    dataGridViewMovies.Rows.RemoveAt(index);
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        //BUTTON NEW
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();
            int newId = defineNewId();
            m.setMovieId(newId);
            FormEditMovie fem = new FormEditMovie(m);

            if (fem.ShowDialog() == DialogResult.OK)
            {
                m = fem.getEditedMovie();
                listMovies.Add(m);

                Database d = new Database();
                MySQLDatabaseInterface mdi = d.connect();
                mdi.makeConnectionToDatabase();
                mdi.open();

                string query = "INSERT INTO movies (movieId, title, directorId," +
                    " releaseDate, imdb, description)" +
                    " VALUES ('" + m.getMovieId() + "', " +
                    "'" + m.getTitle() + "', " +
                    "'" + m.getDirectorId() + "', " +
                    "'" + m.getReleaseDate() + "', " +
                    "'" + m.getImdb() + "', " +
                  
                    "'" + m.getDescription() + "' )";

                mdi.executeDMQuery(query);
                mdi.close();

                Database data = new Database();
                mdi = data.connect();
                mdi.open();
                moviesDT = mdi.getToDataTable("SELECT movies.movieId, movies.title, directors.name, movies.releaseDate, " +
                " movies.imdb, movies.poster, movies.description FROM directors, movies WHERE movies.directorId LIKE " +
                " directors.directorsId");
                dataGridViewMovies.DataSource = moviesDT;

                buttonNew.Enabled = true;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;


                dataGridViewMovies.ReadOnly = true;
                dataGridViewMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private int defineNewId()
        {
            int max = -1;
            foreach (Movie m in listMovies)
            {
                if (m.getMovieId() > max)
                    max = m.getMovieId();
            }
            return max + 1;
        }

        /* ------------------------------------------------*/
        /* CHANGES */
        /* ------------------------------------------------*/
        private void dataGridViewMovies_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridViewMovies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            editMade = true;
        }

        #region Event - Double Click
        private void dataGridViewMovies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMovies.SelectedRows[0].Index > -1)
            {
                int movieId = Convert.ToInt32(dataGridViewMovies.SelectedRows[0].Cells["movieId"].Value);

                Movie m = listMovies[dataGridViewMovies.SelectedRows[0].Index];
                dataGridViewMovies.Columns[0].Width = 50;
                FormEditMovie fem = new FormEditMovie(m);

                if (fem.ShowDialog() == DialogResult.OK)
                {
                    Movie editedMovie = fem.getEditedMovie();

                    string query = "";

                    query += "UPDATE movies ";
                    query += "SET title='" + editedMovie.getTitle() +
                        "', directorId='" + editedMovie.getDirectorId() +
                        "', releaseDate='" + editedMovie.getReleaseDate() +
                        "', imdb='" + editedMovie.getImdb() +
                        "', description='" + editedMovie.getDescription() +
                        "', poster='" + editedMovie.getPoster();
                    query += "'WHERE movieId='" + editedMovie.getMovieId() + "'";

                    mdi.executeDMQuery(query);
                    MessageBox.Show("Edit Successful:" + editedMovie.ToString());


                    //LOAD AGAIN
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
                }
            }
        }
        #endregion

        private void dataGridViewMovies_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewMovies.SelectedRows.Count > 0)
            {
                int index = dataGridViewMovies.SelectedRows[0].Index;
                labelTitleOfMovie.Text = dataGridViewMovies.SelectedRows[0].Cells["title"].Value.ToString();
                textBoxDescription.Text = listMovies[index].getDescription();

            }
            
        }
    }
}

