using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Business: AbstractMarshrut_A_B
    {
        public Business(double p, string m) : base(p, m) { }

        private int _time;

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

    }
}
