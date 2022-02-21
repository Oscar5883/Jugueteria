using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Resultado
    {
        public string MensajePersonalizado { get; set; }
        public string MensajeSistema { get; set; }
        public  Result Result { get; set; }
    }
    public enum Result
    { 
        OK=1,
        Error=0
    }
}
