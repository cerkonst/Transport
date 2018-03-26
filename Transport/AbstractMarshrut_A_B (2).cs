using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public abstract class AbstractMarshrut_A_B
    {
        private double _price;
        private string _name;
        public AbstractMarshrut_A_B(double p, string n)
        {
          
            this._price = p;
            this._name = n;
        }

         public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
