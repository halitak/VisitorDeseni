using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipad ipad = new Ipad("IPad mini", "Apple");
            GalaxyTab galaxyTab = new GalaxyTab("GalaxyTab","Samsung");

            ipad.Accept(new WifiVisitor());
            galaxyTab.Accept(new WifiVisitor());

            ipad.Accept(new TreeGVisitor());
            galaxyTab.Accept(new TreeGVisitor());

            Console.ReadKey();

        }
    }
}
