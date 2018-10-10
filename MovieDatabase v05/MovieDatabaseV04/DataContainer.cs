using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;
using System.Drawing.Imaging;

namespace MovieDatabaseV04
{
    public class DataContainer
    {
        List<Movie> listMovies;
        List<User> listUsers;
        List<Order> listOrders;

        #region Constructor
        public DataContainer()
        {
            listMovies = new List<Movie>();
            listUsers = new List<User>();
            listOrders = new List<Order>();
        }
        #endregion

        #region Calling - Uploading Datas
        public bool uploadDataFromDatabase()
        {
            try
            {
                uploadListMovies();
                uploadListUsers();
                uploadListOrders();

                AssignUsersToOrders();

                return true;
            }

            catch (NotImplementedException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        #endregion

        #region Uploading - Every table
        //UPLOAD MOVIES
        public void uploadListMovies()
        {
            Database d = new Database();
            MySQLDatabaseInterface mdi = d.connect();
            mdi.makeConnectionToDatabase();
            mdi.open();
            DataTable datatable;
            string query = "SELECT * FROM movies";
            datatable = mdi.getToDataTable(query);

            foreach (DataRow row in datatable.Rows)
            {
                Movie m = new Movie();
                m.setMovieId(Convert.ToInt32(row["movieId"]));
                m.setTitle(row["title"].ToString());
                m.setDirectorId(Convert.ToInt32(row["directorId"]));
                m.setReleaseDate(Convert.ToInt32(row["releaseDate"]));
                m.setImdb(Convert.ToDouble(row["imdb"]));
                m.setDescription(row["description"].ToString());


                /*Convert.ToInt32(row["movieId"]),
                    row["title"].ToString(),
                    Convert.ToInt32(row["directorId"]),
                    Convert.ToInt32(row["releaseDate"]),
                    Convert.ToDouble(row["imdb"]),
                    row["description"].ToString(),
                   //new MemoryStream((byte[])row["poster"])
                    );*/



                if (m.getMovieId() > 0)
                {
                    listMovies.Add(m);
                }
               
            }
            mdi.close();
        }


        //UPLOAD USERS
        public void uploadListUsers()
        {
            Database d = new Database();
            MySQLDatabaseInterface mdi = d.connect();
            mdi.makeConnectionToDatabase();
            mdi.open();
            DataTable datatable;

            string query = "SELECT * FROM users";

            datatable = mdi.getToDataTable(query);

            foreach (DataRow row in datatable.Rows)
            {
                User u = new User(
                    Convert.ToInt32(row["userId"]),
                    row["username"].ToString(),
                    row["password"].ToString(),
                    row["email"].ToString()
                    ); 

                if (u.getUserId() > 0)
                {
                    listUsers.Add(u);
                }
            }
            mdi.close();
        }

        //UPLOAD ORDERS
        public void uploadListOrders()
        {
            Database d = new Database();
            MySQLDatabaseInterface mdi = d.connect();
            mdi.makeConnectionToDatabase();
            mdi.open();
            string query = "SELECT * FROM `movieorder`";
            DataTable datatable;

            datatable = mdi.getToDataTable(query);

            foreach (DataRow row in datatable.Rows)
            {
                Order o = new Order();
                o.setOrderId(Convert.ToInt32(row["orderId"]));
                o.setUserId(Convert.ToInt32(row["userId"]));
                o.setMovieId(Convert.ToInt32(row["movieId"]));
                    o.setDateOfOrder(Convert.ToDateTime(row["date"])
                    );

                if (o.getOrderId() > 0)
                    listOrders.Add(o);
            }
            mdi.close();
        }
        #endregion

        #region Getting Lists
        public List<Movie> getListMovies()
        {
            return listMovies;
        }

        public List<User> getListUsers()
        {
            return listUsers;
        }

        public List<Order> getListOrders()
        {
            return listOrders;
        }
        #endregion

        #region Assign Users To Orders
        public void AssignUsersToOrders()
        {
            foreach(User u in listUsers)
            {
                int userId = u.getUserId();
                List<Order> listOrdersOfUsers = getListUserOrders(userId);

            }
        }
        #endregion

        #region UsersOrders
        public List<Order> getListUserOrders (int userId)
        {
            List<Order> ListUserOrders = new List<Order>();
            foreach(Order o in listOrders)
            {
                if(o.getUserId() == userId)
                {
                    ListUserOrders.Add(o);
                }
            }
            return ListUserOrders;
        }
        #endregion
    }
}




