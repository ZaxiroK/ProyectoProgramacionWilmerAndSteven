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
    public partial class FrmRegistroDeOrdenDeTrabajo : Form
    {
        public FrmRegistroDeOrdenDeTrabajo()
        {
            InitializeComponent();
            this.llenarComboClientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        public void llenarComboClientes()
        {
            this.cmbCliente.Items.Clear();
            ClienteD oClienteD = new ClienteD();

            List<ClienteE> clientes = oClienteD.obtenerClientes();

            foreach (ClienteE oClienteE in clientes)
            {
                this.cmbCliente.Items.Add(oClienteE);
            }
        }

        public void llenarComboVehiculo(int pCedula)
        {

            VehiculoD oVehiculoD = new VehiculoD();
            List<VehiculoE> vehiculos = oVehiculoD.obtenerVehiculosOrdenTrabajo(pCedula);

            foreach (VehiculoE oVehiculoE in vehiculos)
            {
                this.cmbVehiculo.Items.Add(oVehiculoE);
            }
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cmbVehiculo.Items.Clear();
            this.llenarComboVehiculo(((ClienteE)this.cmbCliente.SelectedItem).Cedula);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmSeleccionarRepuestos oFRm = new FrmSeleccionarRepuestos();
            oFRm.ShowDialog();            
        }
    }
}
