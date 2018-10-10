using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseV04
{
    public class Order
    {
        private int orderId;
        private int userId;
        private int movieId;
        private DateTime dateOfOrder;

        /* ------------------------------------------------*/
        /* CONSTRUCTOR */
        /* ------------------------------------------------*/
        public Order()
        {

        }

        public Order(int orderId, int userId, int movieId, DateTime dateOfOrder)
        {
            this.orderId = orderId;
            this.userId = userId;
            this.movieId = movieId;
            this.dateOfOrder = dateOfOrder;
        }


        /* ------------------------------------------------*/
        /* SETTER */
        /* ------------------------------------------------*/
        public void setOrderId(int orderId)
        {
            this.orderId = orderId;
        }

        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public void setMovieId(int movieId)
        {
            this.movieId = movieId;
        }

        public void setDateOfOrder(DateTime dateOfOrder)
        {
            this.dateOfOrder = dateOfOrder;
        }

        /* ------------------------------------------------*/
        /* GETTER */
        /* ------------------------------------------------*/
        public int getOrderId()
        {
            return orderId;
        }

        public int getUserId()
        {
            return userId;
        }

        public int getMovieId()
        {
            return movieId;
        }

        public DateTime getDateOfOrder()
        {
            return dateOfOrder;
        }
    }
}
