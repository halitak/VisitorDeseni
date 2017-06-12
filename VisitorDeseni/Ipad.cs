using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDeseni
{
    public class Ipad:Tablet
    {
        public Ipad(string model, string brand) : base(model, brand) { }

        public override void Accept(IVisitor Visitor)
        {
            Visitor.Visit(this);
        }
    }
}
