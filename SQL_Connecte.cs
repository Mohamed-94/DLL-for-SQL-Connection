using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_DLL
{
    public class SQL_Connecte
    {
        private string sqlstring;
        private string sqlcon;

        public string sql  {
            set { sqlstring =value; }
        }
            public string  sqlconnection{
                set { sqlcon = value; }
    }

            public System.Data.DataSet Getconnection
            {
                get { return MyDataset(); }
            }
            private System.Data.DataSet MyDataset()
            {
                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(sqlcon);
                con.Open();
                System.Data.SqlClient.SqlDataAdapter da_1 = new System.Data.SqlClient.SqlDataAdapter(sqlstring, con);
                System.Data.DataSet dataset = new System.Data.DataSet();
                da_1.Fill(dataset, "test");
                con.Close();
                return dataset;
            }

    }
}
