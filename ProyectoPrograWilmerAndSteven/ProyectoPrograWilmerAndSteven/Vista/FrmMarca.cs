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
using Logica;

namespace ProyectoPrograWilmerAndSteven.Vista
{
    public partial class FrmMarca : Form
    {
        MarcaD oMarcaD = new MarcaD();
        public FrmMarca()
        {
            InitializeComponent();
             this.CargarDGview();
        }

        private void CargarDGview()
        {
            List<MarcaE> marca = oMarcaD.obtenerMarcas();
            if (!oMarcaD.Error)
            {
                this.dGVMarcas.DataSource = marca;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistroDeMarca oFrm = new FrmRegistroDeMarca();
            oFrm.ShowDialog();

            if (oFrm.aceptar)
            {
                if (oMarcaD.agregarMarca(oFrm.oMarcaE))
                {
                    this.CargarDGview();
                    MessageBox.Show("Marca agregado");
                }
                else
                {
                    MessageBox.Show("Error al agregar Marca: " +
                               oMarcaD.ErrorMsg, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (this.dGVMarcas.Rows.Count > 0)
            {

                int fila = this.dGVMarcas.CurrentRow.Index;

                MarcaE oMarcaE = new MarcaE(Convert.ToInt32(this.dGVMarcas[0, fila].Value.ToString()),
                                         this.dGVMarcas[1, fila].Value.ToString());

                FrmRegistroDeMarca oFrm = new FrmRegistroDeMarca(oMarcaE);
                oFrm.ShowDialog();
                if (oFrm.aceptar)
                {

                    if (oMarcaD.modificarMarca(oFrm.oMarcaE, Convert.ToInt32(this.dGVMarcas[0, fila].Value.ToString())));
                    {
                        this.CargarDGview();
                        MessageBox.Show("Marca actualizada");
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

                    MarcaE oMarcaE = new MarcaE(Convert.ToInt32(this.dGVMarcas[0, fila].Value.ToString()),
                                             this.dGVMarcas[1, fila].Value.ToString());


                    if (oMarcaD.borrarMarca(oMarcaE))
                    {
                        this.CargarDGview();
                        MessageBox.Show("Marca borrada");
                    }
                    else
                    {
                        MessageBox.Show("Error borrando el marca: " +
                                   oMarcaD.ErrorMsg, "Error",
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
