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
    public partial class FormOrders : Form
    {
        private List<Order> listOrders;
        public FormOrders()
        {
            InitializeComponent();
        }

        /* ------------------------------------------------*/
        /* CONSTRUCTOR*/
        /* ------------------------------------------------*/
        public FormOrders(List<Order> listOrders)
        {
            this.listOrders = listOrders;
            InitializeComponent();
            listViewOrders.View = View.Details;
            listViewOrders.GridLines = true;

            listViewOrders.Columns.Add("Order ID");
            listViewOrders.Columns.Add("User ID");
            listViewOrders.Columns.Add("Movie Id");
            listViewOrders.Columns.Add("Order Date");

            listViewOrders.Columns[0].Width = 60;
            listViewOrders.Columns[1].Width = 60;
            listViewOrders.Columns[2].Width = 150;
            listViewOrders.Columns[3].Width = 150;

            loadListOrders();
            //listViewOrders.View = View.Details;

        }

        /* ------------------------------------------------*/
        /* EVENTS */
        /* ------------------------------------------------*/
        public void loadListOrders()
        {
           // listViewOrders.Items.Clear();
            foreach(Order o in listOrders)
            {
                ListViewItem lvi = new ListViewItem(o.getOrderId().ToString());

                lvi.SubItems.Add(o.getUserId().ToString());
                lvi.SubItems.Add(o.getMovieId().ToString());
                lvi.SubItems.Add(o.getDateOfOrder().ToString());
                listViewOrders.Items.Add(lvi);
            }
        }
    }
}
