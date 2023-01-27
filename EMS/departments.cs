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
                }
            }
        }
        }
    }
}
