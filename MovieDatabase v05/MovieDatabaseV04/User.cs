using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseV04
{
    public class User
    {
        private int userId;
        private string username;
        private string password;
        public string email;
        public bool isAdmin;

        /* ------------------------------------------------*/
        /* CONSTRUCTOR */
        /* ------------------------------------------------*/
        public User(int userId, string username, string password, string email)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public User(bool isAdmin)
        {
            this.isAdmin =isAdmin;
        }

        /* ------------------------------------------------*/
        /* EVENTS */
        /* ------------------------------------------------*/
      
        #region Setter
        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        #endregion

        #region Getter
        public int getUserId()
        {
            return userId;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public string getEmail()
        {
            return email;
        }
        #endregion
    }
}
