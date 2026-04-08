using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilyaForm
{
    internal class SqlBaglanti
    {

        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1623\\MSSQLSERVER1;Initial Catalog=MobilyaDb;Integrated Security=True;"); 
             baglan.Open();
             return baglan;
        }

    }
}
