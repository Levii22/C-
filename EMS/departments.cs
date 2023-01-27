using ems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class departments : Form
    {
        Functions Con;
        public departments()
        {
            InitializeComponent();
            Con = new Functions();
            ListDepartments();
        }

        private void ListDepartments()
        {
            string Query = "SELECT * FROM DepartmentTable";
            departdata.DataSource = Con.GetData(Query);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void departments_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing data!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Insert into DepartmentTable values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    ListDepartments();
                    MessageBox.Show("Added.");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void departdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.departdata.Rows[e.RowIndex];
                DepNameTb.Text = row.Cells[1].Value.ToString();
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Key;
            }
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing data!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Update DepartmentTable set DepName = '{0}' where DepID = '{1}' ";
                    Query = string.Format(Query, DepNameTb.Text, Key);
                    Con.SetData(Query);
                    ListDepartments();
                    MessageBox.Show("Updated.");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing data!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartmentTable where DepID = '{0}' ";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ListDepartments();
                    MessageBox.Show("Deleted.");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpTab_Click(object sender, EventArgs e)
        {
            employees Obj = new employees();
            Obj.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
        }
    }
}