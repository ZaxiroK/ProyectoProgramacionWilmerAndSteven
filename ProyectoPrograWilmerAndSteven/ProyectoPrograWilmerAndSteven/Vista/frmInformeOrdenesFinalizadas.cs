using ProyectoPrograWilmerAndSteven.Datos;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograWilmerAndSteven.Reportes;

namespace ProyectoPrograWilmerAndSteven.Vista
{
    
    public partial class frmInformeOrdenesFinalizadas : Form
    {
        
        public frmInformeOrdenesFinalizadas()
        {
            InitializeComponent();
            
            this.cargarReporte();
        }
        /// <summary>
        /// Carga el rpInformeOrdenesFinalizadasPorDia
        /// </summary>
        private void cargarReporte()
        {
            OrdenTrabajoD pOrdenTrabajoD = new OrdenTrabajoD();
            rpInformeOrdenesFinalizadasPorDia oRpInformeOrdenesFinalizadas = new rpInformeOrdenesFinalizadasPorDia();
            oRpInformeOrdenesFinalizadas.SetDataSource(pOrdenTrabajoD.consultaOrdenesFinalizadas());
            this.visorReporteOrden.ReportSource = oRpInformeOrdenesFinalizadas;

        }
    }
}
