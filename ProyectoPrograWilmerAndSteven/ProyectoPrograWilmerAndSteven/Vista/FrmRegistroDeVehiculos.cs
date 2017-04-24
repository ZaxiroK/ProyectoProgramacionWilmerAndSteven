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
        private ClienteE oClienteEeditar;
        private ModeloE oModeloEditar;

        public FrmRegistroDeVehiculos()
        {
            InitializeComponent();
            llenarComboClientes();
            llenarComboModelos();
            //comboBoxClientes.SelectedIndex = comboBoxClientes.Items.Count - 1;
            //comboBoxModelos.SelectedIndex = comboBoxModelos.Items.Count - 1;


        }

        public FrmRegistroDeVehiculos(VehiculoE oV)
        {

            InitializeComponent();
            this.txtId.Text = oV.IdVehiculo.ToString();
            this.textPlaca.Text = oV.Placa;
            this.textNumeroDeMotor.Text = oV.NumeroMotor;
            this.textCombustible.Text = oV.Combustible;
            this.textClaseDeVehiculo.Text = oV.ClaseVehiculo;
            this.textNumeroDeChasis.Text = oV.NumeroChasis;
            this.textCapacidadDePersonas.Text = oV.CapacidadPersonas.ToString();
            oClienteEeditar = oV.OClienteE;
            oModeloEditar = oV.OModeloE;
            this.llenarComboClientes();
            this.llenarComboModelos();
            this.setModeloComboActual(oModeloEditar.IdModelo);
            this.setClienteComboActual(oClienteEeditar.Cedula);

        }

        /// <summary>
        /// se encarga de asignarle al vehiculo el modeloE que tiene a la hora de editarlo (comboBoxModelos)
        /// </summary>
        /// <param name="id">un integer llamado id</param>
        private void setModeloComboActual(int id)
        {
            int i, x = 0;
            for (i = 0; i < this.comboBoxModelos.Items.Count; i++)
            {
                ModeloE oMe = (ModeloE)this.comboBoxModelos.Items[i];
                if (oMe.IdModelo == id)
                {
                    x = i;
                    i = this.comboBoxModelos.Items.Count;
                }
            }
            this.comboBoxModelos.SelectedIndex = x;
        }

        /// <summary>
        /// se encarga de asignarle al vehiculo el clienteE que tiene a la hora de editarlo (comboBoxClientes)
        /// </summary>
        /// <param name="id">un integer llamado cedula</param>
        private void setClienteComboActual(int cedula)
        {
            int i, x = 0;
            for (i = 0; i < this.comboBoxClientes.Items.Count; i++)
            {
                ClienteE oCe = (ClienteE)this.comboBoxClientes.Items[i];
                if (oCe.Cedula == cedula)
                {
                    x = i;
                    i = this.comboBoxModelos.Items.Count;
                }
            }
            this.comboBoxClientes.SelectedIndex = x;
        }
        /// <summary>
        /// llena el comboBoxModelos con modeloE
        /// </summary>
        public void llenarComboModelos()
        {

            this.comboBoxModelos.Items.Clear();
            ModeloD oModeloD = new ModeloD();

            List<ModeloE> modelos = oModeloD.obtenerModelos();

            foreach (ModeloE oModeloE in modelos)
            {

                this.comboBoxModelos.Items.Add(oModeloE);

            }
            this.comboBoxModelos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelos.SelectedIndex = comboBoxModelos.Items.Count - 1;

        }

        /// <summary>
        /// llena el comboBoxClientes con clienteE
        /// </summary>
        public void llenarComboClientes()
        {
            this.comboBoxClientes.Items.Clear();
            ClienteD oClienteD = new ClienteD();
            List<ClienteE> clientes = oClienteD.obtenerClientes();

            foreach (ClienteE oClienteE in clientes)
            {
                this.comboBoxClientes.Items.Add(oClienteE);
            }

            this.comboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientes.SelectedIndex = comboBoxClientes.Items.Count - 1;

        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
               !(this.comboBoxModelos.SelectedItem == null) &&
               !(this.txtId.Text.Trim() == "") &&
               !(this.textClaseDeVehiculo.Text.Trim() == "") &&
               !(this.textCapacidadDePersonas.Text.Trim() == "") &&
               !(this.textNumeroDeMotor.Text.Trim() == "") &&
               !(this.textNumeroDeChasis.Text.Trim() == "") &&
               !(this.textCombustible.Text.Trim() == ""))
                {

                    this.aceptar = true;

                    oVehiculoE = new VehiculoE(Convert.ToInt32(this.txtId.Text),
                        this.textPlaca.Text, this.textClaseDeVehiculo.Text, Convert.ToInt32(this.textCapacidadDePersonas.Text),
                        (ClienteE)this.comboBoxClientes.SelectedItem,
                        (ModeloE)this.comboBoxModelos.SelectedItem,
                        this.textNumeroDeMotor.Text, this.textNumeroDeChasis.Text, this.textCombustible.Text);

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
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
    }

}
