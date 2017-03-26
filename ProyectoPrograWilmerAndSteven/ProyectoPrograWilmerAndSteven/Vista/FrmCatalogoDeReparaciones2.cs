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
    public partial class FrmCatalogoDeReparaciones2 : Form
    {
        CatalogoReparacionD oCatalogoReparacionD = new CatalogoReparacionD();
        public FrmCatalogoDeReparaciones2()
        {
            InitializeComponent();
            this.CargarDGview();
            dGVCatalogoRepuestos.ReadOnly = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistroDeCatalgoDeReparaciones oFrm = new FrmRegistroDeCatalgoDeReparaciones();
            oFrm.ShowDialog();


            if (oFrm.aceptar)
            {
                if (oCatalogoReparacionD.agregarCatalogoReparacion(oFrm.oCatalogoE))
                {
                    this.CargarDGview();
                    MessageBox.Show("Reparción agregada");
                }
                else
                {
                    MessageBox.Show("Error al agregar repuesto: " +
                               oCatalogoReparacionD.ErrorMsg, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (this.dGVCatalogoRepuestos.Rows.Count > 0)
            {

                int fila = this.dGVCatalogoRepuestos.CurrentRow.Index;

                CatalogoReparacionE oCatalogoReparacionE = new CatalogoReparacionE(Convert.ToInt32(this.dGVCatalogoRepuestos[0, fila].Value.ToString()),
                                         this.dGVCatalogoRepuestos[1, fila].Value.ToString(), Convert.ToInt32(this.dGVCatalogoRepuestos[2, fila].Value.ToString()),
                                         Convert.ToDouble(this.dGVCatalogoRepuestos[3, fila].Value.ToString()));

                FrmRegistroDeCatalgoDeReparaciones oFrm = new FrmRegistroDeCatalgoDeReparaciones(oCatalogoReparacionE);
                oFrm.ShowDialog();
                if (oFrm.aceptar)
                {

                    if (oCatalogoReparacionD.modificarCatalogoReparacion(oFrm.oCatalogoE, Convert.ToInt32(this.dGVCatalogoRepuestos[0, fila].Value.ToString()))) ;
                    {
                        this.CargarDGview();
                        MessageBox.Show("Reparacion actualizada");
                    }

                }

            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dGVCatalogoRepuestos.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.dGVCatalogoRepuestos.CurrentRow.Index;

                    CatalogoReparacionE oCatalogoReparacionE = new CatalogoReparacionE(Convert.ToInt32(this.dGVCatalogoRepuestos[0, fila].Value.ToString()),
                                         this.dGVCatalogoRepuestos[1, fila].Value.ToString(), Convert.ToInt32(this.dGVCatalogoRepuestos[2, fila].Value.ToString()),
                                         Convert.ToDouble(this.dGVCatalogoRepuestos[3, fila].Value.ToString()));

                    if (oCatalogoReparacionD.borrarCatalogoReparacion(oCatalogoReparacionE))
                    {
                        this.CargarDGview();
                        MessageBox.Show("Reparacion borrada");
                    }
                    else
                    {
                        MessageBox.Show("Error borrando el Reparación: " +
                                   oCatalogoReparacionD.ErrorMsg, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CargarDGview()
        {
            this.dGVCatalogoRepuestos.DataSource = "";

            List<CatalogoReparacionE> catalogoRepuesto = oCatalogoReparacionD.obtenerCatalogoReaparaciones();
            if (!oCatalogoReparacionD.Error)
            {
                this.dGVCatalogoRepuestos.DataSource = catalogoRepuesto;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            this.CargarDGview();
        }
    }
}
