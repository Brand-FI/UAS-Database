using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Class_PamerYuk
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;
        public MySqlConnection KoneksiDB { get => koneksiDB; set => koneksiDB = value; }

        public Koneksi()
        {            
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections["Zenithzens_PamerYuk_DB.db"] as ClientSettingsSection;

            string DbServer = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword;
            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();
        }
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
        public static MySqlDataReader JalankanPerintahSelect(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static int JalankanPerintahDML(string perintah)
        {
            Koneksi koneksi = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, koneksi.KoneksiDB);
            int hasil = cmd.ExecuteNonQuery();
            return hasil;
        }
    }
}
