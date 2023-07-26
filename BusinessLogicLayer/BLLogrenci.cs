using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityLayer;
using dataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLLogrenci
    {

        public static int BLLogrenciEkle(entityOgrenci param)
        {
            
                return DALogrenci.ogrenciEkle(param);
            
        }


        public static List<entityOgrenci> BLLlistele()
        {
            return DALogrenci.ogrenciListesi();
        }


        public static List<entityOgrenci> BLLdetay(int p)
        {
            return DALogrenci.ogrenciDetay(p);
        }

        public static int BLLogrenciGuncelle(entityOgrenci p)
        {
            return DALogrenci.ogrenciGuncelle(p);
        }

        public static int BLLogrenciSil(int p2)
        {
            return DALogrenci.ogrenciSil(p2);
        }

    }
}
