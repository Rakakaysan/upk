using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upk
{
    internal class Koneksi
    {
        public static string conn = "" +
            "Data source = LAPTOP-82FOTN2U\\SQLEXPRESS01; " +
            "Initial Catalog = upk; " +
            "Integrated Security = True; " +
            "TrustServerCertificate = True ; " ;
    }

    public class Model
    {
        public static string name { get; set; }
    }
}
