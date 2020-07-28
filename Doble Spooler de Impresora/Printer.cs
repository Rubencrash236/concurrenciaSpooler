using System;
using System.Threading;

namespace Doble_Spooler_de_Impresora
{
    public class Printer
    {
        public bool ready { get; set; }
        public int id { get; set; }
        public int type { get; set; }
        public Thread print { get; set; }
        public Work myWork { get; set; }
        public bool printing;
        public Printer(int id, int type)
        {
            this.ready = true;
            this.id = id;
            this.type = type;
            this.printing = false;

            print = new Thread(startPrint);
        }

        public void startPrint()
        {   
            this.ready = false;
            if (this.printing && !this.ready)
            {
                if (this.type == 1)
                {
                    Console.SetCursorPosition(1,4);
                    Console.WriteLine("Printer tipo A: ");
                }
                else
                {
                    Console.SetCursorPosition(1, 8);
                    Console.WriteLine("Printer tipo B: ");
                }
                Console.WriteLine(this.myWork.work);
                
                this.printing = false;
                
            }
            
            this.ready = true;
        }

    }
}
