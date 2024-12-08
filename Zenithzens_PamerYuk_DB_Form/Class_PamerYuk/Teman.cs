using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_PamerYuk
{
    public class Teman
    {
        private User userLogin;
        private User friend;
        private DateTime tglBerteman;

        public User UserLogin { get => userLogin; set => userLogin = value; }
        public User Friend { get => friend; set => friend = value; }
        public DateTime TglBerteman { get => tglBerteman; set => tglBerteman = value; }

        public Teman()
        {
            UserLogin = new User();
            Friend = new User();
            TglBerteman = DateTime.Now;
        }
    }
}