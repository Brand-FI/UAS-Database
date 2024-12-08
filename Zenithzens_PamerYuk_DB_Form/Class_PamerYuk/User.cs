using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Class_PamerYuk
{
    public class User
    {
        private string username;
        private string password;
        private DateTime tglLahir;
        private string noKTP;
        private string foto;
        private Kota kota;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string NoKTP { get => noKTP; set => noKTP = value; }
        public string Foto { get => foto; set => foto = value; }
        public Kota Kota { get => kota; set => kota = value; }

        public User()
        {
            Username = "";
            Password = "";
            TglLahir = DateTime.Now;
            NoKTP = "";
            Foto = "";
            Kota = new Kota();
        }

        public static User CekLogin(string uid, string pwd)
        {
            string perintah = "SELECT u.*, k.nama " + "FROM user u inner join kota k on u.Kota_id = k.id "
                + "where username= '" + uid + "' and password = SHA2('" + pwd + "', 512)";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read() == true)
            {
                User user = new User();
                user.Username = hasil.GetValue(0).ToString();
                user.TglLahir = DateTime.Parse(hasil.GetValue(2).ToString());
                user.NoKTP = hasil.GetValue(3).ToString();
                user.Foto = hasil.GetValue(4).ToString();

                Kota k = new Kota();
                k.Id = int.Parse(hasil.GetValue(5).ToString());
                k.Nama = hasil.GetValue(6).ToString();

                user.Kota = k;
                return user;
            }
            else
            {
                return null;
            }
        }

        public static bool TambahData(User u)
        {
            string perintah = "INSERT INTO user (username, password, tglLahir, noKTP, foto, Kota_id) " +
                              "VALUES ('" + u.Username + "', '" + u.Password + "', '" +
                              u.TglLahir.ToString("yyyy-MM-dd") + "', '" + u.NoKTP + "', '" +
                              u.Foto + "', " + u.Kota.Id + ");";


            int hasil = Koneksi.JalankanPerintahDML(perintah);
            return hasil > 0;
        }
        public static void EkripsiPassword()
        {
            string perintah = "update user\r\nset user.password = SHA2(user.password, 512);";
            Koneksi.JalankanPerintahDML(perintah);
        }
    }
}