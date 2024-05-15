using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Model
{
    internal class PetShelter:Pets
    {
        List<Pets> availablepets;
        int shelterid;
        string name;
        string location;



        public PetShelter() { }

        public PetShelter(List<Pets> availablepets)
        {
            availablepets = availablepets;

        }

        public List<Pets> Availablepets { get { return availablepets; } set { availablepets = value; } }
        public string Location { get { return location; } set { location = value; } }
        public int Shelterid { get {  return shelterid; } set {  shelterid = value; } }
        public string Name { get { return name; } set { } }
    }
}
