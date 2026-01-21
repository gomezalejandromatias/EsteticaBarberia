using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Portafolio
    {
        public int IdPortafolio {  get; set; }
        public string UrlImagen { get; set; }
        public string Titulo {  get; set; }
        public bool Activo {  get; set; }
        public TipoServicio TipoServicio { get; set; }






    }
}
