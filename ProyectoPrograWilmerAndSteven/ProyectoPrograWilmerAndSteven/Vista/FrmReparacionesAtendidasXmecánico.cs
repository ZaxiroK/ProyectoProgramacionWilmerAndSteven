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
    public partial class FrmReparacionesAtendidasXmecánico : Form
    {
        private DateTime fechEntrada;
        private DateTime fechSalida;
        
        public FrmReparacionesAtendidasXmecánico()
        {
            InitializeComponent();
            llenarComboEmpleado();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {

            EmpleadoE pEmpl = ((EmpleadoE)this.cmbEmpleado.SelectedItem);
           
                fechEntrada = fechaEntrada.Value;
            fechSalida = FechaSalida.Value;
            FrmInformeReparacionesAtendidasXmecanico frm = new FrmInformeReparacionesAtendidasXmecanico(fechEntrada, fechSalida, pEmpl.Cedula);
            frm.ShowDialog();
        }


        public void llenarComboEmpleado()
        {
            
            EmpleadoD oEmpleadoD = new EmpleadoD();
            List<EmpleadoE> empleados = oEmpleadoD.obtenerEmpleados();

            foreach (EmpleadoE oEmpleadoE in empleados)
            {
                this.cmbEmpleado.Items.Add(oEmpleadoE);
                this.cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbEmpleado.SelectedIndex = -1;
                
            }

        }
    }
}
