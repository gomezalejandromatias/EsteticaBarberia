using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HistorialCliente
    {
        public int IdHistorialCliente { get; set; }
        public Servicio servicio { get; set; }
        public string Observacion { get; set; }
        public Turno Turno { get; set; }
        public Cliente cliente { get; set; }
        public DateTime FechaHora { get; set; }






    }
}
