using Logica;
using ProyectoPrograWilmerAndSteven.Datos;
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
    public partial class FrmSeleccionarReparaciones : Form
    {
        public FrmSeleccionarReparaciones()
        {
            InitializeComponent();
            this.llenarComboEmpleado();
            this.llenarComboReparacion();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if()
            //{

            //}
        }

        public void llenarComboReparacion()
        {

            CatalogoReparacionD oReparacionD = new CatalogoReparacionD();
            List<CatalogoReparacionE> reparacion = oReparacionD.obtenerCatalogoReaparaciones();

            foreach (CatalogoReparacionE oRespuestoE in reparacion)
            {
                this.cmbOrdenTrabajo.Items.Add(oRespuestoE);
            }
        }

        public void llenarComboEmpleado()
        {

            EmpleadoD oEmpleadoD = new EmpleadoD();
            List<EmpleadoE> empleados = oEmpleadoD.obtenerEmpleados();

            foreach (EmpleadoE oEmpleadoE in empleados)
            {
                this.cmbEmpleado.Items.Add(oEmpleadoE);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
