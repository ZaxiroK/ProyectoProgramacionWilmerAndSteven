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
        
        public FrmReporteOrdenDeTrabajo(int pIdOrdenDeTrabajo)
        {
            InitializeComponent();
            this.numeroFactura = pIdOrdenDeTrabajo;
            this.cargarReporte();
        }

        private void cargarReporte()
        {
            OrdenTrabajoD pOrdenTrabajoD = new OrdenTrabajoD();

            rpOrdenDeTrabajo oReporteOrdenTrabajo = new rpOrdenDeTrabajo();
            oReporteOrdenTrabajo.SetDataSource(pOrdenTrabajoD.consultaOrdenDeTrabajoReporte(this.numeroFactura));

            this.visorReporteOrden.ReportSource = oReporteOrdenTrabajo;
        }

        
    }
}
    
