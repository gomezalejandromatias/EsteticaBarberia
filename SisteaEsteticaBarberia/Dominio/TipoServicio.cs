using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoServicio
    {
        public int IdTipoServicio { get; set; }
       
        public decimal PrecioServicio { get; set; }

        public string Servicio { get; set; }
        public bool Activo { get; set; }


        public override string ToString()
        {
            return Servicio ;
        }

    }
}
