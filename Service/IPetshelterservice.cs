using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Service
{
    internal interface IPetshelterservice
    {
        void addpet();
        void removepet();

        void getpet();

        void getavilablepet();
    }
}
