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

namespace ProyectoPrograWilmerAndSteven
{
    public partial class Form1 : Form
    {
        UsuarioE pUsuarioE;
        UsuarioD userD = new UsuarioD();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(UsuarioE user)
        {
            InitializeComponent();
            pUsuarioE = user;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {  

                this.Visible = false;

                MessageBox.Show("Debe ingresar todos los datos");
            }
            
                
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(this.txtContraseniaActual.Text.Trim() == "") && !(this.txtContraseniaNueva.Text.Trim() == ""))
                {
                    
                        
                        userD.cambioDeContrasenia(pUsuarioE.Login,this.txtContraseniaActual.Text, this.txtContraseniaNueva.Text);
                    MessageBox.Show("Contraseña modificada con exito");
                    this.Visible = false;
   
                }
                else
                {
                    MessageBox.Show("Pueda ser que las contraseña no coincidad o faltan datos que digitar");
                }


            }
            catch
            {
                MessageBox.Show("Asegurese de que los datos ingresados son los correctos");
            }
        }
    }
}
