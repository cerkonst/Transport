using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int marshrutAmount;
            int _Trans;
            TransPort Trans = new TransPort();


            marshrutAmount = rand.Next(15) + 5;

            Console.WriteLine("На данный момент существует следующие типы маршрута от точки А до точки Б: ");
            for (int i = 1; i <= marshrutAmount; i++)
            {
                _Trans = rand.Next(3) + 1;
                switch (_Trans)
                {
                    case 1:
                        Ecomon TPE = new Ecomon(rand.Next(5000), "Эконом класс ");
                        Trans.AddItemMarshrut_A_B_List(TPE);
                        Console.WriteLine("Класс маршрута = " + TPE.Name + " по цене: " + TPE.Price);
                        break;
                    case 2:
                        Business TPB = new Business(rand.Next(5000) + 10000, "Бизнес класс");
                        Trans.AddItemMarshrut_A_B_List(TPB);
                        Console.WriteLine("Класс маршрута = " + TPB.Name + " по цене: " + TPB.Price);
                        break;
                    case 3:
                        VIP TPV = new VIP(rand.Next(5000) + 50000, "Первый класс");
                        Trans.AddItemMarshrut_A_B_List(TPV);
                        Console.WriteLine("Класс маршрута = " + TPV.Name + " по цене: " + TPV.Price);
                        break;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("****************************************************** ");

            double Price = Trans.SumTotalPrice();
            Console.WriteLine("Общая стоимость всех типов маршрутов = " + Price);
            Console.ReadKey();
      

    }
}
}
