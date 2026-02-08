using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TurnoListaDto
    {

        public int IdTurno { get; set; }
        public int IdCliente { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Estado { get; set; }

        public string Cliente { get; set; }
        public string Telefono { get; set; }

        public string Servicios { get; set; }
        public decimal Total { get; set; }





    }
}
