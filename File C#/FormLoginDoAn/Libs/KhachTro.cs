using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLoginDoAn.Libs
{
    class KhachTro
    {
        public static string _username = "";
        public static string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public static string _maphong = "";
        public static string maphong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }
    }
}
