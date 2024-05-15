using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Exception
{
    internal class Datainvalidexception:ApplicationException
    {
        public Datainvalidexception(string message) : base(message) { }
    }
}
