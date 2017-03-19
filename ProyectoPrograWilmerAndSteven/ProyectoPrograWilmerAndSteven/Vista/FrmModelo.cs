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
    public partial class FrmModelo : Form
    {
       /* ModeloD oModeloD = new ModeloD();
        public FrmModelo()
        {
            InitializeComponent();
            this.CargarDGview();
        }
        private void CargarDGview()
        {
            List<ModeloE> modelo = oModeloD.obtenerModelos(MarcaE pMarcaE) ;
            if (!oModeloD.Error)
            {
                this.dGVModelos.DataSource = modelo;
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (this.dGVModelos.Rows.Count > 0)
            {

                int fila = this.dGVModelos.CurrentRow.Index;
                
                ModeloE oModeloE = new ModeloE(Convert.ToInt32(this.dGVModelos[0, fila].Value.ToString()),
                                         this.dGVModelos[1, fila].Value.ToString(), this.dGVModelos[2, fila].Value.ToString(), this.dGVModelos[3, fila].Value.ToString());
                
                FrmRegistroModelo oFrm = new FrmRegistroModelo(oModeloE);
                oFrm.ShowDialog();
                if (oFrm.aceptar)
                {

                    if (oModeloD.modificarModelo(oFrm.oModelo, Convert.ToInt32(this.dGVModelos[0, fila].Value.ToString()))) ;
                    {
                        this.CargarDGview();
                        MessageBox.Show("Modelo actualizada");
                    }

                }

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dGVModelos.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.dGVModelos.CurrentRow.Index;

                    ModeloE oModeloE = new ModeloE(Convert.ToInt32(this.dGVModelos[0, fila].Value.ToString()),
                                             this.dGVModelos[1, fila].Value.ToString());


                    if (oModeloD.borrarModelo(oModeloE))
                    {
                        this.CargarDGview();
                        MessageBox.Show("Modelo borrado");
                    }
                    else
                    {
                        MessageBox.Show("Error borrando el modelo: " +
                                   oModeloD.ErrorMsg, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.CargarDGview();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistroModelo oFrm = new FrmRegistroModelo();
            oFrm.ShowDialog();

            if (oFrm.aceptar)
            {
                if (oModeloD.agregarModelo(oFrm.oModelo))
                {
                    this.CargarDGview();
                    MessageBox.Show("Modelo agregado");
                }
                else
                {
                    MessageBox.Show("Error al agregar modelo: " +
                               oModeloD.ErrorMsg, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/
    }
}
