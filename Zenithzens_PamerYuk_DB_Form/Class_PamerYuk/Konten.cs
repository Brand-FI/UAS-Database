using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_PamerYuk
{
    public class Konten
    {
        private int id;
        private string caption;
        private string foto;
        private string video;
        private DateTime tglUpload;
        private User pengguna;

        public int Id { get => id; set => id = value; }
        public string Caption { get => caption; set => caption = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Video { get => video; set => video = value; }
        public DateTime TglUpload { get => tglUpload; set => tglUpload = value; }
        public User Pengguna { get => pengguna; set => pengguna = value; }

        public Konten()
        {
            Id = 0;
            Caption = "";
            Foto = "";
            Video = "";
            TglUpload = DateTime.Now;
            Pengguna = new User();
        }
    }
}