using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDeseni
{
    class WifiVisitor:IVisitor
    {

        public void Visit(Tablet tablet)
        {
            if (tablet is Ipad)
            {
                Console.WriteLine("IPad Wifi has open");
            }
            else if (tablet is GalaxyTab)
            {
                Console.WriteLine("GalaxyTab does not have wifi option");
            }
            else
                Console.WriteLine("this object is not a Tablet");
        }
    }
}
