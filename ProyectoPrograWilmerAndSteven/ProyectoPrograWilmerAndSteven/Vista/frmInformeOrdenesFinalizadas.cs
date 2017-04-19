using ProyectoPrograWilmerAndSteven.Datos;
using ProyectoPrograWilmerAndSteven.Reportes;
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


namespace ProyectoPrograWilmerAndSteven.Vista
{
    
    public partial class frmInformeOrdenesFinalizadas : Form
    {
        //private char estado;
        public frmInformeOrdenesFinalizadas()
        {
            InitializeComponent();
            //this.estado = 'S';
            this.cargarReporte();
        }

        private void cargarReporte()
        {
            OrdenTrabajoD pOrdenTrabajoD = new OrdenTrabajoD();
            rpInformeOrdenesFinalizadas oRpInformeOrdenesFinalizadas = new rpInformeOrdenesFinalizadas();
            oRpInformeOrdenesFinalizadas.SetDataSource(pOrdenTrabajoD.consultaOrdenesFinalizadas());
            this.visorReporteOrden.ReportSource = oRpInformeOrdenesFinalizadas;

        }
    }
}
