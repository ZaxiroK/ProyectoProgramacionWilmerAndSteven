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
            this.oCatalogoRepuestoE = pCatalogoRepuestoE;
            this.txtId.Text = pCatalogoRepuestoE.IdCatalogoRepuesto.ToString();
            this.txtNombreRepuesto.Text = pCatalogoRepuestoE.NombreDelRepuesto;
            this.txtAnio.Text = pCatalogoRepuestoE.AnnoAlQuePertenece.ToString();
            this.txtPrecio.Text = pCatalogoRepuestoE.Precio.ToString();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!(this.txtId.Text == "") && !(this.txtNombreRepuesto.Text == "") && !(this.txtAnio.Text == "") && !(this.txtPrecio.Text == ""))
            {
                this.oCatalogoRepuestoE = new CatalogoRepuestoE(Convert.ToInt32(this.txtId.Text), this.txtNombreRepuesto.Text,Convert.ToInt32(this.txtAnio.Text),
                Convert.ToDouble(this.txtId.Text));
                this.aceptar = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
