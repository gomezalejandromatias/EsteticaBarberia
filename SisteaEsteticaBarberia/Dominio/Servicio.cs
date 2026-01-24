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

        public string ServiciosTexto
        {
            get
            {
                if (tipoServicios == null || tipoServicios.Count == 0) return "";

                string texto = "";
                for (int i = 0; i < tipoServicios.Count; i++)
                {
                    texto += tipoServicios[i].Servicio;
                    if (i < tipoServicios.Count - 1) texto += ", ";
                }
                return texto;
            }
        }



    }
}
