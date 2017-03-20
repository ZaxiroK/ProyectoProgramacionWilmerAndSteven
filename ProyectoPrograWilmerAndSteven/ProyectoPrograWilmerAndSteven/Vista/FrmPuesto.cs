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
    public partial class FrmPuesto : Form
    {
        PuestoD oPuestoD = new PuestoD();
        public FrmPuesto()
        {
            InitializeComponent();
            this.CargarDGview();
        }
        private void CargarDGview()
        {
            this.dGVMarcas.DataSource = "";

            List<PuestoE> marca = oPuestoD.obtenerPuestos();
            if (!oPuestoD.Error)
            {
                this.dGVMarcas.DataSource = marca;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistroDePuestos oFrm = new FrmRegistroDePuestos();
            oFrm.ShowDialog();

            if (oFrm.aceptar)
            {
                if (oPuestoD.agregarPuesto(oFrm.oP))
                {
                    this.CargarDGview();
                    MessageBox.Show("Puesto agregado");
                }
                else
                {
                    MessageBox.Show("Error al agregar Marca: " +
                               oPuestoD.ErrorMsg, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (this.dGVMarcas.Rows.Count > 0)
            {

                int fila = this.dGVMarcas.CurrentRow.Index;

                PuestoE oPuestoE = new PuestoE(Convert.ToInt32(this.dGVMarcas[0, fila].Value.ToString()), Convert.ToDouble(this.dGVMarcas[1, fila].Value.ToString()),
                                             Convert.ToChar(this.dGVMarcas[2, fila].Value.ToString()), this.dGVMarcas[3, fila].Value.ToString());

                FrmRegistroDePuestos oFrm = new FrmRegistroDePuestos(oPuestoE);
                oFrm.ShowDialog();
                if (oFrm.aceptar)
                {

                    if (oPuestoD.modificarPuesto(oFrm.oP, Convert.ToInt32(this.dGVMarcas[0, fila].Value.ToString()))) ;
                    {
                        this.CargarDGview();
                        MessageBox.Show("Puesto actualizada");
                    }

                }

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dGVMarcas.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.dGVMarcas.CurrentRow.Index;

                    PuestoE oPuestoE = new PuestoE(Convert.ToInt32(this.dGVMarcas[0, fila].Value.ToString()), Convert.ToDouble(this.dGVMarcas[1, fila].Value.ToString()),
                                             Convert.ToChar(this.dGVMarcas[2, fila].Value.ToString()), this.dGVMarcas[3, fila].Value.ToString());


                    if (oPuestoD.borrarPuesto(oPuestoE))
                    {
                        this.CargarDGview();
                        MessageBox.Show("Puesto borrada");
                    }
                    else
                    {
                        MessageBox.Show("Error borrando el marca: " +
                                   oPuestoD.ErrorMsg, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
