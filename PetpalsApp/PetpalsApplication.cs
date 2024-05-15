using Petpals.Model;
using Petpals.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Petpals.PetpalsApp
{
    internal class PetpalsApplication
    {
        IPetshelterservice petshelterservice;

        CashDonation cashDonation=new CashDonation();
        ItemDonation ItemDonation=new ItemDonation();

        public PetpalsApplication()
        {
            petshelterservice=new Petshelterservice();
        }

        public void run()

        {
            Console.WriteLine("*********WELCOME TO PETPALS*********");
            start:
            Console.WriteLine("1.Pet management\n.2.Donation Mangement");
            try
            {
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("1.View available pets for adoption\n2.Add pet\n3.Remove pet\n.4.View all pets");
                            int opt = int.Parse(Console.ReadLine());
                            {
                                switch (opt)
                                {
                                    case 1:
                                        petshelterservice.getavilablepet();
                                        break;
                                    case 2:
                                        petshelterservice.addpet();
                                        break;
                                    case 3:
                                        petshelterservice.removepet();
                                        break;
                                    case 4:
                                        petshelterservice.getpet();
                                        break;

                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("1.CashDonation\n2.ItemDonation");
                            int opt = int.Parse(Console.ReadLine());
                            {
                                switch (opt)
                                {
                                    case 1:
                                        cashDonation.RecordDonation();
                                        break;
                                    case 2:
                                        ItemDonation.RecordDonation();
                                        break;
                                }
                            }
                            break;
                        }
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                goto start;
            }

        }
    }
}
