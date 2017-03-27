﻿using Logica;
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
            this.txtLogin.ReadOnly = true;
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
            try
            {
                if (
                               !(this.txtLogin.Text == "") &&
                               !(this.txtContrasenia.Text == "")) 

                {

                    this.aceptar = true;



                }
                else
                {
                    MessageBox.Show("Debe ingresar todos los datos de texto");
                }


                oUsuarioE = new UsuarioE(this.txtLogin.Text,
                    this.txtContrasenia.Text, permisos(this.checkBoxAdministrador), permisos(this.checkBoxParametros),
                    permisos(this.checkBoxSistema),
                   permisos(this.checkBoxAdministracionDeOrdenes),
                    permisos(this.checkBoxGestionGerencial));

                this.Visible = false;
            }
            catch
            {
                MessageBox.Show("Asegurese de que los datos ingresados son los correctos");
            }
           
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

