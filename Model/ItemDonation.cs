using Petpals.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Model
{
    internal class ItemDonation:Donation
    {
        IDonationservice service = new Donationservice();
        string itemtype;

        public ItemDonation() { }
        public ItemDonation(string itemtype)
        {
            this.itemtype = itemtype;
        }
        public string Itemtype {  get { return this.itemtype; } set { itemtype = value; } }

        public override void RecordDonation()
        {
            service.itemdonation();
        }
    }
}
