using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using entityLayer;
using System.Security.Cryptography;


namespace dataAccessLayer
{
    public class DALogrenci
    {

        public static int ogrenciEkle(entityOgrenci p)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_ogrenciler (ograd,ogrsoyad,ogrnumara,sinifid,dersid) values (@p1,@p2,@p3,@p4,@p5)", sql.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", p.AD);
            cmd.Parameters.AddWithValue("@p2", p.SOYAD);
            cmd.Parameters.AddWithValue("@p3", p.NUMARA);
            cmd.Parameters.AddWithValue("@p4", p.SINIF);
            cmd.Parameters.AddWithValue("@p5", p.DERS);

            return cmd.ExecuteNonQuery();
        }

        public static List<entityOgrenci> ogrenciListesi()
        {
            List<entityOgrenci> ogrenciler = new List<entityOgrenci>();

            SqlCommand cmd = new SqlCommand("SELECT ogrid,ograd,ogrsoyad,ogrnumara,dersad,sinif FROM tbl_ogrenciler INNER JOIN tbl_dersler ON tbl_ogrenciler.dersid = tbl_dersler.dersid INNER JOIN tbl_siniflar ON tbl_ogrenciler.sinifid = tbl_siniflar.sinifid ", sql.con);

            // SqlCommand cmd = new SqlCommand("select *from tbl_ogrenciler", sql.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                entityOgrenci ent = new entityOgrenci();
                ent.ID = Convert.ToInt32(dr["ogrid"].ToString());
                ent.AD = dr["ograd"].ToString();
                ent.SOYAD = dr["ogrsoyad"].ToString();
                ent.NUMARA = int.Parse(dr["ogrnumara"].ToString());
                ent.DERS = dr["dersad"].ToString();
                ent.SINIF = dr["sinif"].ToString();

                ogrenciler.Add(ent);
            }
            dr.Close();
            return ogrenciler;




        }


        public static List<entityOgrenci> ogrenciDetay(int id)
        {
            List<entityOgrenci> bilgiler = new List<entityOgrenci>();
            SqlCommand cmd = new SqlCommand("SELECT ogrid,ograd,ogrsoyad,ogrnumara,dersad,sinif FROM tbl_ogrenciler INNER JOIN tbl_dersler ON tbl_ogrenciler.dersid=tbl_dersler.dersid INNER JOIN tbl_siniflar ON tbl_ogrenciler.sinifid = tbl_siniflar.sinifid where ogrid=@p1 ", sql.con);
            cmd.Parameters.AddWithValue("@p1", id);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                entityOgrenci ent = new entityOgrenci();
                ent.ID = int.Parse(dr["ogrid"].ToString());
                ent.AD = dr["ograd"].ToString();
                ent.SOYAD = dr["ogrsoyad"].ToString();
                ent.NUMARA = int.Parse(dr["ogrnumara"].ToString());
                ent.DERS = dr["dersad"].ToString();
                ent.SINIF = dr["sinif"].ToString();

                bilgiler.Add(ent);
            }
            dr.Close();
            return bilgiler;
        }

        public static int ogrenciGuncelle(entityOgrenci param)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_ogrenciler SET ograd=@p1,ogrsoyad=@p2,ogrnumara=@p3,dersid=@p4,sinifid=@p5 WHERE ogrid=@p6", sql.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", param.AD);
            cmd.Parameters.AddWithValue("@p2", param.SOYAD);
            cmd.Parameters.AddWithValue("@p3", param.NUMARA);
            cmd.Parameters.AddWithValue("@p4", param.DERS);
            cmd.Parameters.AddWithValue("@p5", param.SINIF);
            cmd.Parameters.AddWithValue("@p6", param.ID);

            return cmd.ExecuteNonQuery();


        }

        public static int ogrenciSil(int p1)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_ogrenciler WHERE ogrid=@p1", sql.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",p1);
            return cmd.ExecuteNonQuery();
        }

    }
}
