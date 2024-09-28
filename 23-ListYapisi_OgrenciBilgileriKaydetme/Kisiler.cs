using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_ListYapisi_OgrenciBilgileriKaydetme
{
    internal class Kisiler
    {
        string ad;
        string soyad;
        string meslek;


        public string Adı
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyadı
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string Mesleki
        {
            get { return meslek; }
            set { meslek = value; }
        }

    }
}
