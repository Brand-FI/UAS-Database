using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_PamerYuk
{
    public class Teman
    {
        private string username1;
        private string username2;
        private DateTime tglBerteman;
        public string Username1 { get => username1; set => username1 = value; }
        public string Username2 { get => username2; set => username2 = value; }
        public DateTime TglBerteman { get => tglBerteman; set => tglBerteman = value; }

        public Teman()
        {
            Username1 = "";
            Username2 = "";
            TglBerteman = DateTime.MinValue;
        }
        public static bool TambahData(Teman t)
        {
            string perintah = "INSERT INTO Teman (username1, username2) VALUES ('" +
            t.Username1 + "', '" + t.Username2 + "');";
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
        public static bool TerimaTeman(Teman t)
        {
            string perintah = "UPDATE teman " +
                "SET tglBerteman = NOW() WHERE username1 = '"+ t.username1 +"';";

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
        public static bool HapusTeman(string username)
        {
            string perintah = "DELETE FROM teman " +
                "WHERE username1 = '" + username + "' OR username2 = '" + username + "';";

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
        public static List<Teman> BacaRequest(Teman t)
        {
            string perintah = "SELECT t.username1 as Username FROM teman t " +
                "WHERE t.username2 = '" + t.Username2 +"' AND t.tglBerteman IS NULL;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Teman> ListPermintaan = new List<Teman>();
            while (hasil.Read() == true)
            {
                Teman friend = new Teman();
                string tampungUser1 = hasil.GetValue(0).ToString();
                friend.username1 = tampungUser1;

                ListPermintaan.Add(friend);
            }
            return ListPermintaan;
        }
        public static List<Teman> BacaTeman(User u)
        {
            string perintah = "SELECT username1 AS Friend FROM teman WHERE username2 = '" + u.Username + "' AND tglBerteman IS NOT NULL " +
                                  "UNION " +
                                  "SELECT username2 AS Friend FROM teman WHERE username1 = '" + u.Username + "' AND tglBerteman IS NOT NULL;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Teman> ListTeman = new List<Teman>();
            while (hasil.Read() == true)
            {
                Teman friend = new Teman();
                string tampungUser1 = hasil.GetValue(0).ToString();
                friend.username1 = tampungUser1;

                ListTeman.Add(friend);
            }
            return ListTeman;
        }
    }
}