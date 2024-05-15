using Petpals.Exception;
using Petpals.Model;
using Petpals.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Petpals.Service
{
    internal class Petshelterservice:IPetshelterservice
    {
        readonly Ipetshelterrepository repository;

        Pets pets=new Pets();

        public Petshelterservice()
        {
            repository = new petshelterrepository();
        }

        public void addpet()
        {
            try
            {
                Console.WriteLine("Enter pet name:");
                pets.Name = Console.ReadLine();
                if (pets.Name.Any(char.IsDigit) || pets.Name.Any(char.IsSymbol))
                {
                    throw new Datainvalidexception("Name contain only alphabets");
                }
                Console.WriteLine("Enter pet age:");
                pets.Age = int.Parse(Console.ReadLine());
                if(pets.Age<0)
                {
                    throw new Datainvalidexception("Age can't be negative;");
                }
                Console.WriteLine("Enter breed:");
                pets.Breed = Console.ReadLine();
                if (pets.Breed.Any(char.IsDigit) || pets.Breed.Any(char.IsSymbol))
                {
                    throw new Datainvalidexception("Name contain only alphabets");
                }
                Console.WriteLine("Enter type:");
                pets.Type = Console.ReadLine();
                Console.WriteLine("Enter available for adoption:");
                pets.Available = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter owner id:");
                pets.Owner_id = int.Parse(Console.ReadLine());
                if (pets.Owner_id < 1)
                {
                    throw new Datainvalidexception("Employee id can't be negative");
                }

                int a = repository.addpet(pets);

                if (a > 0)
                {
                    Console.WriteLine("Pet added");
                }
            }
            catch(Datainvalidexception e)
            {
                Console.WriteLine(e.Message);
            }
             catch(System.Exception e)
               {
                Console.WriteLine(e.Message);
            }


        }

        public void removepet()
        {
            try
            {
                Console.WriteLine("Enter pet id:");
                int id = int.Parse(Console.ReadLine());
                if (id < 1)
                {
                    throw new Datainvalidexception("Employee id can't be negative");
                }
                int s = repository.removepet(id);
                if (s > 0)
                {
                    Console.WriteLine("Pet removed");
                }
            }
            catch (Datainvalidexception e)
            {
                Console.WriteLine(e.Message);
            }

            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void getpet()
        {
            try
            {
                List<Pets> s = repository.getpet();
                foreach (Pets item in s)
                {
                    Console.WriteLine(item);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

        public void getavilablepet()
        {
            try
            {
                Console.WriteLine("Enter available for adoption:");
                int available = int.Parse(Console.ReadLine());
                List<Pets> s = repository.getavailablepet(available);
                foreach (Pets item in s)
                {
                    Console.WriteLine(item);
                }

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
