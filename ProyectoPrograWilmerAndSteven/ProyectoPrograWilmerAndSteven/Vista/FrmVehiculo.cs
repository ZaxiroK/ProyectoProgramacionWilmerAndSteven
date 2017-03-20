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
    public partial class FrmVehiculo : Form
    {
        VehiculoD oVehiculoD = new VehiculoD();
        public FrmVehiculo()
        {
            
            InitializeComponent();
            this.CargarDGview();
        }
        private void CargarDGview()
        {
            //List<VehiculoE> vehiculo = oVehiculoD.obtenerVehiculos(ClienteE pCliente, ModeloE pModeloE);
            //if (!oVehiculoD.Error)
            //{
            //    this.dGVVehiculos.DataSource = vehiculo;
            //}
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistroDeVehiculos oFrm = new FrmRegistroDeVehiculos();
            oFrm.ShowDialog();

            //if (oFrm.aceptar)
            //{
            //    if (oVehiculoD.agregarVehiculo(oFrm.oVehiculoE))
            //    {
            //        this.CargarDGview();
            //        MessageBox.Show("Vehiculo agregado");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al agregar vehiculo: " +
            //                   oVehiculoD.ErrorMsg, "Error",
            //                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (this.dGVVehiculos.Rows.Count > 0)
            //{

            //    int fila = this.dGVVehiculos.CurrentRow.Index;

            //    VehiculoE oVehiculoE = new VehiculoE(Convert.ToInt32(this.dGVVehiculos[0, fila].Value.ToString()),
            //                             this.dGVVehiculos[1, fila].Value.ToString(),
            //                             this.dGVVehiculos[2, fila].Value.ToString(),
            //                             this.dGVVehiculos[3, fila].Value.ToString(),
            //                             this.dGVVehiculos[4, fila].Value.ToString(),
            //                             this.dGVVehiculos[5, fila].Value.ToString(),
            //                             this.dGVVehiculos[6, fila].Value.ToString(),
            //                             this.dGVVehiculos[7, fila].Value.ToString(),
            //                             this.dGVVehiculos[8, fila].Value.ToString());

            //    FrmRegistroDeVehiculos oFrm = new FrmRegistroDeVehiculos(oVehiculoE);
            //    oFrm.ShowDialog();
            //    if (oFrm.aceptar)
            //    {

            //        if (oVehiculoD.modificarVehiculo(oFrm.oVehiculoE, Convert.ToInt32(this.dGVVehiculos[0, fila].Value.ToString()))) ;
            //        {
            //            this.CargarDGview();
            //            MessageBox.Show("Vehiculo actualizado");
            //        }

            //    }

            //}
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //if (this.dGVVehiculos.Rows.Count > 0)
            //{
            //    DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
            //                                             "Error",
            //                                              MessageBoxButtons.YesNo,
            //                                              MessageBoxIcon.Question);
            //    if (respuesta == DialogResult.Yes)
            //    {

            //        int fila = this.dGVVehiculos.CurrentRow.Index;

            //        VehiculoE oVehiculoE = new VehiculoE(Convert.ToInt32(this.dGVVehiculos[0, fila].Value.ToString()),
            //                                 this.dGVVehiculos[1, fila].Value.ToString(),
            //                                 this.dGVVehiculos[2, fila].Value.ToString(),
            //                                 this.dGVVehiculos[3, fila].Value.ToString(),
            //                                 this.dGVVehiculos[4, fila].Value.ToString(),
            //                                 this.dGVVehiculos[5, fila].Value.ToString(),
            //                                 this.dGVVehiculos[6, fila].Value.ToString(),
            //                                 this.dGVVehiculos[7, fila].Value.ToString(),
            //                                 this.dGVVehiculos[8, fila].Value.ToString());


            //        if (oVehiculoD.borrarVehiculo(oVehiculoE))
            //        {
            //            this.CargarDGview();
            //            MessageBox.Show("Vehiculo borrado");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error borrando el cliente: " +
            //                       oVehiculoD.ErrorMsg, "Error",
            //                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.CargarDGview();
        }
    }
}
