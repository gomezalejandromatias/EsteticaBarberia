using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TurnoNegocio
    {
          public List<Turno> ListaTurno()
          {
              List<Turno> turnos = new List<Turno>();


            

            turnos.Add(new Turno
            {
                IdTurno = 1,
                FechaTurno = new DateTime(2026, 1, 26),
                Estado = "Confirmado",
                HoraInicio = new TimeSpan(10, 0, 0),
                HoraFin = new TimeSpan(11, 0, 0),
                cliente = new Cliente { Nombre = "Matias Gomez" },
                Activo = true
            });

            turnos.Add(new Turno
            {
                IdTurno = 2,
                FechaTurno = new DateTime(2026, 1, 25),
                Estado = "Confirmado",
                HoraInicio = new TimeSpan(12, 0, 0),
                HoraFin = new TimeSpan(14, 0, 0),
                cliente = new Cliente { Nombre = "Juan Perez" },
                Activo = true
            });







            return turnos;
            





          }

        public void AgregarTurno(Turno turno)
        {






        }
          
         





    }
}
