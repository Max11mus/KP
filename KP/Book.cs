using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace KP
{
    public class Book
    {
        public string Nazva { get; set; }
        public string Avtor { get; set; }
        public int God { get; set; }
        public string Janr { get; set; }
        public string Mova { get; set; }
        public string Age { get; set; }
        public int Strn { get; set; }
        public string ISBN { get; set; }
    }
}
