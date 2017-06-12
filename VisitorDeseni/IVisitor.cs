using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDeseni
{
    public interface IVisitor
    {
        void Visit(Tablet tablet);
    }
}
