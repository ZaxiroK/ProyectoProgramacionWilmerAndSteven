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
    public partial class FrmRegistroDeCatalogoDeRepuestos : Form
    {
        public bool aceptar;
        public CatalogoRepuestoE oCatalogoRepuestoE;
        public FrmRegistroDeCatalogoDeRepuestos()
        {
            InitializeComponent();
        }

        public FrmRegistroDeCatalogoDeRepuestos(CatalogoRepuestoE pCatalogoRepuestoE)
        {
            InitializeComponent();
            this.txtId.Text = pCatalogoRepuestoE.IdCatalogoRepuesto.ToString();
            this.txtNombreRepuesto.Text = pCatalogoRepuestoE.NombreDelRepuesto;
            this.txtAnio.Text = pCatalogoRepuestoE.AnnoAlQuePertenece.ToString();
            this.txtPrecio.Text = pCatalogoRepuestoE.Precio.ToString();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(this.txtId.Text == "") && !(this.txtNombreRepuesto.Text == "") && !(this.txtAnio.Text == "") && !(this.txtPrecio.Text == ""))
                {
                    this.oCatalogoRepuestoE = new CatalogoRepuestoE(Convert.ToInt32(this.txtId.Text), this.txtNombreRepuesto.Text, Convert.ToInt32(this.txtAnio.Text),
                    Convert.ToDouble(this.txtPrecio.Text));
                    this.aceptar = true;
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

        private void txtNombreRepuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtAnio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(this.txtId.Text == "") && !(this.txtNombreRepuesto.Text == "") && !(this.txtAnio.Text == "") && !(this.txtPrecio.Text == ""))
                {
                    this.oCatalogoRepuestoE = new CatalogoRepuestoE(Convert.ToInt32(this.txtId.Text), this.txtNombreRepuesto.Text, Convert.ToInt32(this.txtAnio.Text),
                    Convert.ToDouble(this.txtPrecio.Text));
                    this.aceptar = true;
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
    }
}
