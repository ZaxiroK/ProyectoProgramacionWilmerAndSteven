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
 
        }

        
        public void llenarComboModelos()
        {
            int posicion = 1;
            int posicion2 = 1;
            this.comboBoxModelos.Items.Clear();
            ModeloD oModeloD = new ModeloD();

            List<ModeloE> modelos = oModeloD.obtenerModelos();

            foreach (ModeloE oModeloE in modelos)
            {
                
                if (oModeloE.Equals(oModeloEditar))//no quiere entrar al if aunque sea igual
                {
                    posicion = posicion2;//posicion ser igual al numero donde los objetos eran equivalentes
                }
                posicion2 += 1;// al final de todo el for posicion2 va a ser = 6
                this.comboBoxModelos.Items.Add(oModeloE);
                this.comboBoxModelos.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxModelos.SelectedIndex = comboBoxModelos.Items.Count - (posicion2-posicion);
                //se resta por que el combo se llena alrevez es decir las posiciones, es decir q la 1 es la 5.
                /*
                 *6 -1 = 5
                 *6 -2 = 4
                 *6 -3 = 3
                 *6 -4 = 2
                 *6 -5 = 1
                 * se obtiene las posciones al revez en caso de que fueran 5 o mas 
                 */
            }

        }
        public void llenarComboClientes()
        {
            int posicion = 1;
            this.comboBoxClientes.Items.Clear();
            ClienteD oClienteD = new ClienteD();
            List<ClienteE> clientes = oClienteD.obtenerClientes();
            
            foreach (ClienteE oClienteE in clientes)
            {
                this.comboBoxClientes.Items.Add(oClienteE);
                if (oClienteE == oClienteEeditar)
                {
                    posicion = comboBoxClientes.Items.Count;
                }
                this.comboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
               !(this.comboBoxModelos.SelectedItem == null) &&
               !(this.txtId.Text == "") &&
               !(this.textClaseDeVehiculo.Text == "") &&
               !(this.textCapacidadDePersonas.Text == "") &&
               !(this.textNumeroDeMotor.Text == "") &&
               !(this.textNumeroDeChasis.Text == "") &&
               !(this.textCombustible.Text == ""))
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

  

    }

}
