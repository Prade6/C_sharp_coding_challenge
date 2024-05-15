using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Model
{
    internal class Cat:Pets
    {
        string catcolor;

        public Cat() { }
        public Cat(string color)
        {
            this.catcolor = color;
        }   

        public string Catcolor { get { return catcolor; } set { catcolor=value; } }
        public override string ToString() { return catcolor; }
    }
}
