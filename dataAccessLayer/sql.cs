using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dataAccessLayer
{
    public class sql
    {

        public static SqlConnection con = new SqlConnection("Data Source=SERKANKAYA;Initial Catalog=Dbo_kurs;Integrated Security=True");

    }
}
