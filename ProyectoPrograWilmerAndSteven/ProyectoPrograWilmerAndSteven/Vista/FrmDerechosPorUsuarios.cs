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
    public partial class FrmDerechosPorUsuarios : Form
    {
        UsuarioD oUsuarioD = new UsuarioD();
        public FrmDerechosPorUsuarios()
        {
            InitializeComponent();
            this.CargarDGview();
            dGVUsuarios.ReadOnly = true;
        }
        private void CargarDGview()
        {
            this.dGVUsuarios.DataSource = "";

            List<UsuarioE> usuario = oUsuarioD.obtenerUsuarios();
            if (!oUsuarioD.Error)
            {
                
                this.dGVUsuarios.DataSource = usuario;
            }
        }
     
      

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (this.dGVUsuarios.Rows.Count > 0)
            {

                int fila = this.dGVUsuarios.CurrentRow.Index;

                List<UsuarioE> usuario = oUsuarioD.obtenerUsuarios();

                FrmRegistroDerechosUsuarios oFrm = new FrmRegistroDerechosUsuarios(usuario.ElementAt(fila));
                oFrm.ShowDialog();
                if (oFrm.aceptar)
                {

                    if (oUsuarioD.modificarUsuario(oFrm.oUsuarioE, this.dGVUsuarios[0, fila].Value.ToString()));
                    {
                        this.CargarDGview();
                        MessageBox.Show("Usuario actualizado");
                    }

                }

            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (this.dGVUsuarios.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.dGVUsuarios.CurrentRow.Index;

                    List<UsuarioE> usuarioE = oUsuarioD.obtenerUsuarios();


                    if (oUsuarioD.borrarUsuario(usuarioE.ElementAt(fila)))
                    {
                        this.CargarDGview();
                        MessageBox.Show("Usuario borrado");
                    }
                    else
                    {
                        MessageBox.Show("Error borrando el cliente: " +
                                   oUsuarioD.ErrorMsg, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.CargarDGview();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistroDerechosUsuarios oFrm = new FrmRegistroDerechosUsuarios();
            oFrm.ShowDialog();

            if (oFrm.aceptar)
            {
                if (oUsuarioD.agregarUsuario(oFrm.oUsuarioE))
                {
                    this.CargarDGview();
                    MessageBox.Show("Usuario agregado");
                }
                else
                {
                    MessageBox.Show("Error al agregar usuario: " +
                               oUsuarioD.ErrorMsg, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
