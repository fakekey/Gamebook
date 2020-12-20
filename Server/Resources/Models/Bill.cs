using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Bill
    {
        public string _mahd;
        public string _tenkhach;
        public string _ngaymua;
        public string _tongtien;
        public string _matinhtrang;
        public Bill(string mahd, string tenkhach, string ngaymua, string tongtien, string matinhtrang)
        {
            _mahd = mahd;
            _tenkhach = tenkhach;
            _ngaymua = ngaymua;
            _tongtien = tongtien;
            _matinhtrang = matinhtrang;
        }
    }
}
