using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Microsoft.Win32;
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
        private List<KisahHidup> listKisahHidup;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string NoKTP { get => noKTP; set => noKTP = value; }
        public string Foto { get => foto; set => foto = value; }
        public Kota Kota { get => kota; set => kota = value; }
        public List<KisahHidup> ListKisahHidup { get => listKisahHidup; set => listKisahHidup = value; }

        public User()
        {
            Username = "";
            Password = "";
            TglLahir = DateTime.Now;
            NoKTP = "";
            Foto = "";
            Kota = new Kota();
            ListKisahHidup = new List<KisahHidup>();
        }
        public void TambahKisah(Organisasi or, string tglAwal, string tglAkhir, string deskripsi)
        {
            KisahHidup kh = new KisahHidup();
            kh.Organisasi = or;
            kh.ThAwal = tglAwal;
            kh.ThAkhir = tglAkhir;
            kh.Deskripsi = deskripsi;
            ListKisahHidup.Add(kh);
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

        public static List<User> BacaUserLain(User u, string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "Organisasi")
            {
                perintah = "SELECT DISTINCT u.username " + // Biar tidak double
                           "FROM User u " +
                           "INNER JOIN KisahHidup kh ON u.username = kh.username " +
                           "INNER JOIN Organisasi o ON kh.Organisasi_id = o.id " +
                           "INNER JOIN KisahHidup kh2 ON kh2.Organisasi_id = kh.Organisasi_id " +
                           "LEFT JOIN Teman t ON (u.Username = t.Username1 AND t.Username2 = '" + u.Username + "') " +
                           "OR (u.Username = t.Username2 AND t.Username1 = '" + u.Username + "') " +
                           "WHERE kh.username != '" + u.Username + "' " +
                           "AND kh2.username = '" + u.Username + "' " +
                           "AND t.Username1 IS NULL AND t.Username2 IS NULL " +
                           "AND u.username LIKE '%" + nilai + "%';";
            }
            else
            {
                perintah = "SELECT u.Username " +
                           "FROM User u " +
                           "LEFT JOIN Teman t " +
                           "ON (u.Username = t.Username1 AND t.Username2 = '" + u.Username + "') " +
                           "OR (u.Username = t.Username2 AND t.Username1 = '" + u.Username + "') " +
                           "WHERE t.Username1 IS NULL AND t.Username2 IS NULL " +
                           "AND u.Username != '" + u.Username + "' " +
                           "AND u.username LIKE '%" + nilai + "%';";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<User> ListUser = new List<User>();
            while (hasil.Read() == true)
            {
                string tampungNama = hasil.GetValue(0).ToString();
                User user = new User();
                user.Username = tampungNama;

                ListUser.Add(user);
            }
            return ListUser;
        }

        public static User BacaData(string filter = "", string nilai = "") //Sementara
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select * from user";
            }
            else
            {
                perintah = "select * from user where " + filter + " like '%" + nilai + "%'";
            }

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
        public int CekNomor() //Untuk Tambahkan Kisah hidup
        {
            string cekNomor = "SELECT COUNT(*) FROM User;";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cekNomor);
            if (hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString());
            }
            else
            {
                return 0;
            }
        }
        public static void TambahData(User u, Image foto)
        {
            u.Foto = User.SimpanGambar(u, foto);

            string perintah = "INSERT INTO user (username, password, tglLahir, noKTP, foto, Kota_id) " +
                              "VALUES ('" + u.Username + "', SHA2('" + u.Password + "', 512), '" +
                              u.TglLahir.ToString("yyyy-MM-dd") + "', '" + u.NoKTP + "', '" +
                              u.Foto + "', " + u.Kota.Id + ");";
            Koneksi.JalankanPerintahDML(perintah);
            for (int i = 0; i < u.ListKisahHidup.Count; i++)
            {
                perintah = "INSERT INTO KisahHidup (Organisasi_id, username, thawal, thakhir, deskripsi) " +
                                  "VALUES ('" + u.ListKisahHidup[i].Organisasi.Id + "', '" + u.Username + "', " +
                                  u.ListKisahHidup[i].ThAwal + ", " + u.ListKisahHidup[i].ThAkhir + ", '" +
                                  u.ListKisahHidup[i].Deskripsi + "');";

                Koneksi.JalankanPerintahDML(perintah);
            }
        }
        public static void TambahKisahHidup(User u, KisahHidup kh)
        {
            string perintah = "INSERT INTO KisahHidup (Organisasi_id, username, thawal, thakhir, deskripsi) " +
                              "VALUES ('" + kh.Organisasi.Id + "', '" + u.Username + "', " +
                              kh.ThAwal + ", " + kh.ThAkhir + ", '" +
                              kh.Deskripsi + "');";

            Koneksi.JalankanPerintahDML(perintah);
        }
        public static void BacaKisahHidup(User u)
        {
            u.ListKisahHidup.Clear();

            string perintah;
            perintah = "select * from kisahhidup where username='" + u.Username + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            while (hasil.Read() == true)
            {
                KisahHidup tampung = new KisahHidup();
                tampung.Organisasi = Organisasi.BacaData("Id", hasil.GetValue(0).ToString())[0]; //Baca dari Username
                tampung.ThAwal = hasil.GetValue(2).ToString();
                tampung.ThAkhir = hasil.GetValue(3).ToString();
                tampung.Deskripsi = hasil.GetValue(4).ToString();

                u.ListKisahHidup.Add(tampung);
            }
        }
        public static string SimpanGambar(User u, Image image)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections["Zenithzens_PamerYuk_DB.db"] as ClientSettingsSection;
            string path = settingsSection.Settings.Get("profile_picture").Value.ValueXml.InnerText;
            if (image != null)
            {
                image.Save(path + "\\user_" + u.Username);
                return "user_" + u.Username;

            }
            else
            {
                return "";
            }
        }
        public static Image BacaGambar(string cover_image)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections["Zenithzens_PamerYuk_DB.db"] as ClientSettingsSection;
            string path = settingsSection.Settings.Get("profile_picture").Value.ValueXml.InnerText;
            try
            {
                Image foto = Image.FromFile(path + "\\" + cover_image);
                return foto;
            }
            catch
            {
                return null;
            }
        }
    }
}