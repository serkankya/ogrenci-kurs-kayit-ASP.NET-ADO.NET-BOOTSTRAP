using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class entityOgrenci
    {

        private string ad;

        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }

        private string soyad;

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }

        private int numara;
            
        public int NUMARA
        {
            get { return numara; }
            set { numara = value; }
        }

        private string sinif;

        public string SINIF
        {
            get { return sinif; }
            set { sinif = value; }
        }

        private string ders;

        public string DERS
        {
            get { return ders; }
            set { ders = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


    }
}
