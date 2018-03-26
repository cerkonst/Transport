using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Ecomon : AbstractMarshrut_A_B
    {
        public Ecomon(double p, string m) : base(p, m) { }

        private int _ticketCount;

        public int TicketCount
        {
            get { return _ticketCount; }
            set { _ticketCount = value; }
        }

    }
}
