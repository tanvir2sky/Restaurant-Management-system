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
        DataDataContext data = new DataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tanvi\OneDrive\Documents\GitHub\Restaurant-Management-system\Restaurant Management\RMS.mdf;Integrated Security=True");
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
                var no = from m in data.logins where m.email == user && m.password == pass select m;
                if (no.Count() == 1)
                {
                    login l = data.logins.SingleOrDefault(x => x.email == user);
                    Employee em = data.Employees.SingleOrDefault(x => x.e_email == user);

                    String edate = DateTime.Today.ToString("dd-MM-yyyy");

                    var check = from m in data.attendences where m.date == edate && m.isAlreadyGiven == 1 && m.e_id == em.Id select m;
                    if (check.Count() == 0)
                    {

                        attendence a = new attendence
                        {

                            e_id = em.Id,
                            date = edate,
                            isAttend = 1,
                            isAlreadyGiven = 1,
                            checkInTime = DateTime.Now.ToString("HH:mm:ss")


                        };
                        try
                        {
                            data.attendences.InsertOnSubmit(a);
                            data.SubmitChanges();
                        }
                        catch (Exception )
                        {
                           
                            
                             MessageBox.Show("Cannot Give attendence", "Error Occured",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }
                    
                    }


                    if (l.role == "manager") {
                       
                        Manager m = new Manager(em.e_name,em.e_role);
                        m.Show();
                    
                    }
                    else if (l.role == "salesman") {
                        Salesman s = new Salesman();
                       
                        s.Show();
                    }


                }
                else
                {
                    error_login.Show();

                
                }
           
            

            

        }
    }
}
