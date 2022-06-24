using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika1
{
    class Program
    {
        struct Train : IComparable<Train>
        {
            public string DestinationPoint;
            public int Num;
            public DateTime TimeOfGo;
            public Train(string d, int n, DateTime t)
            {
                DestinationPoint = d;
                Num = n;
                TimeOfGo = t;
            }
            public int CompareTo(Train other)
            {
                return Num - other.Num;
                //throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            string d;
            int n;
            DateTime t;
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите пункт назначения: ");
                d = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Введите номер: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите дату отправления: ");
                t = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine();
                trains[i] = new Train(d, n, t);
            }
            Array.Sort(trains);
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("пункт назначения: " + trains[i].DestinationPoint + "номер: " + trains[i].Num + "дата отправления: " + trains[i].TimeOfGo + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Введите номер поезда: ");
            int nomer = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].Num == nomer)
                {
                    Console.Write("пункт назначения: " + trains[i].DestinationPoint + "номер: " + trains[i].Num + "дата отправления: " + trains[i].TimeOfGo + " ");
                }
                else
                {
                    Console.WriteLine("Поезд не найден");
                }
            }
            Console.ReadKey();
        }
    }

}
