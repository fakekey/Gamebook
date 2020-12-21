using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class BillTemp
    {
        public string _makh;
        public string _idsanpham;
        public string _tengame;
        public BillTemp(string makh, string idsanpham, string tengame)
        {
            _makh = makh;
            _idsanpham = idsanpham;
            _tengame = tengame;
        }
    }
}
