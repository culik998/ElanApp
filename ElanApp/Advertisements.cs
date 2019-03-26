using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElanApp
{
    public partial class Advertisements : Form
    {
        

        public Advertisements( )
        {
         
            InitializeComponent();
        }

        private void Advertisements_Load(object sender, EventArgs e)
        {
           
        }

        private void adress_Click(object sender, EventArgs e)
        {
            ElanDbContext db = new ElanDbContext();
            adress.Text = db.Houses.Select(x => x.Adress).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
