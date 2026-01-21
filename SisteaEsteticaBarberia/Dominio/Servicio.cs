using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        public int IdServicio { get; set; }
      public  List<TipoServicio> tipoServicios = new List<TipoServicio> { };
        public Turno Turno { get; set; }
        public Pago pago { get; set; }
        public decimal TotalServicio { get; set; } 
        public DateTime FechaServicio { get; set; }

        public Cliente Cliente { get; set; }
        public string ObservacionServicio { get; set; } = "";




    }
}
