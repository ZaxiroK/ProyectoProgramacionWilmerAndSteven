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
    public partial class FrmRegistroModelo : Form
    {
        public bool aceptar;
        public ModeloE oModelo;
        public FrmRegistroModelo()
        {
            InitializeComponent();
            this.llenarComboMarcas();
            
        }
        

        public FrmRegistroModelo(ModeloE pModelo)
        {

            InitializeComponent();
            this.llenarComboMarcas();
            this.oModelo = pModelo;
            this.txtId.Text = pModelo.IdModelo.ToString();
            this.comboBoxMarcas.SelectedItem = pModelo.OMarca.ToString(); 
            this.txtDescripcion.Text = pModelo.Descripcion.ToString();
            this.txtAnio.Text = pModelo.Anno.ToString();
               
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
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

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            
        }

        public void llenarComboMarcas()
        {
            this.comboBoxMarcas.Items.Clear(); 
            MarcaD oMarcaD = new MarcaD();
            List<MarcaE> marcas = oMarcaD.obtenerMarcas();

            foreach (MarcaE oMarcaE in marcas)
            {
                this.comboBoxMarcas.Items.Add(oMarcaE);
                this.comboBoxMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxMarcas.SelectedIndex = comboBoxMarcas.Items.Count - 1;

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

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtAnio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
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

        private void txtAnio_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!(this.txtId.Text == "") && !(this.txtAnio.Text == ""))
                {


                    this.oModelo = new ModeloE(Convert.ToInt32(this.txtId.Text), this.txtDescripcion.Text, ((MarcaE)this.comboBoxMarcas.SelectedItem), Convert.ToInt32(this.txtAnio.Text));
                    this.aceptar = true;
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

        private void buttonCancelar_Click_2(object sender, EventArgs e)
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
