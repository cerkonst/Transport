using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class TransPort
    {
        private int MarshrutAmount = 0;
        private double sumPrice = 0;
        PriceSum calculator = new PriceSum();


        public List<AbstractMarshrut_A_B> Marshrut_A_B_List = new List<AbstractMarshrut_A_B>();

        public double SumTotalPrice()
        {
            for (int i = 0; i < Marshrut_A_B_List.Count; i++)
            {
                sumPrice = sumPrice + calculator.GetPrice(Marshrut_A_B_List[i]);
            }
            return sumPrice;
        }

        public int GetItemMarshrut_A_B_List(AbstractMarshrut_A_B _Marshrut_A_B)
        {
            return Marshrut_A_B_List.IndexOf(_Marshrut_A_B);
        }

        public void AddItemMarshrut_A_B_List(AbstractMarshrut_A_B _Marshrut_A_B)
        {
            Marshrut_A_B_List.Add(_Marshrut_A_B);
            MarshrutAmount += 1;
        }
        public void DeleteItemMarshrut_A_B_List(AbstractMarshrut_A_B _Marshrut_A_B)
        {
            Marshrut_A_B_List.Remove(_Marshrut_A_B);
            MarshrutAmount -= 1;
        }

    }
}
