using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoServicioNegocio
    {

        public List<TipoServicio> ListaTipoServicio()
        {
            List<TipoServicio> lista = new List<TipoServicio>();

            lista.Add(new TipoServicio
            {
                IdTipoServicio = 1,
                TipoServico = 1,
                Servicio = "Corte de pelo",
                PrecioServicio = 4500,
                Activo = true
            });

            lista.Add(new TipoServicio
            {
                IdTipoServicio = 2,
                TipoServico = 2,
                Servicio = "Barba",
                PrecioServicio = 3000,
                Activo = true
            });

            lista.Add(new TipoServicio
            {
                IdTipoServicio = 3,
                TipoServico = 3,
                Servicio = "Alisado",
                PrecioServicio = 15000,
                Activo = true
            });



            return lista;





        }






    }
}
