using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WEB_UYGULAMA
{
    public partial class kullanici : System.Web.UI.MasterPage
    {
        sql_sinif bgl = new sql_sinif();
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlCommand komut =new SqlCommand("SELECT * FROM TBL_KATEGORİLER",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            DataList1.DataSource= oku;
            DataList1.DataBind();

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}