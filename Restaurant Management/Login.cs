using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurant_Management
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string user = user_id.Text;
            string pass = password.Text;
            //checking if values are empty or not
                if(user == ""){
                    error_user.Show();
                    return;
                }
                if (pass == "") {

                    error_password.Show();
                    error_user.Hide();
                    return;
                }
                

            //checking done
           
            

            

        }
    }
}
