using Petpals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Repository
{
    internal interface Ipetshelterrepository
    {
        int addpet(Pets pets);

        int removepet(int id);

        List<Pets> getpet();

        List<Pets> getavailablepet(int available);
    }
}
