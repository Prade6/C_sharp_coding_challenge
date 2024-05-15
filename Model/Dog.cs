using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Model
{
    internal class Dog:Pets
    {
        string dogbreed;

        public Dog() { }

        public Dog(string dogbreed)
        {
            this.dogbreed = dogbreed;
        }

        public string Dogbreed {  get { return this.dogbreed; } set { this.dogbreed = value;} }

        public override string ToString() { return dogbreed; }
    }
}
