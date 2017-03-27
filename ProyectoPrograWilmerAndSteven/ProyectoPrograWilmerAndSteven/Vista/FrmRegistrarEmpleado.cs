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
            this.comboBoxPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
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
            try
            {
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try {
                if (!(this.txtCedula.Text == "") && !(this.txtNombre.Text == "") && !(this.txtApellido1.Text == "")
               && !(this.txtApellido2.Text == "") && !(this.txtDireccion.Text == ""))
                {

                    this.aceptar = true;

                    this.oEmpleadoE = new EmpleadoE(Convert.ToInt32(this.txtCedula.Text), this.txtNombre.Text,
                      this.txtApellido1.Text, this.txtApellido2.Text, this.txtDireccion.Text, (PuestoE)this.comboBoxPuesto.SelectedItem,
                      this.txtTelefono.Text, this.txtTelefono2.Text, this.txtTelefono3.Text);

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
