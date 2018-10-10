using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseV04
{
   public class Check
    {
        public bool checkNameIsNoEmpty(string word)
        {

            if (word == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkPasswordInNotEmpty(string pass)
        {

            if (pass == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
