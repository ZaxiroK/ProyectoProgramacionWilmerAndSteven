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
    public partial class FrmRegistrarEmpleado : Form
    {
        public bool aceptar;
        public EmpleadoE oEmpleadoE;
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
            llenarComboPuestos();
        }

        public FrmRegistrarEmpleado(EmpleadoE pEmpleado)
        {
            InitializeComponent();

            this.oEmpleadoE = pEmpleado;
            llenarComboPuestos();


            this.txtCedula.Text = this.oEmpleadoE.Cedula.ToString();
            this.txtNombre.Text = this.oEmpleadoE.Nombre;
            this.txtApellido1.Text = oEmpleadoE.Apellido1;
            this.txtApellido2.Text = oEmpleadoE.Apellido2;
            this.txtDireccion.Text = this.oEmpleadoE.Direccion;
            this.comboBoxPuesto.SelectedItem = oEmpleadoE.OPuestoE;// 
            this.txtTelefono.Text = this.oEmpleadoE.Telefono1;
            this.txtTelefono2.Text = this.oEmpleadoE.Telefono2;
            this.txtTelefono3.Text = this.oEmpleadoE.Telefono3;


        }
        public void llenarComboPuestos()
        {
            this.comboBoxPuesto.Items.Clear();
            PuestoD oPuestoD = new PuestoD();
            List<PuestoE> puestos = oPuestoD.obtenerPuestos();

            foreach (PuestoE oPuestoE in puestos)
            {
                this.comboBoxPuesto.Items.Add(oPuestoE);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!(this.txtCedula.Text == "") && !(this.txtNombre.Text == "") && !(this.txtApellido1.Text == "")
               && !(this.txtApellido2.Text == "") && !(this.txtDireccion.Text == ""))
            {

                this.aceptar = true;

                this.oEmpleadoE = new EmpleadoE(Convert.ToInt32(this.txtCedula.Text), this.txtNombre.Text,
                  this.txtApellido1.Text, this.txtApellido2.Text, this.txtDireccion.Text,(PuestoE)this.comboBoxPuesto.SelectedItem,
                  this.txtTelefono.Text, this.txtTelefono2.Text, this.txtTelefono3.Text);

                this.Visible = false;
            }
        }
    }
}
