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
    public partial class FrmPrincipal : Form
    {

        UsuarioD oUsuarioD = new UsuarioD();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioE oUsuario = (UsuarioE)oUsuarioD.comprobarUsuario(this.txtUsuario.Text, this.txtContrasenna.Text);
                if ((this.txtContrasenna.Text != "") && (this.txtUsuario.Text != ""))
                {
                    if (oUsuario != null)
                    {
                        FrmTallerMecanico oFrm = new FrmTallerMecanico();
                        if (oUsuario.Administrador)
                        {
                            oFrm.Show();
                        }
                        else if ((oUsuario.Sistema) && (oUsuario.Parametros) && (oUsuario.AdministracionDeOrdenes))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = true;
                            oFrm.sistemaToolStripMenuItem.Enabled = true;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = true;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = false;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.Sistema) && (oUsuario.Parametros) && (oUsuario.GestionGerencial))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = true;
                            oFrm.sistemaToolStripMenuItem.Enabled = true;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = false;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = true;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.Sistema) && (oUsuario.AdministracionDeOrdenes) && (oUsuario.GestionGerencial))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = false;
                            oFrm.sistemaToolStripMenuItem.Enabled = true;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = true;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = true;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.Parametros) && (oUsuario.AdministracionDeOrdenes) && (oUsuario.GestionGerencial))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = true;
                            oFrm.sistemaToolStripMenuItem.Enabled = false;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = true;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = true;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.Sistema) && (oUsuario.Parametros))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = true;
                            oFrm.sistemaToolStripMenuItem.Enabled = true;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = false;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = false;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.Sistema) && (oUsuario.AdministracionDeOrdenes))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = false;
                            oFrm.sistemaToolStripMenuItem.Enabled = true;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = true;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = false;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.Sistema) && (oUsuario.GestionGerencial))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = false;
                            oFrm.sistemaToolStripMenuItem.Enabled = true;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = false;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = true;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.Parametros) && (oUsuario.GestionGerencial))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = true;
                            oFrm.sistemaToolStripMenuItem.Enabled = false;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = false;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = true;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.Parametros) && (oUsuario.AdministracionDeOrdenes))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = true;
                            oFrm.sistemaToolStripMenuItem.Enabled = false;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = true;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = false;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if ((oUsuario.AdministracionDeOrdenes) && (oUsuario.GestionGerencial))
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = false;
                            oFrm.sistemaToolStripMenuItem.Enabled = false;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = true;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = true;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if (oUsuario.Sistema)
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = false;
                            oFrm.sistemaToolStripMenuItem.Enabled = true;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = false;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = false;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if (oUsuario.Parametros)
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = true;
                            oFrm.sistemaToolStripMenuItem.Enabled = false;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = false;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = false;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if (oUsuario.AdministracionDeOrdenes)
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = false;
                            oFrm.sistemaToolStripMenuItem.Enabled = false;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = true;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = false;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        else if (oUsuario.GestionGerencial)
                        {
                            oFrm.parametrosToolStripMenuItem.Enabled = false;
                            oFrm.sistemaToolStripMenuItem.Enabled = false;
                            oFrm.administracíonYÓrdenesToolStripMenuItem.Enabled = false;
                            oFrm.gestíonGerencialToolStripMenuItem.Enabled = true;
                            this.Visible = false;
                            oFrm.Show();
                        }
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Asegurese de que los datos ingresados son los correctos");
                    }
                
                }
                else
                {
                    MessageBox.Show("Debe ingresar todos los datos");
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
       
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtContrasenna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
