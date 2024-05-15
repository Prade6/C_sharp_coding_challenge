using Petpals.Repository;
using Petpals.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Model
{
    internal class CashDonation:Donation
    {
        IDonationservice service = new Donationservice();

        DateTime donationDate;

        public CashDonation() { }

        public CashDonation(DateTime donationDate)
        {
            donationDate = donationDate;
        }

        public DateTime DonationDate { get { return donationDate; } set { donationDate = value; } }

        public override void RecordDonation()
        {
            service.cashdonation();
        }
    }
}
