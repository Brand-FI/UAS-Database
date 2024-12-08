using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_PamerYuk
{
    public class Kota
    {
        private int id;
        private string nama;

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public Kota()
        {
            Id = 0;
            Nama = "";
        }
        public Kota(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        public override string ToString()
        {
            return Nama;
        }
        public static List<Kota> BacaData()
        {
            string perintah;
            perintah = "select * from Kota";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Kota> ListKota = new List<Kota>();
            while (hasil.Read() == true)
            {

                int tampungId = int.Parse(hasil.GetValue(0).ToString());
                string tampungNama = hasil.GetValue(1).ToString();

                Kota tampung = new Kota(tampungId, tampungNama);

                ListKota.Add(tampung);
            }
            return ListKota;
        }
    }
}