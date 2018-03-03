using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanHoaChuoi
{
    class ChuanHoaChuoi
    {
        public static int DemSoTu(string a)
        {
            string[] b;
            b = a.Split(' ');
            return b.Count();
        }

        public static string ChuanHoa(string a)
        {
            a = a.Trim();
            while (a.IndexOf("  ") >0)
                 a = a.Replace("  ", " ");
            string[] b;
            b = a.Split(' ');
            string kq = "";
            foreach(string c in b)
            {
                if (c.Length > 1)
                    kq += c.Substring(0, 1).ToUpper() + c.Substring(1).ToLower() + " ";
                else
                    kq += c.ToUpper() + " ";
            }
            kq = kq.TrimEnd();
            return kq;
        }

        public static string[] TachChuoi(string a)
        {
            a = ChuanHoa(a);
            string[] tmp;
            tmp = a.Split(' ');
            return tmp;
        }
    }
}
