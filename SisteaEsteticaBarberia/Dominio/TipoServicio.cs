using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoServicio
    {
        public int TipoServico { get; set; }
        public decimal PrecioServicio { get; set; }

        public string Observacion { get; set; }
       public Servicio Servicio { get; set; }
        public bool Activo { get; set; }




    }
}
