using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityLayer;
using dataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLsinif
    {

        public static List<entitySinif> sinifListele()
        {
            return DALsinif.siniflar();
        }

    }
}
