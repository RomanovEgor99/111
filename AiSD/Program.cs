using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] arrayOfUint = new uint[10];
            Console.WriteLine("Одномерный массив беззнаковых целых чисел: ");
            foreach (uint i in arrayOfUint)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine("\nСтатический одномерный массив символов:");
            char[] arrayOfChar = new char[10];
            foreach (char j in arrayOfUint)
            {
                Console.Write(" {0}", j);
            }
            int[,,] arrayOfInt = new int[10, 10, 3];
            Console.WriteLine("\nТрехмерный массив целых чисел:");

            for (int k = 0; k < 3; k++)
            {
                Console.Write("Массив №{0} \n", k);
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("{0}, ", arrayOfInt[i, j, k]);

                    }
                    Console.WriteLine();

                }
                Console.WriteLine("\n");
            }
            Random rand = new Random();
            Console.WriteLine("Одномерный массив беззнаковых целых чисел: ");
            foreach (uint i in arrayOfUint)
            {
                arrayOfUint[i] = (uint)rand.Next(1, 99);
            }
            foreach (uint i in arrayOfUint)
            {
                Console.Write(" {0}", i);
            }
            Console.ReadLine();
        }
    }
}
