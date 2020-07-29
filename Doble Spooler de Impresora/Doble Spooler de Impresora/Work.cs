using System;
using System.Collections;


namespace Doble_Spooler_de_Impresora
{
    public class Work
    {
        public int type { get; set; }
        public String work { get; set; }
        public Work(int type, String work)
        {
            this.type = type;
            this.work = work;
        }
    }
}
