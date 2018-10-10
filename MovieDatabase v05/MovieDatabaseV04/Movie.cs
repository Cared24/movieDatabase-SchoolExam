using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseV04
{
    public class Movie
    {
        private int movieId;
        private string title;
        private int directorId;
        private int releaseDate;
        private double imdb;
        private string description;
        private Image poster;
        

        /* ------------------------------------------------*/
        /* CONSTRUCTOR */
        /* ------------------------------------------------*/
        public Movie()
        {

        }

        public Movie(int movieId, string title, int director, int releaseDate, double imdb, string description, MemoryStream poster)
        {
            this.movieId = movieId;
            this.title = title;
            this.directorId = director;
            this.releaseDate = releaseDate;
            this.imdb = imdb;
            this.description = description;
            this.poster =Image.FromStream(poster);
        }

        /* ------------------------------------------------*/
        /* EVENTS */
        /* ------------------------------------------------*/
       
        #region Setter
        public void setMovieId(int movieId)
        {
            this.movieId = movieId;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setDirectorId(int directorId)
        {
            this.directorId = directorId;
        }

        public void setReleaseDate(int releaseDate)
        {
            this.releaseDate = releaseDate;
        }

        public void setImdb(double imdb)
        {
            this.imdb = imdb;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setPoster(Image poster)
        {
            this.poster = poster;
        }
        #endregion

        #region Getter
        public int getMovieId()
        {
            return movieId;
        }

        public string getTitle()
        {
            return title;
        }

        public int getDirectorId()
        {
            return directorId;
        }

        public int getReleaseDate()
        {
            return releaseDate;
        }

        public double getImdb()
        {
            return imdb;
        }

        public string getDescription()
        {
            return description;
        }

        

        public Image getPoster()
        {
           
            return poster;
            
        }
        #endregion

    }
}
