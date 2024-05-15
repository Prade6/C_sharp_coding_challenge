using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Model
{
    public class Pets
    {
        string name;
        int age;
        string breed;
        string type;
        int available;
        int owner_id;

 //       • Constructor to initialize Name, Age, and Breed.


        public Pets() { }    

        public Pets(string name, int age, string breed) 
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
        }

    //    • Getters and setters for attributes.
        public string Name {  get { return name; } set {  name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Breed { get {  return breed; } set {  breed = value; } }

        public string Type { get { return type; } set { type = value; } }   
        public int Available { get { return available; } set { available = value; } }
        public int Owner_id { get { return owner_id; } set { owner_id = value; } }

      //  • ToString() method to provide a string representation of the pet.
        public override string ToString() { return name; }
    }
}
