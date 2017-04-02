using Logica;
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
    public partial class FrmRegistroDeCatalgoDeReparaciones : Form
    {
        public CatalogoReparacionE oCatalogoE;
        public bool aceptar;
        public FrmRegistroDeCatalgoDeReparaciones()
        {
            InitializeComponent();
        }

        public FrmRegistroDeCatalgoDeReparaciones(CatalogoReparacionE oCatalogoE)
        {
            InitializeComponent();
            this.txtId.Text = oCatalogoE.Id_catalogoReparacion.ToString();
            this.txtDescripcionReparacion.Text = oCatalogoE.Descripcion;
            this.txtHorasReparacion.Text = oCatalogoE.HorasReparacion.ToString();
            this.txtCostoReparacion.Text = oCatalogoE.CostoReparacion.ToString();
        }
        private void btnnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((this.txtDescripcionReparacion.Text != "") && (this.txtCostoReparacion.Text != "")
                && (this.txtHorasReparacion.Text != "") && (this.txtId.Text != ""))
                {
                    this.aceptar = true;

                    oCatalogoE = new CatalogoReparacionE(Convert.ToInt32(this.txtId.Text),
                       this.txtDescripcionReparacion.Text, Convert.ToInt32(this.txtHorasReparacion.Text),
                       Convert.ToDouble(this.txtCostoReparacion.Text));

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Debe ingresar todos los datos");
                }
            }
            catch
            {
                MessageBox.Show("Asegurese de que los datos ingresados son los correctos");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
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

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtDescripcionReparacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtHorasReparacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtCostoReparacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((this.txtDescripcionReparacion.Text != "") && (this.txtCostoReparacion.Text != "")
                && (this.txtHorasReparacion.Text != "") && (this.txtId.Text != ""))
                {
                    this.aceptar = true;

                    oCatalogoE = new CatalogoReparacionE(Convert.ToInt32(this.txtId.Text),
                       this.txtDescripcionReparacion.Text, Convert.ToInt32(this.txtHorasReparacion.Text),
                       Convert.ToDouble(this.txtCostoReparacion.Text));

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Debe ingresar todos los datos");
                }
            }
            catch
            {
                MessageBox.Show("Asegurese de que los datos ingresados son los correctos");
            }
        }

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
