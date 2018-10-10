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
    public partial class FormAboutUs : Form
    {
        /* ------------------------------------------------*/
        /* CONSTRUCTOR */
        /* ------------------------------------------------*/
        public FormAboutUs()
        {
            InitializeComponent();
        }
       
        /* ------------------------------------------------*/
        /* BUTTONS */
        /* ------------------------------------------------*/
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
