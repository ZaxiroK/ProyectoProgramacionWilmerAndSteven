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

        public FrmRegistroCliente(ClienteE pOCliente)
        {
            InitializeComponent();

            this.oCliente = pOCliente;

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
            if (!(this.txtCedula.Text == "") && !(this.txtNombre.Text == "") && !(this.txtApellido1.Text == "") 
                && !(this.txtApellido2.Text == "") && !(this.txtDireccion.Text == ""))
            {

                this.aceptar = true;

                this.oCliente = new ClienteE(Convert.ToInt32(this.txtCedula.Text), this.txtNombre.Text,
                    this.txtApellido1.Text, this.txtApellido2.Text, this.txtDireccion.Text,
                    this.txtTelefono.Text, this.txtTelefono2.Text,this.txtTelefono3.Text);

                this.Visible = false;
            }
        }
    }
}
