using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;



    public class sql_sinif
{
    
    
    public SqlConnection baglanti()
    {

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-1623\MSSQLSERVER1;Initial Catalog=ARIZA;Integrated Security=True;Encrypt=False;");
        baglan.Open();
        return baglan;
    }


}

   
