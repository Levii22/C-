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
                    int dep = Convert.ToInt32(EmpDep.SelectedValue.ToString());
                    int salary = Convert.ToInt32(EmpSal.Text);
                    string Jdate = EmpJDate.Value.ToString("yyyy-MM-dd");
                    string DOB = EmpDOB.Value.ToString("yyyy-MM-dd");
                    string Query = "Insert into EmployeeTable values('{0}','{1}',{2},'{3}','{4}','{5}')";
                    Query = string.Format(Query, name, gender, dep, DOB, Jdate, salary);
                    Con.SetData(Query);
                    ListEmployees();
                    MessageBox.Show("Added.");
                    EmpName.Text = "";
                    EmpGen.SelectedIndex = -1;
                    EmpDep.SelectedIndex = -1;
                    EmpSal.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
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
                    int dep = Convert.ToInt32(EmpDep.SelectedValue.ToString());
                    int salary = Convert.ToInt32(EmpSal.Text);
                    string Jdate = EmpJDate.Value.Date.ToString("yyyy-MM-dd");
                    string DOB = EmpDOB.Value.Date.ToString("yyyy-MM-dd");
                    string Query = "Update EmployeeTable set EmpName = '{0}', EmpGen = '{1}', EmpDep = {2}, EmpDOB = '{3}', EmpJDate = '{4}', EmpSal = '{5}' where EmpID = '{6}'";
                    Query = string.Format(Query, name, gender, dep, DOB, Jdate, salary, Key);
                    Con.SetData(Query);
                    ListEmployees();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
