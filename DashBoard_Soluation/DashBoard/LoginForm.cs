using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void closedbtn_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

       
       

       

        private void ShowPassword_click(object sender, MouseEventArgs e)
        {
            if (PasswordText.UseSystemPasswordChar == false)
                PasswordText.UseSystemPasswordChar = true;
            else
                PasswordText.UseSystemPasswordChar = false;
        }

    
    }
}
