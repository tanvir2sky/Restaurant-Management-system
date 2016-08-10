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
        public Manager()
        {
            InitializeComponent();
            add_employee_panel.Hide();
            dashbord_panel.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        
            add_employee_panel.Hide();
            dashbord_panel.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            add_employee_panel.Show();
            dashbord_panel.Hide();

        }

        private void Employee_Click(object sender, EventArgs e)
        {

        }

        private void dashbord_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_employee_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
