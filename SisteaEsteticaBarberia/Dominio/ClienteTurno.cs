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

        public List<Servicio> servicios = new List<Servicio>(); 


        public ClienteTurno()
        {
            Cliente = new Cliente();
            
            
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
        public string ServiciosTexto
        {
            get
            {
                if (servicios == null || servicios.Count == 0)
                    return "";

                string texto = "";

                for (int i = 0; i < servicios.Count; i++)
                {
                    texto += servicios[i].ServiciosTexto;

                    if (i < servicios.Count - 1)
                        texto += " | ";
                }

                return texto;
            }
        }








    }
}
