using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class VIP: AbstractMarshrut_A_B
    {

        public VIP(double p, string m) : base(p, m) { }

        private int _personalTmeStart;

        public int PersonalTmeStart
        {
            get { return _personalTmeStart; }
            set { _personalTmeStart = value; }
        }
    }
}
