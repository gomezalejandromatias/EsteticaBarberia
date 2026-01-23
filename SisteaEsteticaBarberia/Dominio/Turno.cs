using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {

        public int IdTurno { get; set; }
    
        public string Estado {  get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public  Cliente cliente { get; set; }
        
        public bool Activo { get; set; }



    }
}
