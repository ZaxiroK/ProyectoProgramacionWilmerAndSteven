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
        /// <summary>
        /// carga el rpInformeOrdenTrabajoFactura
        /// </summary>
        private void cargarReporte()
        {
            OrdenTrabajoD pOrdenTrabajoD = new OrdenTrabajoD();
            rpInformeOrdenTrabajoFactura orpInformeOrdenTrabajoFactura = new rpInformeOrdenTrabajoFactura();
            orpInformeOrdenTrabajoFactura.SetDataSource(pOrdenTrabajoD.consultaOrdenDeTrabajoReporte(this.numeroFactura));
            this.visorReporteOrden.ReportSource = orpInformeOrdenTrabajoFactura;
            
        }

        
    }
}
    
