using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisteaEsteticaBarberia
{
    public partial class FrmHistorialTurnos : Form
    {
     private         TipoServicio TipoServicio;

     private   List<TipoServicio> ListaServicio = new List<TipoServicio>();


        public FrmHistorialTurnos()
        {
            InitializeComponent();
        }

        private void FrmHistorialTurnos_Load(object sender, EventArgs e)
        {
            CargarGrillaTerminado();
            CargarGrillaNoAsistio();
            CargarGrillaCancelado();
             



        }
        
        public void CargarGrillaTerminado()
        {


              

             TurnoNegocio turnoNegocio = new TurnoNegocio();

           


       
            var turnos = turnoNegocio.ListaHistorial("Terminado");



            List<TurnoListaDto> grilla = new List<TurnoListaDto>();

            foreach (var t in turnos)
            {
                foreach (var ct in t.clienteTurnos)
                {
                    // juntar todos los TipoServicio del cliente (de todos los "Servicio" que tenga)
                    List<string> nombresServicios = new List<string>();
                    decimal total = 0;

                    foreach (var s in ct.servicios)
                    {
                        foreach (var ts in s.tipoServicios)
                        {
                            // evitar repetidos
                            if (nombresServicios.Contains(ts.Servicio) == false)
                                nombresServicios.Add(ts.Servicio);

                            total += ts.PrecioServicio;
                        }
                    }

                    string serviciosTexto = string.Join(", ", nombresServicios);

                    grilla.Add(new TurnoListaDto
                    {
                        IdTurno = t.IdTurno,
                        Inicio = t.Inicio,
                        Fin = t.Fin,
                        Estado = t.Estado,
                        IdCliente = ct.Cliente.IdCliente,
                        Cliente = ct.Cliente.Nombre,
                        Telefono = ct.Cliente.Telefono,
                        Servicios = serviciosTexto,
                        Total = total
                    });
                }
            }

            dgvTurnosTerminados.DataSource = null;
            dgvTurnosTerminados.DataSource = grilla;



        }

        public void CargarGrillaNoAsistio()
        {

            TurnoNegocio turnoNegocio = new TurnoNegocio();





            var turnos = turnoNegocio.ListaHistorial("No Asistio");



            List<TurnoListaDto> grilla = new List<TurnoListaDto>();

            foreach (var t in turnos)
            {
                foreach (var ct in t.clienteTurnos)
                {
                    // juntar todos los TipoServicio del cliente (de todos los "Servicio" que tenga)
                    List<string> nombresServicios = new List<string>();
                    decimal total = 0;

                    foreach (var s in ct.servicios)
                    {
                        foreach (var ts in s.tipoServicios)
                        {
                            // evitar repetidos
                            if (nombresServicios.Contains(ts.Servicio) == false)
                                nombresServicios.Add(ts.Servicio);

                            total += ts.PrecioServicio;
                        }
                    }

                    string serviciosTexto = string.Join(", ", nombresServicios);

                    grilla.Add(new TurnoListaDto
                    {
                        IdTurno = t.IdTurno,
                        Inicio = t.Inicio,
                        Fin = t.Fin,
                        Estado = t.Estado,
                        IdCliente = ct.Cliente.IdCliente,
                        Cliente = ct.Cliente.Nombre,
                        Telefono = ct.Cliente.Telefono,
                        Servicios = serviciosTexto,
                        Total = total
                    });
                }
            }

            dgvNoAsistio.DataSource = null;
            dgvNoAsistio.DataSource = grilla;




        }

        public void CargarGrillaCancelado()
        {
            TurnoNegocio turnoNegocio = new TurnoNegocio();





            var turnos = turnoNegocio.ListaHistorial("Cancelado");



            List<TurnoListaDto> grilla = new List<TurnoListaDto>();

            foreach (var t in turnos)
            {
                foreach (var ct in t.clienteTurnos)
                {
                    // juntar todos los TipoServicio del cliente (de todos los "Servicio" que tenga)
                    List<string> nombresServicios = new List<string>();
                    decimal total = 0;

                    foreach (var s in ct.servicios)
                    {
                        foreach (var ts in s.tipoServicios)
                        {
                            // evitar repetidos
                            if (nombresServicios.Contains(ts.Servicio) == false)
                                nombresServicios.Add(ts.Servicio);

                            total += ts.PrecioServicio;
                        }
                    }

                    string serviciosTexto = string.Join(", ", nombresServicios);

                    grilla.Add(new TurnoListaDto
                    {
                        IdTurno = t.IdTurno,
                        Inicio = t.Inicio,
                        Fin = t.Fin,
                        Estado = t.Estado,
                        IdCliente = ct.Cliente.IdCliente,
                        Cliente = ct.Cliente.Nombre,
                        Telefono = ct.Cliente.Telefono,
                        Servicios = serviciosTexto,
                        Total = total
                    });
                }
            }

            dgvCancelado.DataSource = null;
            dgvCancelado.DataSource = grilla;





        }

        private void btnSeleccionarTurno_Click(object sender, EventArgs e)
        {
               TurnoNegocio turnoNegocio = new TurnoNegocio();

               DateTime elegirfecha = dtpElegirFechaTurnoTerminado.Value.Date;

            var listafiltrada = turnoNegocio.ListaHistorial("Terminado");


         
                var   turno =  listafiltrada.Where (x => x.Inicio.Date == elegirfecha).ToList();



            


            dgvTurnosTerminados.DataSource = null;
            dgvTurnosTerminados.DataSource = turno;


        }

        private void btnNoAsistio_Click(object sender, EventArgs e)
        {
            TurnoNegocio turnoNegocio = new TurnoNegocio();

            DateTime elegirfecha = dtpFechaNoAsistio.Value.Date;

            var listafiltrada = turnoNegocio.ListaHistorial("No Asistio");



            var turno = listafiltrada.Where(x => x.Inicio.Date == elegirfecha).ToList();






            dgvTurnosTerminados.DataSource = null;
            dgvTurnosTerminados.DataSource = turno;
        }

        private void btnCancelado_Click(object sender, EventArgs e)
        {
            TurnoNegocio turnoNegocio = new TurnoNegocio();

            DateTime elegirfecha =   dtpFechaTurnoCancelado.Value.Date;

            var listafiltrada = turnoNegocio.ListaHistorial("Cancelado");



            var turno = listafiltrada.Where(x => x.Inicio.Date == elegirfecha).ToList();






            dgvTurnosTerminados.DataSource = null;
            dgvTurnosTerminados.DataSource = turno;
        }
    }
}
