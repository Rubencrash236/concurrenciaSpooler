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
        public Printer(int id, int type)
        {
            this.ready = true;
            this.id = id;
            this.type = type;
            print = new Thread(startPrint);
        }

        public void startPrint()
        {   
            this.ready = false;
            Console.WriteLine(this.myWork.work);
            this.ready = true;
            print.Abort();
        }

    }
}
