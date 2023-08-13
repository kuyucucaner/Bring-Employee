using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElemanGorutuleme
{
    internal class Personel
    {
        string ad;
        string soyad;
        DateTime dogumTarihi;
        string departman;
        double maas;
        string adres;



        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }
        public string Departman { get => departman; set => departman = value; }
        public double Maas { get => maas; set => maas = value; }
        public string Adres { get => adres; set => adres = value; }

        public Personel(string ad, string soyad, DateTime dogumTarihi, string departman, double maas, string adres)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.DogumTarihi = dogumTarihi;
            this.Departman = departman;
            this.Maas = maas;
            this.Adres = adres;
        }
    }
}
