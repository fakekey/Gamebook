using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Resources.Models
{
    public class User
    {
        private string email;
        private string quyen;
        private string hoten;

        public User(string email, string quyen, string hoten)
        {
            this.email = email;
            this.quyen = quyen;
            this.hoten = hoten;
        }

        public string Hoten { get => hoten; }
        public string Email { get => email; }
        public string Quyen { get => quyen; }
    }
}
