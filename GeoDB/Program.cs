using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoDB
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //open the database
            LookupService ls = new LookupService("/usr/local/share/GeoIP/GeoIP.dat", LookupService.GEOIP_MEMORY_CACHE);
            //get country of the ip address
            Country c = ls.getCountry("24.24.24.24");
            Console.Write(" code: " + c.getCode() + "\n");
            Console.Write(" name: " + c.getName() + "\n");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
