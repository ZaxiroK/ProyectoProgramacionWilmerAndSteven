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
    public partial class FrmRegistroDeMarca : Form
    {
        public bool aceptar;
        public MarcaE oMarcaE;
        public FrmRegistroDeMarca()
        {
            InitializeComponent();
        }

        public FrmRegistroDeMarca(MarcaE pOMarcaE)
        {
            InitializeComponent();
            this.oMarcaE = pOMarcaE;
            this.txtCodigo.Text = pOMarcaE.IdMarca.ToString();
            this.txtMarca.Text = pOMarcaE.Descripcion;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!(this.txtCodigo.Text == "") && !(this.txtMarca.Text == ""))
            {
                this.oMarcaE = new MarcaE(Convert.ToInt32(this.txtCodigo.Text), this.txtMarca.Text);
                this.aceptar = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
