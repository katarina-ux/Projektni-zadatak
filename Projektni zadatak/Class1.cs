using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektni_zadatak
{
    public static class Admin
    {
        public static void UnosZivotinja(string zapis)
        {
          StreamWriter sw = new StreamWriter("zivotinje.txt", true);
            sw.WriteLine(zapis);
            sw.Close();

        }
    }
}
