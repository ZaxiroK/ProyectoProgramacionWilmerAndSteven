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
    public partial class FrmRegistroCliente : Form
    {
        public bool aceptar;
        public ClienteE oCliente;
        public FrmRegistroCliente()
        {
            InitializeComponent();
            
        }

        public FrmRegistroCliente(ClienteE pCliente)
        {
            InitializeComponent();

            this.oCliente = pCliente;

            this.txtApellido1.Text = oCliente.Apellido1;
            this.txtApellido2.Text = oCliente.Apellido2;
            this.txtCedula.Text = this.oCliente.Cedula.ToString();
            this.txtDireccion.Text = this.oCliente.Direccion;
            this.txtNombre.Text = this.oCliente.Nombre;
            this.txtTelefono.Text = this.oCliente.Telefono1;
            this.txtTelefono2.Text = this.oCliente.Telefono2;
            this.txtTelefono3.Text = this.oCliente.Telefono3;

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(this.txtCedula.Text == "") && !(this.txtNombre.Text == "") && !(this.txtApellido1.Text == "")
               && !(this.txtApellido2.Text == "") && !(this.txtDireccion.Text == ""))
                {

                    this.aceptar = true;

                    this.oCliente = new ClienteE(Convert.ToInt32(this.txtCedula.Text), this.txtNombre.Text,
                        this.txtApellido1.Text, this.txtApellido2.Text, this.txtDireccion.Text,
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
