using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Product
    {
        private int id_sp;
        private string title;
        private string cate;
        private string version;
        private float price;
        private string daterelease;
        private string img;

        public Product(int id_sp, string title, string cate, string version, float price, string daterelease, string img)
        {
            this.id_sp = id_sp;
            this.title = title;
            this.cate = cate;
            this.version = version;
            this.price = price;
            this.daterelease = daterelease;
            this.img = img;
        }

        public int Id_sp { get => id_sp; }
        public string Title { get => title; }
        public string Cate { get => cate; }
        public string Version { get => version; }
        public float Price { get => price; }
        public string Daterelease { get => daterelease;}
        public string Img { get => img; }
    }
}
