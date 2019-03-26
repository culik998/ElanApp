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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = textBox_name.Text,
                Email = textBox_email.Text,
                Password = textBox_password.Text,
                Surname = textBox_surname.Text,
                ConfirmPassword = textBox_confirmpassword.Text
            };

            ElanDbContext db = new ElanDbContext();

            db.Users.Add(user);

            db.SaveChanges();
     
            
            if (user!=null)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }

        

           
           
        }
    }
}
