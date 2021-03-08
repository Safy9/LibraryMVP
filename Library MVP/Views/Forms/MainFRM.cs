using Library_MVP.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_MVP.Views
{
    public partial class MainFRM : Form
    {
        public MainFRM()
        {            
            InitializeComponent();
        }

        private void tsbtnCategory_Click(object sender, EventArgs e)
        {
            CategoryFRM frm = new CategoryFRM();
            frm.ShowDialog();
        }

        private void tsbtnCountry_Click(object sender, EventArgs e)
        {
            CountryFRM frm = new CountryFRM();
            frm.ShowDialog();
        }
    }
}
