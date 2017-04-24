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
using ProyectoPrograWilmerAndSteven.Datos;

namespace ProyectoPrograWilmerAndSteven.Vista
{
    public partial class FrmInformeReparacionesAtendidasXmecanico : Form
    {
        private string fechaE;
        private string fechaS;
        private int empleado;
       

        public FrmInformeReparacionesAtendidasXmecanico()
        {
            InitializeComponent();
        }


        public FrmInformeReparacionesAtendidasXmecanico(string fchEntrada, string fchSalida, int emp)
        {
            InitializeComponent();
            this.fechaE = fchEntrada;
            this.fechaS = fchSalida;
            this.empleado = emp;
            cargarReporte();
        }

        


            private void cargarReporte()
        {
            OrdenReparacionD pOrdenReparacionD = new OrdenReparacionD();
            rpInformeReparacionesAtendidasXmecanico rp = new rpInformeReparacionesAtendidasXmecanico();

            rp.SetDataSource(pOrdenReparacionD.reporteReparacionesEmpleado(fechaE, fechaS, empleado));
            this.crystalReportViewer1.ReportSource = rp;

        }
    }
}
