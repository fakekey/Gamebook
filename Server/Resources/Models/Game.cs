using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Game
    {
        private string idgame;
        private string tengame;
        private string dongia;

        public Game(string idgame, string tengame, string dongia)
        {
            this.idgame = idgame;
            this.tengame = tengame;
            this.dongia = dongia;
        }

        public string IDGame { get => idgame; }
        public string TenGame { get => tengame; }
        public string DonGia { get => dongia; }
    }
}
