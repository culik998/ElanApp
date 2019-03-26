using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            ElanDbContext db = new ElanDbContext();
            House house = new House
            {
                Adress = textBox_adress.Text,
              //  Discount = textBox_discount.Text,
                PhoneNumber = textBox_phonenumber.Text,
                Price = textBox_price.Text
            };

           

            ValidationContext context = new ValidationContext(house);
            List<ValidationResult> list = new List<ValidationResult>();
            var result = Validator.TryValidateObject(house, context, list, true);

            if (result)
            {
                db.Houses.Add(house);
                db.SaveChanges();

                MainForm main = new MainForm();
                main.ShowDialog();

              
            }
            else
            {
                foreach (var item in list)
                {
                    label4.Text += "\n" + item.ErrorMessage.ToString();
                }


            }
         
        }
    }
}
