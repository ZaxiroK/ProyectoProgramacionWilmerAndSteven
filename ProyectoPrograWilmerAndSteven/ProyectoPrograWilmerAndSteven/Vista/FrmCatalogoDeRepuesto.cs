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
    public partial class FrmCatalogoDeRepuesto : Form
    {
        CatalogoRepuestoD oCatalogoRepuestoD = new CatalogoRepuestoD();
        public FrmCatalogoDeRepuesto()
        {
            InitializeComponent();
            this.CargarDGview();
        }

        private void CargarDGview()
        {
            List<CatalogoRepuestoE> catalogoRepuesto = oCatalogoRepuestoD.obtenerCatalogoRepuestos();
            if (!oCatalogoRepuestoD.Error)
            {
                this.dGVCatalogoRepuestos.DataSource = catalogoRepuesto;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //FrmRegistroDeCatalogoDeRepuestos oFrm = new FrmRegistroDeCatalogoDeRepuestos();
            //oFrm.ShowDialog();

            //if (oFrm.aceptar)
            //{
            //    if (oCatalogoRepuestoD.agregarCatalogoRepuesto(oFrm.oCatalogoRepuestoE))
            //    {
            //        this.CargarDGview();
            //        MessageBox.Show("Catalogo agregado");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al agregar Catalogo: " +
            //                   oCatalogoRepuestoD.ErrorMsg, "Error",
            //                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //if (this.dGVCatalogoRepuestos.Rows.Count > 0)
            //{

            //    int fila = this.dGVCatalogoRepuestos.CurrentRow.Index;

            //    CatalogoRepuestoE oCatalogoRepuestoE = new CatalogoRepuestoE(Convert.ToInt32(this.dGVCatalogoRepuestos[0, fila].Value.ToString()),
            //                             this.dGVCatalogoRepuestos[1, fila].Value.ToString(), Convert.ToInt32(this.dGVCatalogoRepuestos[2, fila].Value.ToString()),
            //                             Convert.ToDouble(this.dGVCatalogoRepuestos[3, fila].Value.ToString()));

            //    FrmRegistroDeCatalogoDeRepuestos oFrm = new FrmRegistroDeCatalogoDeRepuestos(oCatalogoRepuestoE);
            //    oFrm.ShowDialog();
            //    if (oFrm.aceptar)
            //    {

            //        if (oCatalogoRepuestoD.modificarCatalogoRepuesto(oFrm.oCatalogoRepuestoE, Convert.ToInt32(this.dGVCatalogoRepuestos[0, fila].Value.ToString()));
            //        {
            //            this.CargarDGview();
            //            MessageBox.Show("Marca actualizada");
            //        }

            //    }

            //}
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            //if (this.dGVCatalogoRepuestos.Rows.Count > 0)
            //{
            //    DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
            //                                             "Error",
            //                                              MessageBoxButtons.YesNo,
            //                                              MessageBoxIcon.Question);
            //    if (respuesta == DialogResult.Yes)
            //    {

            //        int fila = this.dGVCatalogoRepuestos.CurrentRow.Index;

            //        MarcaE oMarcaE = new MarcaE(Convert.ToInt32(this.dGVCatalogoRepuestos[0, fila].Value.ToString()),
            //                                 this.dGVCatalogoRepuestos[1, fila].Value.ToString());


            //        if (oCatalogoRepuestoD.borrarCatalogoRepuesto(oCatalogoRepuestoE))
            //        {
            //            this.CargarDGview();
            //            MessageBox.Show("Marca borrada");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error borrando el marca: " +
            //                       oCatalogoRepuestoD.ErrorMsg, "Error",
            //                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            this.CargarDGview();
        }
    }
}
