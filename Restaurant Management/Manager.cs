using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Manager : MetroFramework.Forms.MetroForm
    {
        private string showname;
        private string showrole;
        DataDataContext data = new DataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\tanvi\OneDrive\Documents\GitHub\Restaurant-Management-system\Restaurant Management\RMS.mdf;Integrated Security=True");
        public Manager(string name,string role)
        {
            InitializeComponent();
            this.showname = name;
            this.showrole = role;
            view_employee_grid.DataSource = data.Employees;
            welcome.Text = this.showname;
            metroLabel1.Text = this.showrole;
            metroLabel2.Text =  Greetings.getGreting();
           
        }

       

       

       

       
        private void add_employee_Click(object sender, EventArgs e)
        {
            string ename = name.Text;
            string eaddress = address.Text;
            string eemail = email.Text;
            string erole = role.Text;
            decimal esalary = 0;
            string epassord = e_password.Text;
            try
            {
                 esalary = Convert.ToDecimal(salary.Text);
            }
            catch (Exception)
            {
                
                throw;
               
            }
            string edate = date.Value.ToString("yyyy-MM-dd");

            Employee emp = new Employee
            {
                e_name = ename,
                e_address = eaddress,
                e_email = eemail,
                e_role = erole,
                e_joining_date = edate,
                e_salary = esalary


            };
            data.Employees.InsertOnSubmit(emp);

            try
            {
                data.SubmitChanges();
            }
            catch (Exception)
            {
                
                throw;
            }

            login l = new login
            {
               email = eemail,
               password =epassord,
               role=erole


            };
            data.logins.InsertOnSubmit(l);
            data.SubmitChanges();
            MessageBox.Show("Successfully Added New Employee");


        }



        private void delete_button_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                 id = Convert.ToInt16(delete_id.Text);
            }
            catch (Exception)
            {
                
                throw;
            }
            Employee emp = data.Employees.SingleOrDefault(x => x.Id == id);
            if (emp == null)
            {
                delete_error.Text = "No data found for this id";
                return;

            }
            data.Employees.DeleteOnSubmit(emp);
            data.SubmitChanges();
            MessageBox.Show("Successfully delete employee: " + emp.e_name);


        }

        private void check_if_found(object sender, EventArgs e)
        {
            if (delete_id.Text == "") {

                return;

            }
            int id = 0;
            try
            {
                 id = Convert.ToInt16(delete_id.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please Insert Only Integer Values", "Error Occured",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee emp = data.Employees.SingleOrDefault(x => x.Id == id);
            if (emp == null)
            {
                delete_error.Text = "No data found for this id";
                delete_label.Text = "";
                return;
                
            }
            delete_error.Text = "";
            delete_label.Text = emp.e_name + " Will be deleted";

        }

        

       
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void update_id_TextChanged(object sender, EventArgs e)
        {
            if (update_id.Text == "")
            {

                return;

            }
            int id = 0;
            try
            {
                id = Convert.ToInt16(update_id.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please Insert Only Integer Values", "Error Ocured",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee emp = data.Employees.SingleOrDefault(x => x.Id == id);
            if (emp == null) {
                update_error.Text = "Cannot find with this id";
                return;
            
            }
            update_error.Text = "";
            uname.Text = emp.e_name;
            uaddress.Text = emp.e_address;
            uemail.Text = emp.e_email;
            usalary.Text = emp.e_salary.ToString();
            urole.Text = emp.e_role;



        }

        private void update_employee_Click(object sender, EventArgs e)
        {
            if (update_id.Text == "")
            {

                return;

            }
            int id = 0;
            try
            {
                id = Convert.ToInt16(update_id.Text);
            }
            catch (Exception)
            {

                throw;
            }
            string ename = uname.Text;
            string eaddress = uaddress.Text;
            string eemail = uemail.Text;
            string erole = urole.Text;
            decimal esalary = 0;
            try
            {
                esalary = Convert.ToDecimal(usalary.Text);
            }
            catch (Exception)
            {

                throw;

            }

            Employee emp = data.Employees.SingleOrDefault(x => x.Id == id);
            
                emp.e_name = ename;
                emp.e_address = eaddress;
                emp.e_email = eemail;
                emp.e_role = erole;
                emp.e_salary = esalary;
                data.SubmitChanges();

                MessageBox.Show("Successfully Updated");



           

            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
