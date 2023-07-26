using dataAccessLayer;
using entityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogicLayer
{
    public class BLLders
    {

        public static List<entityDers> dersListele()
        {
            return DALders.dersler();
        }

        public static int BLLKontenjanGuncelle(int dersID)
        {
            return DALders.kontenjanGuncelle(dersID);
        }

    }
}
