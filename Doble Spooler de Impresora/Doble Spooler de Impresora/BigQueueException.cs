using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doble_Spooler_de_Impresora
{
    [Serializable()]
    public class BigQueueException : System.Exception
    {
        public BigQueueException()
        {
        }

        public BigQueueException(string message)
            : base(message)
        {
        }

        public BigQueueException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected BigQueueException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
