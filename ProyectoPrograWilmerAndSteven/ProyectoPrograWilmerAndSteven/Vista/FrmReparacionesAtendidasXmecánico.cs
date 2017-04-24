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
        
        

        public FrmReparacionesAtendidasXmecánico()
        {
            InitializeComponent();
            /*llenarComboEmpleado();*/
            
            fechEntrada = string.Format(fechaEntrada.Value.ToString("yyyy-MM-dd"));
            fechSalida = string.Format(FechaSalida.Value.ToString("yyyy-MM-dd"));
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            try
            {
                

            /*EmpleadoE pEmpl = ((EmpleadoE)this.cmbEmpleado.SelectedItem);*/
            fechEntrada = string.Format(fechaEntrada.Value.ToString("yyyy-MM-dd"));
            fechSalida = string.Format(FechaSalida.Value.ToString("yyyy-MM-dd"));


            
            DateTime fcEntrada = Convert.ToDateTime(fechEntrada);
            DateTime fcSalida = Convert.ToDateTime(fechSalida);

            if (fcEntrada > fcSalida) // Si la fecha indicada es menor o igual a la fecha actual
            {
                MessageBox.Show("La fecha de entrada no puede ser mayor a la de la salida");
            }
            else
            {
                FrmInformeReparacionesAtendidasXmecanico frm = new FrmInformeReparacionesAtendidasXmecanico(fechEntrada, fechSalida/*, pEmpl.Cedula*/);
                frm.ShowDialog();
            }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }


        /*public void llenarComboEmpleado()
        {
            
            EmpleadoD oEmpleadoD = new EmpleadoD();
            List<EmpleadoE> empleados = oEmpleadoD.obtenerEmpleados();

            foreach (EmpleadoE oEmpleadoE in empleados)
            {
                this.cmbEmpleado.Items.Add(oEmpleadoE);
                this.cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbEmpleado.SelectedIndex = cmbEmpleado.Items.Count - 1;

            }
            

        }*/

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
