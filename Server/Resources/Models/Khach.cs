using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Khach
    {
        private string idkhach;
        private string hoten;
        private string email;

        public Khach(string idkhach, string hoten, string email)
        {
            this.idkhach = idkhach;
            this.hoten = hoten;
            this.email = email;
        }

        public string IDKhach { get => idkhach; }
        public string HoTen { get => hoten; }
        public string Email { get => email; }
    }
}
