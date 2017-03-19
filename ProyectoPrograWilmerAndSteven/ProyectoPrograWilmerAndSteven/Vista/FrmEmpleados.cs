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
    //public partial class FrmEmpleados : Form
    //{
    //    EmpleadoD oEmpleadoD = new EmpleadoD();
    //    public FrmEmpleados()
    //    {
    //        InitializeComponent();
    //        this.CargarDGview();
    //    }

    //    private void CargarDGview()
    //    {
    //        List<EmpleadoE> empleado = oEmpleadoD.obtenerEmpleados(PuestoE pPuesto);
    //        if (!oEmpleadoD.Error)
    //        {
    //            this.dGViewEmpleados.DataSource = empleado;
    //        }
    //    }
    //    private void btnAgregar_Click(object sender, EventArgs e)
    //    {
    //        FrmRegistrarEmpleado oFrm = new FrmRegistrarEmpleado();
    //        oFrm.ShowDialog();

    //        if (oFrm.aceptar)
    //        {
    //            if (oEmpleadoD.agregarEmpleado(oFrm.))
    //            {
    //                this.CargarDGview();
    //                MessageBox.Show("Empleado agregado");
    //            }
    //            else
    //            {
    //                MessageBox.Show("Error al agregar empleado: " +
    //                           oEmpleadoD.ErrorMsg, "Error",
    //                           MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            }
    //        }
    //    }

    //    private void Editar_Click(object sender, EventArgs e)
    //    {
    //        if (this.dGViewEmpleados.Rows.Count > 0)
    //        {

    //            int fila = this.dGViewEmpleados.CurrentRow.Index;

    //            EmpleadoE oEmpleadoE = new EmpleadoE(Convert.ToInt32(this.dGViewEmpleados[0, fila].Value.ToString()),
    //                                     this.dGViewEmpleados[1, fila].Value.ToString(),
    //                                     this.dGViewEmpleados[2, fila].Value.ToString(),
    //                                     this.dGViewEmpleados[3, fila].Value.ToString(),
    //                                     this.dGViewEmpleados[4, fila].Value.ToString(),
    //                                     this.dGViewEmpleados[5, fila].Value.ToString(),
    //                                     this.dGViewEmpleados[6, fila].Value.ToString(),
    //                                     this.dGViewEmpleados[7, fila].Value.ToString(),
    //                                     this.dGViewEmpleados[7, fila].Value.ToString());

    //            FrmRegistrarEmpleado oFrm = new FrmRegistrarEmpleado(oEmpleadoE);
    //            oFrm.ShowDialog();
    //            if (oFrm.aceptar)
    //            {

    //                if (oEmpleadoD.modificarEmpleado(oFrm.oEmpleado, Convert.ToInt32(this.dGViewEmpleados[0, fila].Value.ToString()))) ;
    //                {
    //                    this.CargarDGview();
    //                    MessageBox.Show("Empleado actualizado");
    //                }

    //            }

    //        }
    //    }

    //    private void btnBorrar_Click(object sender, EventArgs e)
    //    {
    //        if (this.dGViewEmpleados.Rows.Count > 0)
    //        {
    //            DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
    //                                                     "Error",
    //                                                      MessageBoxButtons.YesNo,
    //                                                      MessageBoxIcon.Question);
    //            if (respuesta == DialogResult.Yes)
    //            {

    //                int fila = this.dGViewEmpleados.CurrentRow.Index;

    //                EmpleadoE oEmpleadoE = new EmpleadoE(Convert.ToInt32(this.dGViewEmpleados[0, fila].Value.ToString()),
    //                                         this.dGViewEmpleados[1, fila].Value.ToString(),
    //                                         this.dGViewEmpleados[2, fila].Value.ToString(),
    //                                         this.dGViewEmpleados[3, fila].Value.ToString(),
    //                                         this.dGViewEmpleados[4, fila].Value.ToString(),
    //                                         this.dGViewEmpleados[5, fila].Value.ToString(),
    //                                         this.dGViewEmpleados[6, fila].Value.ToString(),
    //                                         this.dGViewEmpleados[7, fila].Value.ToString(),
    //                                         this.dGViewEmpleados[8, fila].Value.ToString());


    //                if (oEmpleadoD.borrarEmpleado(oEmpleadoE))
    //                {
    //                    this.CargarDGview();
    //                    MessageBox.Show("Empleado borrado");
    //                }
    //                else
    //                {
    //                    MessageBox.Show("Error borrando el empleado: " +
    //                               oEmpleadoD.ErrorMsg, "Error",
    //                               MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                }
    //            }
    //        }
    //    }

    //    private void btnActualizar_Click(object sender, EventArgs e)
    //    {
    //        this.CargarDGview();
    //    }
    //}
}
