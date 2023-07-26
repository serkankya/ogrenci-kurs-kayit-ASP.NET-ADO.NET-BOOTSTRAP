using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityLayer;

namespace dataAccessLayer
{
    public class DALsinif
    {

        public static List<entitySinif> siniflar()
        {
            List<entitySinif> liste = new List<entitySinif>();
            SqlCommand cmd = new SqlCommand("select *from tbl_siniflar",sql.con);
            if(cmd.Connection.State != System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                entitySinif ent = new entitySinif();
                ent.SINIFID = int.Parse(dr["sinifid"].ToString());
                ent.SINIF = dr["sinif"].ToString();

                liste.Add(ent);
            }
            dr.Close();
            return liste;
        }


    }
}
