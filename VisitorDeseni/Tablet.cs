using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDeseni
{
    public abstract class Tablet
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public Tablet(string model, string brand) {
            Model = model;
            Brand = brand;
        }

        public abstract void Accept(IVisitor Visitor);
    }
}
