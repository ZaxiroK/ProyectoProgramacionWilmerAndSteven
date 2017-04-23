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
    public partial class FrmInformeReparacionesAtendidasXmecanico : Form
    {
        private DateTime fechaE;
        private DateTime fechaS;
        private EmpleadoE empleado;
        public FrmInformeReparacionesAtendidasXmecanico()
        {
            InitializeComponent();
        }


        public FrmInformeReparacionesAtendidasXmecanico(DateTime fchEntrada, DateTime fchSalida, int emp)
        {
            InitializeComponent();
            this.fechaE = fchEntrada;
            this.fechaS = fchSalida;
        }


        /*FrmReporteOrdenDeTrabajo oReporte = new FrmReporteOrdenDeTrabajo(numeroOrdenFactura, pClienteE.Cedula);
        oReporte.ShowDialog();*/
    }
}
