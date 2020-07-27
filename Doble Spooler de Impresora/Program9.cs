using System;
using System.Threading;
using System.Collections;


namespace Doble_Spooler_de_Impresora
{
    class Program
    {
        static Stack primary;
        static Stack secundary;

        static void Main(string[] args)
        {
            primary = new Stack();
            secundary = new Stack();
            Console.WriteLine("Cantidad de impresoras tipo A: ");
            int typeA = Console.ReadLine();
            Console.WriteLine("Cantidad de impresoras tipo B: ");
            int typeB = Console.ReadLine();
            Thread picker = new Thread(pick);
            Thread[] Pspooler = new Thread[sizeA](imprimir_A);
            Thread[] Sspooler = new Thread[sizeB](imprimir_B);

            Pspooler.Start();
            Sspooler.Start();
        }

        static void imprimir_A()
        {
            while (true)
            {
                if(primary.Count == 10)
                {
                    Thread.Sleep(2000);
                }
                else if(primary.Count < 10)
                {
                    primary.Add(Console.ReadKey().KeyChar);
                    Thread.Sleep(500);
                }

                Console.Write("spooler 1: " + primary.Pop().ToString() + " \n");
                
                Thread.Sleep(500);
            }
            
        }

        static void imprimir_B()
        {
            while (true)
            {
                Thread.Sleep(500);
                secundary.Add(Console.ReadKey().KeyChar);
                if (secundary.Count > 0)
                {
                    Console.Write("spooler 2:" + secundary[0] + " \n");
                    secundary.RemoveAt(0);
                }

                Thread.Sleep(1000);
            }
        }

        static void printing()
        {

        }

        static void pick()
        {
            Console.WriteLine();
            primary.Push(Console.ReadKey().KeyChar);
            Console.Clear();
            Thread.Sleep(10000);
        }
    }
}
