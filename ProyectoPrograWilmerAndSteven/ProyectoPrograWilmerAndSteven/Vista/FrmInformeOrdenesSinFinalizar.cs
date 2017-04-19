using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograWilmerAndSteven.Datos;
using ProyectoPrograWilmerAndSteven.Reportes;
using Logica;

namespace ProyectoPrograWilmerAndSteven.Vista
{
    public partial class FrmInformeOrdenesSinFinalizar : Form
    {
        public FrmInformeOrdenesSinFinalizar()
        {
            InitializeComponent();
            this.cargarReporte();
        }

        private void cargarReporte()
        {
            OrdenTrabajoD pOrdenTrabajoD = new OrdenTrabajoD();
            rpInformeOrdenesPendientes oRpInformeOrdenesPendientes = new rpInformeOrdenesPendientes();
            oRpInformeOrdenesPendientes.SetDataSource(pOrdenTrabajoD.consultaInformeOrdenesPendientes());
            this.visorReporteOrden.ReportSource = oRpInformeOrdenesPendientes;

        }
    }
}
