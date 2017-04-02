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
    public partial class FrmRegistroDePuestos : Form
    {
        public PuestoE oP;
        public bool aceptar;
        public FrmRegistroDePuestos()
        {
            InitializeComponent();
        }

        public FrmRegistroDePuestos(PuestoE oPu)
        {
            InitializeComponent();
            this.txtId.Text = oPu.IdPuesto.ToString();
            this.txtSalario.Text = oPu.Salario.ToString();
            this.txtDescripcion.Text = oPu.Descripcion;
            this.txtPuesto.Text = oPu.Puesto.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(this.txtId.Text == " ") && !(this.txtSalario.Text == " ") /*&& !(this.txtDescripcion.Text == " ")*/
                                && !(this.txtPuesto.Text == " "))
                {
                    if (!(this.txtDescripcion.Text == " "))
                    {


                        oP = new PuestoE(Convert.ToInt32(this.txtId.Text), Convert.ToDouble(this.txtSalario.Text),
                            Convert.ToChar(this.txtPuesto.Text), this.txtDescripcion.Text);
                        aceptar = true;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar todos los datos");
                    }
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

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtPuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(this.txtId.Text == " ") && !(this.txtSalario.Text == " ") /*&& !(this.txtDescripcion.Text == " ")*/
                       && !(this.txtPuesto.Text == " "))
                {
                    if (!(this.txtDescripcion.Text == " "))
                    {


                        oP = new PuestoE(Convert.ToInt32(this.txtId.Text), Convert.ToDouble(this.txtSalario.Text),
                            Convert.ToChar(this.txtPuesto.Text), this.txtDescripcion.Text);
                        aceptar = true;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar todos los datos");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Asegurese de que los datos ingresados son los correctos");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
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
    }
}


