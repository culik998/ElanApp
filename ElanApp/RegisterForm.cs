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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        

        private void button_register_Click(object sender, EventArgs e)
        {
            

            ElanDbContext db = new ElanDbContext();
            User user = new User
            {
                Name = textBox_name.Text,
                Email = textBox_email.Text,
                Password = textBox_password.Text,
                Surname = textBox_surname.Text,
                ConfirmPassword = textBox_confirmpassword.Text
            };


            ValidationContext context = new ValidationContext(user);
            List<ValidationResult> list = new List<ValidationResult>();
          var result=  Validator.TryValidateObject(user, context, list, true);

            if (result)
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            else
            {
                foreach (var item in list)
                {
                    label6.Text +="\n"+item.ErrorMessage.ToString();
                }

                
            }

     
            


        

           
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
