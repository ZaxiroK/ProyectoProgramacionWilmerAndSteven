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
    public partial class FrmRegistroDeVehiculos : Form
    {
        public bool aceptar;
        public VehiculoE oVehiculoE;
        public FrmRegistroDeVehiculos()
        {
            InitializeComponent();
            llenarComboMarcas();
            
        }

        public void llenarComboMarcas()
        {
            this.comboBoxMarcas.Items.Clear();
            this.comboBoxModelos.Items.Clear();
            MarcaD oMarcaD = new MarcaD();
            List<MarcaE> marcas = oMarcaD.obtenerMarcas();

            foreach (MarcaE oMarcaE in marcas)
            {
                this.comboBoxMarcas.Items.Add(oMarcaE);
            }
        }
        public void llenarComboModelos(MarcaE pMarcaE)
        {
            this.comboBoxModelos.Items.Clear();
            ModeloD oModeloD = new ModeloD();
            List<ModeloE> modelos = oModeloD.obtenerModelos(pMarcaE);

            foreach (ModeloE oModeloE in modelos)
            {
                this.comboBoxModelos.Items.Add(oModeloE);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //if (!(this.comboBoxMarcas.SelectedItem == "") && 
            //    !(this.comboBoxModelos.SelectedItem == "") && 
            //    !(this.textAnio.Text == "") && 
            //    !(this.textPlaca.Text == "") &&
            //    !(this.textClaseDeVehiculo.Text == "") &&
            //    !(this.textCapacidadDePersonas.Text == "") &&
            //    !(this.textNumeroDeMotor.Text == "") &&
            //    !(this.textNumeroDeChasis.Text == "") &&
            //    !(this.textCombustible.Text == ""))
            //{
            //    z
            //    this.aceptar = true;

            //    this.oVehiculoE = new VehiculoE(Convert.ToInt32(idvehiculo), this.textPlaca.Text,
            //        this.textClaseDeVehiculo.Text, Convert.ToInt32(this.textCapacidadDePersonas),comboBoxModelos.SelectedItem, this.txtDireccion.Text,Puesto,
            //        this.txtTelefono.Text, this.txtTelefono2.Text, this.txtTelefono3.Text);

            //    this.Visible = false;
            //}
        }
    }
    
}
