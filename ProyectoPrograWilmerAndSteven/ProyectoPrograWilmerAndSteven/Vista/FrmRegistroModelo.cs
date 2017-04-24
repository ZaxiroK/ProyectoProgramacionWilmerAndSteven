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
        public MarcaE oMarcaEActual;
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
            oMarcaEActual = pModelo.OMarca;
            setModeloActual(oMarcaEActual.IdMarca);

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
        /// <summary>
        /// llena el comboBoxMarcas con MarcasE
        /// </summary>
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
        /// <summary>
        /// asiga la marca que le pertenece al modelo a editar
        /// </summary>
        /// <param name="id">un integer llamado id</param>
        private void setModeloActual(int id)
        {
            int i, x = 0;
            for (i = 0; i < this.comboBoxMarcas.Items.Count; i++)
            {
                MarcaE oMe = (MarcaE)this.comboBoxMarcas.Items[i];
                if (oMe.IdMarca == id)
                {
                    x = i;
                    i = this.comboBoxMarcas.Items.Count;
                }
            }
            this.comboBoxMarcas.SelectedIndex = x;
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
