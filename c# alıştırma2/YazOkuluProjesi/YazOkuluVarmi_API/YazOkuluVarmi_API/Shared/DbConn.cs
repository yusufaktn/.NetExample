using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace YazOkuluVarmi_API.Shared
{
    public class DbConn
    {
       public SqlConnection conn;

        public DbConn()
        {
            conn = new SqlConnection("Data Source=DESKTOP-1623\\MSSQLSERVER1;Initial Catalog=yov;Integrated Security=True;TrustServerCertificate=True;");
            conn.StateChange += Conn_StateChange;
        }
       
        private void Conn_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            if (e.CurrentState == System.Data.ConnectionState.Closed)
            {
                ((SqlConnection)sender).Open();
            }
        }
    }
}
