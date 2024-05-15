using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Petpals.Repository
{
    internal interface Idonation
    {
        int cashdonation(string name,string type,decimal amount,DateTime dateTime,int id,string item);
        int itemdonation(string name, string type, decimal amount, DateTime dateTime, int id, string item);
    }
}
