using System;
using System.Threading;
using System.Collections;


namespace Doble_Spooler_de_Impresora
{
    class Program
    {
        static ArrayList primary;
        static ArrayList secundary;

        static void Main(string[] args)
        {
            primary = new ArrayList();
            secundary = new ArrayList();
            Thread Pspooler = new Thread(getPetitionPrimary);
            Thread Sspooler = new Thread(getPetitionSecundary);

            Pspooler.Start();
            Sspooler.Start();
        }

        static void getPetitionPrimary()
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

                Console.Write("spooler 1: " + primary[0] + " \n");
                primary.RemoveAt(0);
                Thread.Sleep(500);
            }
            
        }

        static void getPetitionSecundary()
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

        static void createThreads(int sizeA, int sizeB)
        {
            for(int i = 0; i < sizeA; i++)
            {

            }
        }
    }
}
