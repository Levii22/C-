using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable Dt;
        private SqlDataAdapter Da;
        private string ConStr;
        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Repos\C-\EMS\empDB.mdf;Integrated Security=True;Connect Timeout=5";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
            
        }

        public DataTable GetData(string Query)
        {
            Dt = new DataTable();
            Da = new SqlDataAdapter(Query, ConStr);
            Da.Fill(Dt);
            return Dt;
        }

        public int SetData(string Query)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
    }
}
