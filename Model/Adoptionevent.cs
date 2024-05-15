using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Model
{
    internal class Adoptionevent
    {
        List<Iadoptable> participants;

        public Adoptionevent() { }

        public Adoptionevent(List<Iadoptable> participants)
        {
            this.participants = participants;

        }

        public List<Iadoptable> Participants {  get { return participants; } set { participants = value; } }
    }
}
