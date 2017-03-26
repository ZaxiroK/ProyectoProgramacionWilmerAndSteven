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
    public partial class FrmRegistroDerechosUsuarios : Form
    {
        public bool aceptar;
        public UsuarioE oUsuarioE;
        public FrmRegistroDerechosUsuarios()
        {
            InitializeComponent();
        }
        public FrmRegistroDerechosUsuarios(UsuarioE oU)
        {
            InitializeComponent();

            this.txtLogin.Text = oU.Login.ToString();
            this.txtContrasenia.Visible = false;
            this.txtContrasenia.Text = oU.Contrasenia;
            this.checkBoxAdministrador.Checked = oU.Administrador;
            this.checkBoxParametros.Checked = oU.Parametros;
            this.checkBoxSistema.Checked = oU.Sistema;
            this.checkBoxAdministracionDeOrdenes.Checked = oU.AdministracionDeOrdenes;
            this.checkBoxGestionGerencial.Checked = oU.GestionGerencial;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (
                !(this.txtLogin.Text == "") &&
                !(this.txtContrasenia.Text == "")) ;
            //!(this.checkBoxAdministrador.Checked == false) &&
            //!(this.checkBoxParametros.Checked == false) &&
            //!(this.checkBoxSistema.Checked == false) &&
            // !(this.checkBoxAdministracionDeOrdenes.Checked == false) &&
            //!(this.checkBoxGestionGerencial.Checked == false)) ;
            {

                this.aceptar = true;



            }
            

            oUsuarioE = new UsuarioE(this.txtLogin.Text,
                this.txtContrasenia.Text, permisos(this.checkBoxAdministrador), permisos(this.checkBoxParametros),
                permisos(this.checkBoxSistema),
               permisos(this.checkBoxAdministracionDeOrdenes),
                permisos(this.checkBoxGestionGerencial));

            this.Visible = false;
        }

        public Boolean permisos(CheckBox checkbox)
        {
            if (checkbox.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

