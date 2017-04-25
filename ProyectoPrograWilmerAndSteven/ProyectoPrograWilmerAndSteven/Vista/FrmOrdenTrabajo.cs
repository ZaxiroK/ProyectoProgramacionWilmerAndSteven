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
    public partial class FrmOrdenTrabajo : Form
    {
        List<OrdenTrabajoE> ordenTrabajos = new List<OrdenTrabajoE>();
        string queryEstado = "";
        string queryCedula = "";
        public FrmOrdenTrabajo()
        {
            InitializeComponent();
            this.llenarCombos();
            this.cmbEstado.SelectedIndex = -1;
            this.cmbCliente.SelectedIndex = -1;
            this.queryEstado = "";
            this.queryCedula = "";
            this.cargarDTGview();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.btnRestablecer_Click(sender,  e);
            FrmRegistroDeOrdenDeTrabajo oFrm = new FrmRegistroDeOrdenDeTrabajo();
            oFrm.ShowDialog();
            this.cargarDTGview();

        }

        private void FrmOrdenTrabajo_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// carga el DTGOrdenTrabajos
        /// </summary>
        private void cargarDTGview()
        {
            DTGOrdenTrabajos.Rows.Clear();


            OrdenTrabajoD oTrabajoD = new OrdenTrabajoD();

            this.ordenTrabajos = oTrabajoD.obtenerOrdenTrabajos(this.queryCedula + this.queryEstado);

            foreach (OrdenTrabajoE oE in ordenTrabajos)
            {
                DTGOrdenTrabajos.Rows.Add(oE.IdOrdenDetrabajo.ToString(), oE.OVehiculo.ToString(),
                    oE.OMecanicoResponsable.ToString(), oE.FechaDeIngreso.ToString(),
                    oE.FechaDeSalida.ToString(), oE.FechaDeFacturacion.ToString(), 
                    oE.CalculoCostoTotal().ToString(), oE.Estado.ToString());

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.ordenTrabajos.Count > 0)
            {

                int fila = this.DTGOrdenTrabajos.CurrentRow.Index;

                

                FrmRegistroDeOrdenDeTrabajo oFrm = new FrmRegistroDeOrdenDeTrabajo(this.ordenTrabajos.ElementAt(fila));
                oFrm.ShowDialog();

                this.cargarDTGview();

            }
            else
            {
                MessageBox.Show("¡No hay ordenes de trabajo para editar!");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cmbEstado.SelectedIndex = -1;
            this.cmbCliente.SelectedIndex = -1;
            this.queryEstado = "";
            this.queryCedula = "";
            this.cargarDTGview();
        }

        public void llenarCombos()
        {
            this.cmbCliente.Items.Clear();
            ClienteD oClienteD = new ClienteD();

            List<ClienteE> clientes = oClienteD.obtenerClientes();

            foreach (ClienteE oClienteE in clientes)
            {
                this.cmbCliente.Items.Add(oClienteE);
                this.cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cmbCliente.SelectedIndex = -1;
            }

            this.cmbEstado.Items.Add("S");
            this.cmbEstado.Items.Add("N");
            this.cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEstado.SelectedIndex = -1;
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.queryCedula = "";
            this.queryCedula = " and c.cedula =" + (((ClienteE)this.cmbCliente.SelectedItem).Cedula).ToString();
            this.cargarDTGview();
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.queryEstado = "";
            if (this.cmbEstado.SelectedIndex == 0)
            {
                this.queryEstado = " and t.estado = 'S'";
                this.cargarDTGview();
            }
            else if(this.cmbEstado.SelectedIndex == 1)
            {
                this.queryEstado = " and t.estado = 'N'";
                this.cargarDTGview();
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            this.cmbEstado.SelectedIndex = -1;
            this.cmbCliente.SelectedIndex = -1;
            this.queryEstado = "";
            this.queryCedula = "";
            this.cargarDTGview();
        }
    }
}
