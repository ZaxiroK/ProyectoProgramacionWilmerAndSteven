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
        private string fechEntrada;
        private string fechSalida;
        private DateTime fcEntrada;
        private DateTime fcSalida;
        

        public FrmReparacionesAtendidasXmecánico()
        {
            InitializeComponent();
            llenarComboEmpleado();
            fechEntrada = string.Format(fechaEntrada.Value.ToString("yyyy-MM-dd"));
            fechSalida = string.Format(fechaEntrada.Value.ToString("yyyy-MM-dd"));
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {

            EmpleadoE pEmpl = ((EmpleadoE)this.cmbEmpleado.SelectedItem);
            fechEntrada = string.Format(fechaEntrada.Value.ToString("yyyy-MM-dd"));
            fechSalida = string.Format(fechaEntrada.Value.ToString("yyyy-MM-dd"));

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
