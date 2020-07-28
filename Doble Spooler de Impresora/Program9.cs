using System;
using System.Threading;
using System.Collections;
using static Doble_Spooler_de_Impresora.Work;
using static Doble_Spooler_de_Impresora.Printer;




namespace Doble_Spooler_de_Impresora
{
    class Program
    {   
        static Queue works = new Queue();
        static Printer[] printers;
        static void Main(string[] args)
        {
            int typeA, typeB;
            Thread printing = new Thread(startPrint(works));

            Console.WriteLine("Cantidad de impresoras tipo A: ");
            typeA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de impresoras tipo B: ");
            typeB = Int32.Parse(Console.ReadLine());
            printers = new Printer[typeA + typeB];

            for(int i = 0; i < typeA; i++)
            {
                printers[i] = new Printer(i, 1);
            }
            for(int i= typeA; i < printers.Length; i++)
            {
                printers[i] = new Printer(i, 2);
            }

            ///Agregar trabajo a la queue...tal vez con hilos
            ///Ya la funcion AddWork() está hecha

            printing.start();
 
        }

        static void searchPrinter(Work myWork)
        {
            
            while (true)
            {
                foreach (Printer printer in printers)
                {
                    if (printer.ready && (printer.type == myWork.type || myWork.type == 3))
                    {
                        printer.myWork = myWork;
                        printer.print.Start();
                       
                    }
                }
            }
        }
        
        static void startPrint(Queue work)
        {
            while (true)
            {
                searchPrinter(work.Dequeue);
            }
        }

        //Agrega un trabajo a la queue

        static void addWork(Work myWork)
        {
            works.Enqueue(myWork);
        }

    }
}
