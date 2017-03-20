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
        ModeloD oModeloD = new ModeloD();
        public FrmModelo()
        {
            InitializeComponent();
            this.CargarDGview();
        }
        private void CargarDGview()
        {
            
            dGVModelos.Rows.Clear();
            
            List<ModeloE> modelo = oModeloD.obtenerModelos();
            if (!oModeloD.Error)
            {
                foreach (ModeloE oM in modelo)
                {
                    this.dGVModelos.Rows.Add(oM.IdModelo.ToString(),
                        oM.Descripcion, oM.Anno.ToString(), oM.OMarca);
                }
            }
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dGVModelos.Rows.Count > 0)
            {

                int fila = this.dGVModelos.CurrentRow.Index;

                List<ModeloE> modelo = oModeloD.obtenerModelos();
                

                FrmRegistroModelo oFrm = new FrmRegistroModelo(modelo.ElementAt(fila));
                oFrm.ShowDialog();
                if (oFrm.aceptar)
                {

                    if (oModeloD.modificarModelo(oFrm.oModelo, Convert.ToInt32(this.dGVModelos[0, fila].Value.ToString())));
                    {
                        this.CargarDGview();
                        MessageBox.Show("Modelo actualizado");
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

                    List<ModeloE> modelo = oModeloD.obtenerModelos();


                    if (oModeloD.borrarModelo(modelo.ElementAt(fila)))
                    {
                        this.CargarDGview();
                        MessageBox.Show("Modelo borrada");
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
    }
}
