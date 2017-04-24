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
        public PuestoE puestoEActual;
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
            this.txtTelefono.Text = this.oEmpleadoE.Telefono1;
            this.txtTelefono2.Text = this.oEmpleadoE.Telefono2;
            this.txtTelefono3.Text = this.oEmpleadoE.Telefono3;
            puestoEActual = oEmpleadoE.OPuestoE;
            setPuestoActual(puestoEActual.IdPuesto);

        }
        /// <summary>
        /// llena el comboBoxPuesto con PuestosE
        /// </summary>
        public void llenarComboPuestos()
        {
            this.comboBoxPuesto.Items.Clear();
            PuestoD oPuestoD = new PuestoD();
            List<PuestoE> puestos = oPuestoD.obtenerPuestos();

            foreach (PuestoE oPuestoE in puestos)
            {
                this.comboBoxPuesto.Items.Add(oPuestoE);
                this.comboBoxPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxPuesto.SelectedIndex = comboBoxPuesto.Items.Count - 1;
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

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtApellido1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtApellido2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtTelefono2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtTelefono3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void setPuestoActual(int id)
        {
            int i, x = 0;
            for (i = 0; i < this.comboBoxPuesto.Items.Count; i++)
            {
                PuestoE oPe = (PuestoE)this.comboBoxPuesto.Items[i];
                if (oPe.IdPuesto == id)
                {
                    x = i;
                    i = this.comboBoxPuesto.Items.Count;
                }
            }
            this.comboBoxPuesto.SelectedIndex = x;
        }
    }
}
