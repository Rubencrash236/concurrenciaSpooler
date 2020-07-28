using System;
using System.Threading;
using System.Collections;
using static Doble_Spooler_de_Impresora.Work;
using static Doble_Spooler_de_Impresora.Printer;




namespace Doble_Spooler_de_Impresora
{
    class Program
    {
        static Printer[] printers;
        static void Main(string[] args)
        {

            Stack[] works = new Stack[3]; 
            Console.WriteLine("Cantidad de impresoras tipo A: ");
            int typeA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de impresoras tipo B: ");
            int typeB = Int32.Parse(Console.ReadLine());
            printers = new Printer[typeA + typeB];

            //works[0].push(elemento); <-- para el tipo a :v y ya tu sabe pa losotro ;3

            for(int i = 0; i < typeA; i++)
            {
                printers[i] = new Printer(i, 1);
            }
            for(int i= typeA - 1; i < printers.Length; i++)
            {
                printers[i] = new Printer(i, 2);
            }
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



    }
}
