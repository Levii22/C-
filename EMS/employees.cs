using EMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ems
{
    public partial class employees : Form
    {
        Functions Con;
        public employees()
        {
            InitializeComponent();
            Con = new Functions();
            ListEmployees();
        }
        private void ListEmployees()
        {
            string Query = "SELECT * FROM EmployeeTable";
            EmpData.DataSource = Con.GetData(Query);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        private void GetDepartments()
        {
            string Query = "SELECT * FROM DepartmentTable";
        }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
