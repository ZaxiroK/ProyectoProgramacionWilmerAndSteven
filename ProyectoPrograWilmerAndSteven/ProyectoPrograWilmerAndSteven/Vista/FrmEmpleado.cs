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
    public partial class FrmEmpleado : Form
    {
        EmpleadoD oEmpleadoD = new EmpleadoD();
        public FrmEmpleado()
        {
            InitializeComponent();
            this.CargarDGview();
        }

        private void CargarDGview()
        {
            this.dGViewEmpleados.Rows.Clear();

            List<EmpleadoE> empleado = oEmpleadoD.obtenerEmpleados();
            if (!oEmpleadoD.Error)
            {
                foreach (EmpleadoE oEm in empleado)
                {
                    this.dGViewEmpleados.Rows.Add(oEm.Cedula, oEm.Nombre,
                        oEm.Apellido1, oEm.Apellido2, oEm.Direccion, oEm.OPuestoE, oEm.Telefono1, oEm.Telefono2,
                        oEm.Telefono3);
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado oFrm = new FrmRegistrarEmpleado();
            oFrm.ShowDialog();

            if (oFrm.aceptar)
            {
                if (oEmpleadoD.agregarEmpleado(oFrm.oEmpleadoE))
                {
                    this.CargarDGview();
                    MessageBox.Show("Empleado agregado");
                }
                else
                {
                    MessageBox.Show("Error al agregar empleado: " +
                               oEmpleadoD.ErrorMsg, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dGViewEmpleados.Rows.Count > 0)
            {

                int fila = this.dGViewEmpleados.CurrentRow.Index;

                List<EmpleadoE> empleado = oEmpleadoD.obtenerEmpleados();

                FrmRegistrarEmpleado oFrm = new FrmRegistrarEmpleado(empleado.ElementAt(fila));
                oFrm.ShowDialog();
                if (oFrm.aceptar)
                {

                    if (oEmpleadoD.modificarEmpleado(oFrm.oEmpleadoE, Convert.ToInt32(this.dGViewEmpleados[0, fila].Value.ToString()))) ;
                    {
                        this.CargarDGview();
                        MessageBox.Show("Empleado actualizado");
                    }

                }

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dGViewEmpleados.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.dGViewEmpleados.CurrentRow.Index;

                    List<EmpleadoE> empleado = oEmpleadoD.obtenerEmpleados();


                    if (oEmpleadoD.borrarEmpleado(empleado.ElementAt(fila)))
                    {
                        this.CargarDGview();
                        MessageBox.Show("Empleado borrado");
                    }
                    else
                    {
                        MessageBox.Show("Error borrando el cliente: " +
                                   oEmpleadoD.ErrorMsg, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.CargarDGview();
        }
    }
}
