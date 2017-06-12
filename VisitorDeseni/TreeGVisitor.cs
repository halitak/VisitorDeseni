using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDeseni
{
    class TreeGVisitor:IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if (tablet is Ipad)
            {
                Console.WriteLine("IPad does not have 3G option");
            }
            else if (tablet is GalaxyTab)
            {
                Console.WriteLine("GalaxyTab 3G has open");
            }
            else
                Console.WriteLine("this object is not a Tablet");
        }
    }
}
