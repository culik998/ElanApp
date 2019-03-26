using ElanApp.Components;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            ElanDbContext db = new ElanDbContext();
            var x = 20;
            var y = 20;
            var count = 0;
            foreach (var item in db.Houses)
            {
                count++;
               // var itemprice =( Convert.ToInt32(item.Price) - ((Convert.ToInt32(item.Price) * Convert.ToInt32(item.Discount) / 100))).ToString();

                ElanControl1 elanControl = new ElanControl1();
                elanControl.label1.Text = item.Adress;
              //  elanControl.label2.Text = itemprice;
                elanControl.label3.Text = item.PhoneNumber;
                elanControl.label4.Text = item.Discount;

                elanControl.Top = y;
                elanControl.Left = x;

                this.panel1.Controls.Add(elanControl);
                x += elanControl.Width + 20;
                if (count==4)
                {
                    count = 0;
                    y += elanControl.Height + 20;
                    x = 20;
                }

            }


        }
    }
}
