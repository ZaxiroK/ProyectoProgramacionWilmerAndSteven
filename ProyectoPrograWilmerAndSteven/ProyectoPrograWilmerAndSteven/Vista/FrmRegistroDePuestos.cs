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
    public partial class FrmRegistroDePuestos : Form
    {
       public PuestoE oP;
       public bool aceptar; 
        public FrmRegistroDePuestos()
        {
            InitializeComponent();
        }

        public FrmRegistroDePuestos(PuestoE oPu)
        {
            InitializeComponent();
            this.txtId.Text = oPu.IdPuesto.ToString();
            this.txtSalario.Text = oPu.Salario.ToString();
            this.txtDescripcion.Text = oPu.Descripcion;
            this.txtMecanico.Text = oPu.Puesto.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if((this.txtId.Text != " ") &&(this.txtSalario.Text != " ") &&(this.txtDescripcion.Text != " ")
                && (this.txtMecanico.Text != " "))
            {
                aceptar = true;
                oP = new PuestoE(Convert.ToInt32(this.txtId.Text), Convert.ToDouble(this.txtSalario.Text),
                    Convert.ToChar(this.txtMecanico.Text), this.txtDescripcion.Text);
                this.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
