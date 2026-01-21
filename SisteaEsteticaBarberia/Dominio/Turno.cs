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
        public DateTime FechaTurno { get; set; }
        public string Estado {  get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin {  get; set; }
        public  Cliente cliente { get; set; }
        
        public bool Activo { get; set; }



    }
}
