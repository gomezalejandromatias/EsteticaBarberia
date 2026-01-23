using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteTurno
    {

        public int IdClienteTurno { get; set; }
      public Cliente Cliente { get; set; }
        public Turno Turno { get; set; }
        public TipoServicio TipoServicio { get; set; }


        public ClienteTurno()
        {
            Cliente = new Cliente();
            Turno = new Turno();
            TipoServicio = new TipoServicio();
        }



        public string NombreApellido
        {

            get { return Cliente != null ? Cliente.Nombre : ""; }
        }

        public string Telefono
        {
            get { return Cliente != null ? Cliente.Telefono : ""; }
        }

        public DateTime Horainicio
        {
            get { return Turno != null ? Turno.Inicio : DateTime.MinValue; }
                
                
        }
        public DateTime horafin
        {
            get { return Turno != null ? Turno.Fin : DateTime.MinValue; }


        }

    }
}
