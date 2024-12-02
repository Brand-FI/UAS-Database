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
    }
}