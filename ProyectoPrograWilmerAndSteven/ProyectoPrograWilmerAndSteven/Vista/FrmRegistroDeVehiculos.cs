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
            llenarComboClientes();
            llenarComboModelos();

        }

        public FrmRegistroDeVehiculos(VehiculoE oV)
        {
            InitializeComponent();
            llenarComboClientes();
            this.llenarComboModelos();
            this.txtId.Text = oV.IdVehiculo.ToString();
            this.textPlaca.Text = oV.Placa;
            this.textNumeroDeMotor.Text = oV.NumeroMotor;
            this.textCombustible.Text = oV.Combustible;
            this.textClaseDeVehiculo.Text = oV.ClaseVehiculo;
            this.textNumeroDeChasis.Text = oV.NumeroChasis;
            this.textCapacidadDePersonas.Text = oV.CapacidadPersonas.ToString();
            this.comboBoxClientes.SelectedItem = oV.OClienteE;
            this.comboBoxModelos.SelectedValue = oV.OModeloE;
        }

        
        public void llenarComboModelos()
        {
            this.comboBoxModelos.Items.Clear();
            ModeloD oModeloD = new ModeloD();

            List<ModeloE> modelos = oModeloD.obtenerModelos();

            foreach (ModeloE oModeloE in modelos)
            {
                this.comboBoxModelos.Items.Add(oModeloE);
            }
        }
        public void llenarComboClientes()
        {
            this.comboBoxClientes.Items.Clear();
            ClienteD oClienteD = new ClienteD();
            List<ClienteE> clientes = oClienteD.obtenerClientes();

            foreach (ClienteE oClienteE in clientes)
            {
                this.comboBoxClientes.Items.Add(oClienteE);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (
                !(this.comboBoxModelos.SelectedItem == null) &&
                !(this.textPlaca.Text == "") &&
                !(this.textClaseDeVehiculo.Text == "") &&
                !(this.textCapacidadDePersonas.Text == "") &&
                !(this.textNumeroDeMotor.Text == "") &&
                !(this.textNumeroDeChasis.Text == "") &&
                !(this.textCombustible.Text == ""))
            {

                this.aceptar = true;

                oVehiculoE = new VehiculoE(Convert.ToInt32(this.txtId.Text), 
                    this.textPlaca.Text,this.textClaseDeVehiculo.Text,Convert.ToInt32(this.textCapacidadDePersonas.Text),
                    (ClienteE)this.comboBoxClientes.SelectedItem,
                    (ModeloE)this.comboBoxModelos.SelectedItem,
                    this.textNumeroDeMotor.Text, this.textNumeroDeChasis.Text, this.textCombustible.Text);

                this.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        
    }

}
