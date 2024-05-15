using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Model
{
    internal abstract class Donation
    {
        string donarname;
        decimal price;

        public Donation() { }
        public Donation(string donarname, decimal price)
        {
            this.donarname = donarname;
            this.price = price;
        }

        public string Donarname { get {  return donarname; } set { donarname = value; } }

        public abstract void RecordDonation();
    }
}
