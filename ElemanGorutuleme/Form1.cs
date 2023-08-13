using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElemanGorutuleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Personel> personelListesi = new List<Personel>();
        private void Form1_Load(object sender, EventArgs e)
        {
    
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));
            personelListesi.Add(new Personel("Caner", "KUYUCU", new DateTime(2000, 09, 28), "Bilgisayar Mühendisi", 20000, "Kağıthane"));

            ElemanListesi.View = View.Details;
            ElemanListesi.GridLines = true;
            ElemanListesi.FullRowSelect = true;

            ElemanListesi.Columns.Add("Ad", 100);

            ElemanListesi.Columns.Add("Soyad", 100);
            ElemanListesi.Columns.Add("Doğum Tarihi", 100);
            ElemanListesi.Columns.Add("Departman", 100);
            ElemanListesi.Columns.Add("Maaş", 100);
            ElemanListesi.Columns.Add("Adres", 100);
        }


        private void verileriGetirButton_Click_1(object sender, EventArgs e)
        {

            ElemanListesi.Items.Clear();
            foreach (var personel in personelListesi)
            {
                ListViewItem satir = new ListViewItem(personel.Ad);
                satir.SubItems.Add(personel.Soyad);
                satir.SubItems.Add(personel.DogumTarihi.ToShortDateString());
                satir.SubItems.Add(personel.Departman);
                satir.SubItems.Add(personel.Maas.ToString());
                satir.SubItems.Add(personel.Adres);

                ElemanListesi.Items.Add(satir);

                //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            }
        }
    }
}
