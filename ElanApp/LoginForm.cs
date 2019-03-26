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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            LoginModel loginModel = new LoginModel
            {
                Email = textBox_email.Text,
                Password = textBox_password.Text
            };

            ElanDbContext db = new ElanDbContext();

            var user = db.Users.FirstOrDefault(x => x.Email == loginModel.Email
                                                  && x.Password == loginModel.Password);

            if (user!=null)
            {
                AdvertisementAdding advertisementAdding = new AdvertisementAdding();
                advertisementAdding.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email or password is incorrect");
            }
        }
    }
}
