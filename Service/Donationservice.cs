using Petpals.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Service
{
    internal class Donationservice : IDonationservice
    {
        readonly Idonation _idonation;

        public Donationservice(){
            _idonation = new donationrepository();
            }
        public void cashdonation()
        {
            Console.WriteLine("Enter name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter type of donation:");
            string type=Console.ReadLine();
            Console.WriteLine("Enter amount");
            decimal amount=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter donation item:");
            string item=Console.ReadLine();
            Console.WriteLine("Enter date");
            DateTime dateTime=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter shelterid:");
            int id=int.Parse(Console.ReadLine());
            int check=_idonation.cashdonation(name,type,amount,dateTime,id,item);
            if (check > 0)
            {
                Console.WriteLine("Added");
            }
        }

        public void itemdonation()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter type of donation:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter donation item:");
            string item = Console.ReadLine();
            Console.WriteLine("Enter date");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter shelterid:");
            int id = int.Parse(Console.ReadLine());
            int check = _idonation.itemdonation(name, type, amount, dateTime, id, item);
            if (check > 0)
            {
                Console.WriteLine("Added");
            }
        }
    }
}
