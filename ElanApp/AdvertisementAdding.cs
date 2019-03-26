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
    public partial class AdvertisementAdding : Form
    {
        public AdvertisementAdding()
        {
            InitializeComponent();
        }

        private void button_addhouse_Click(object sender, EventArgs e)
        {
            House house = new House
            {
                Adress = textBox_adress.Text,
                Discount = textBox_discount.Text,
                PhoneNumber = textBox_phonenumber.Text,
                Price = textBox_price.Text
            };


            ElanDbContext db = new ElanDbContext();

            db.Houses.Add(house);

            db.SaveChanges();

            if (house!=null)
            {
                
                Advertisements advertisements = new Advertisements();
                advertisements.ShowDialog();


            }

            
        }
    }
}
