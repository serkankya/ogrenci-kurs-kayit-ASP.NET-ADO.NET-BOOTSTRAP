using entityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer
{
    public class DALders
    {

        public static List <entityDers> dersler()
        {
            List<entityDers> liste = new List<entityDers>();
            SqlCommand cmd = new SqlCommand("select *from tbl_dersler", sql.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                entityDers ent = new entityDers();
                ent.ID = int.Parse(dr["dersid"].ToString());
                ent.DERSAD = dr["dersad"].ToString();
                ent.MIN = int.Parse(dr["dersminkont"].ToString());
                ent.MAX = int.Parse(dr["dersmaxkont"].ToString());
                ent.MEVCUT = int.Parse(dr["dersmevcutkont"].ToString());


                liste.Add(ent);
            }
            dr.Close();
            return liste;
        }

        
        public static int kontenjanGuncelle(int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_dersler SET dersmevcutkont = ISNULL(dersmevcutkont,0) + 1 WHERE dersid=@p1", sql.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", id);

            return cmd.ExecuteNonQuery();
        }


        public static entityDers kontenjanSorgu(int dersID)
        {
            SqlCommand cmd = new SqlCommand("SELECT dersid,dersad,dersminkont,dersmaxkont,dersmevcutkont FROM tbl_dersler WHERE dersid=@p1", sql.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", dersID);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                entityDers ent = new entityDers();
                ent.ID = int.Parse(dr["dersid"].ToString()) ;
                ent.DERSAD = dr["dersad"].ToString() ;
                ent.MIN = int.Parse(dr["dersminkont"].ToString());
                ent.MAX = int.Parse(dr["dersmaxkont"].ToString());
                ent.MEVCUT = int.Parse(dr["dersmevcutkont"].ToString());
                dr.Close();
                return ent;
            }
            else
            {
                dr.Close();
                return null;
            }
        }



    }
}
