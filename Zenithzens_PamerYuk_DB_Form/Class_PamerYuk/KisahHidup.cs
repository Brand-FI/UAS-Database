using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_PamerYuk
{
    public class KisahHidup
    {
        private Organisasi organisasi;
        private string thAwal;
        private string thAkhir;
        private string deskripsi;

        public Organisasi Organisasi { get => organisasi; set => organisasi = value; }
        public string ThAwal { get => thAwal; set => thAwal = value; }
        public string ThAkhir { get => thAkhir; set => thAkhir = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        public KisahHidup()
        {
            Organisasi = new Organisasi();
            ThAwal = DateTime.Now.Year.ToString();
            ThAkhir = DateTime.Now.Year.ToString(); 
            Deskripsi = "";
        }
        public KisahHidup(Organisasi organisasi, string thAwal, string thAkhir, string deskripsi)
        {
            Organisasi = organisasi;
            ThAwal = thAwal;
            ThAkhir = thAkhir;
            Deskripsi = deskripsi;
        }
    }
}