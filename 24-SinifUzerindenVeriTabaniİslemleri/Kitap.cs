
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_SinifUzerindenVeriTabaniİslemleri
{
    internal class Kitap
    {
        int id;
        string ad;
        string yazar;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Yazar
        {
            get { return yazar; }
            set { yazar = value; }
        }
    }
}
