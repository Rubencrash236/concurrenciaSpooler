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
            Thread printing = new Thread(startPrint);
            Thread worker = new Thread(workGenerator);

            Console.WriteLine("Cantidad de impresoras tipo A: ");
            typeA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de impresoras tipo B: ");
            typeB = Int32.Parse(Console.ReadLine());
            Console.Clear();
            worker.Start();
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

            printing.Start();
 
        }

        static void searchPrinter(Work myWork)
        {
            
            while (true)
            {
                foreach (Printer printer in printers)
                {
                    if (myWork != null && printer.ready && (printer.type == myWork.type || myWork.type == 3))
                    {
                        printer.myWork = myWork;
                        myWork = null;
                        printer.printing = true;
                        printer.startPrint();
                        break;
                    }
                }
            }
        }
        
        static void startPrint()
        {
            while (true)
            {
                if (works.Count != 0) 
                {
                    searchPrinter((Work)works.Dequeue());
                }
                else
                {
                    continue;
                }
            }
        }

        static void workGenerator()
        {
            Work work = new Work(4, null);
            while (true)
            {
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("Tipo de trabajo: TipoA(1), TipoB(2), TipoC(3) : ");
                Console.SetCursorPosition(50, 3);
                work.type = Int32.Parse(Console.ReadLine());
                Console.SetCursorPosition(50, 4);
                Console.WriteLine("Mensaje: ");
                Console.SetCursorPosition(50,5);
                work.work = Console.ReadLine();
                addWork(work);
                work = null;
            }
        }

        //Agrega un trabajo a la queue

        static void addWork(Work myWork)
        {
            works.Enqueue(myWork);
        }

    }
}
