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
            GetDepartments();
        }
        private void ListEmployees()
        {
            string Query = "SELECT * FROM EmployeeTable";
            EmpData.DataSource = Con.GetData(Query);
        }

        int Key = 0;
        private void EmpData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpName.Text = EmpData.Rows[e.RowIndex].Cells[1].Value.ToString();
            EmpGen.Text = EmpData.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmpDep.SelectedValue = EmpData.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmpDOB.Value = Convert.ToDateTime(EmpData.Rows[e.RowIndex].Cells[4].Value.ToString());
            EmpJDate.Value = Convert.ToDateTime(EmpData.Rows[e.RowIndex].Cells[5].Value.ToString());
            EmpSal.Text = EmpData.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (EmpName.Text == "")
            {
                Key = 0;
            }
            Key = Convert.ToInt32(EmpData.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void DepTab_Click(object sender, EventArgs e)
        {
            departments Obj = new departments();
            Obj.Show();
            this.Hide();
        }
        private void GetDepartments()
        {
            string Query = "SELECT * FROM DepartmentTable";
            EmpDep.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            EmpDep.ValueMember = Con.GetData(Query).Columns["DepID"].ToString();
            EmpDep.DataSource = Con.GetData(Query);
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpName.Text == "" || EmpGen.SelectedIndex == -1 || EmpDep.SelectedIndex == -1 || EmpSal.Text == "")
                {
                    MessageBox.Show("Missing data!");
                }
                else
                {
                    string name = EmpName.Text;
                    string gender = EmpGen.SelectedItem.ToString();
                }
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
