using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> entityPersonels = new List<EntityPersonel>();
            SqlCommand cmd = new SqlCommand("Select *From TBL_PERSONEL", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                EntityPersonel entityPersonel = new EntityPersonel();

                entityPersonel.ID = int.Parse(dt["ID"].ToString());
                entityPersonel.AD = dt["AD"].ToString();
                entityPersonel.SOYAD = dt["SOYAD"].ToString();
                entityPersonel.SEHIR = dt["SEHIR"].ToString();
                entityPersonel.GOREV = dt["GOREV"].ToString();
                entityPersonel.MAAS = int.Parse(dt["MAAS"].ToString());

                entityPersonels.Add(entityPersonel);

            }
            dt.Close();
            return entityPersonels;
        }




        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into TBL_PERSONEL(AD,SOYAD,SEHIR,GOREV,MAAS) values(@1,@2,@3,@4,@5)", Baglanti.bgl);
            sqlCommand.Parameters.AddWithValue("@1", p.AD);
            sqlCommand.Parameters.AddWithValue("@2", p.SOYAD);
            sqlCommand.Parameters.AddWithValue("@3", p.SEHIR);
            sqlCommand.Parameters.AddWithValue("@4", p.GOREV);
            sqlCommand.Parameters.AddWithValue("@5", p.MAAS);
            return sqlCommand.ExecuteNonQuery();
        }


        public static int PersonelSil(EntityPersonel p)
        {
            SqlCommand cmd = new SqlCommand("Delete from TBL_PERSONEL where ID =@1", Baglanti.bgl);
            cmd.Parameters.AddWithValue("@1", p.ID);
            return cmd.ExecuteNonQuery();
        }


        public static int PersonelGüncelle(EntityPersonel p)
        {
            SqlCommand cmd = new SqlCommand("Update TBL_PERSONEL set AD=@1 ,SOYAD=@2,SEHIR=@3,GOREV=@4,MAAS=@5 Where ID= @6",Baglanti.bgl);
            cmd.Parameters.AddWithValue("@1",p.AD);
            cmd.Parameters.AddWithValue("@2", p.SOYAD);
            cmd.Parameters.AddWithValue("@3", p.SEHIR);
            cmd.Parameters.AddWithValue("@4",p.GOREV);
            cmd.Parameters.AddWithValue("@5",p.MAAS);
            cmd.Parameters.AddWithValue("@6",p.ID);
            return cmd.ExecuteNonQuery();
        }





    }
}
