using Logica;
using ProyectoPrograWilmerAndSteven.Datos;
using ProyectoPrograWilmerAndSteven.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograWilmerAndSteven.Vista
{
    public partial class FrmReporteOrdenDeTrabajo : Form
    {
        private int numeroFactura;
        private int oCedula;
        
        public FrmReporteOrdenDeTrabajo(int pIdOrdenDeTrabajo, int pCedula)
        {
            InitializeComponent();
            this.numeroFactura = pIdOrdenDeTrabajo;
            this.oCedula = pCedula;
            this.cargarReporte();
        }

        private void cargarReporte()
        {
            OrdenTrabajoD pOrdenTrabajoD = new OrdenTrabajoD();
            /*rpOrdenTrabajo oReporteOrdenTrabajo = new rpOrdenTrabajo();
            oReporteOrdenTrabajo.SetDataSource(pOrdenTrabajoD.consultaOrdenDeTrabajoReporte(this.numeroFactura));

            this.visorReporteOrden.ReportSource = oReporteOrdenTrabajo;*/



            ClienteD pClienteD = new ClienteD();
            rpOrdenDeServicio orpOrdenDeServicio = new rpOrdenDeServicio();
            orpOrdenDeServicio.SetDataSource(pOrdenTrabajoD.consultaOrdenDeTrabajoReporte(this.numeroFactura));
            this.visorReporteOrden.ReportSource = orpOrdenDeServicio;
            /*orpOrdenDeServicio.SetDataSource(pClienteD.consultaClienteReporte(this.oCedula));
            this.visorReporteOrden.ReportSource = orpOrdenDeServicio;*/
        }

        
    }
}
    
