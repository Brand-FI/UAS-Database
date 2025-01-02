using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_PamerYuk
{
    public class Organisasi
    {
        private int id;
        private string nama;
        private Kota kota;
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public Kota Kota { get => kota; set => kota = value; }

        public Organisasi()
        {
            Id = CekNomor() + 1;
            Nama = "";
            Kota = new Kota();
        }
        public int CekNomor() //Untuk Auto Increment 
        {
            string cekNomor = "SELECT COUNT(*) FROM Organisasi;";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cekNomor);
            if(hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString());
            }
            else
            {
                return 0;
            }
        }
        public static bool TambahData(Organisasi o)
        {
            string perintah = "INSERT INTO organisasi (Id, Nama, Kota_id) VALUES ('" +
            o.Id + "', '" + o.Nama + "', '" + o.Kota.Id + "');";
            int hasil = Koneksi.JalankanPerintahDML(perintah);
            if (hasil > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Organisasi> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select * from organisasi";

            }
            else
            {
                perintah = "select * from organisasi where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Organisasi> ListOrganisasi = new List<Organisasi>();
            while (hasil.Read() == true)
            {
                Organisasi or = new Organisasi ();
                or.Id = int.Parse(hasil.GetValue(0).ToString());
                or.Nama = hasil.GetValue(1).ToString();

                Kota k = new Kota();
                k.Id = int.Parse(hasil.GetValue(2).ToString());

                or.Kota.Id = k.Id;

                ListOrganisasi.Add(or);
            }
            return ListOrganisasi;
        }
        public override string ToString()
        {
            return Nama;
        }
    }
}