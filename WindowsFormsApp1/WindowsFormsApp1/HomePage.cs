using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HomePage : Form
    {
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pbTest_Click(object sender, EventArgs e)
        {
            FilmPage test = new FilmPage();
            test.ShowDialog(); 
        }

        private void ListOfMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
