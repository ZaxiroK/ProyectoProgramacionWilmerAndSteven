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
        public VehiculoE vehiculoEcliente;
        List<OrdenReparacionE> listOredenReparacion = new List<OrdenReparacionE>();
        List<OrdenRepuestoE> listOredenRepuesto = new List<OrdenRepuestoE>();

        public FrmRegistroDeOrdenDeTrabajo()
        {
            InitializeComponent();
            this.llenarComboClientes();
            this.llenarComboEmpleado();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            OrdenTrabajoE oOrdenTrabajoE = new OrdenTrabajoE(DateTime.Now, DateTime.Now, DateTime.Now, ((EmpleadoE)this.cmbEmpleado.SelectedItem)
                ,((VehiculoE)this.cmbVehiculo.SelectedItem), 'N', 0, this.listOredenRepuesto, this.listOredenReparacion);
        }

        public void llenarComboClientes()
        {
            this.cmbCliente.Items.Clear();
            ClienteD oClienteD = new ClienteD();

            List<ClienteE> clientes = oClienteD.obtenerClientes();

            foreach (ClienteE oClienteE in clientes)
            {
                this.cmbCliente.Items.Add(oClienteE);
                this.cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCliente.SelectedIndex = cmbCliente.Items.Count - 1;
            }
        }

        public void llenarComboVehiculo(int pCedula)
        {

            VehiculoD oVehiculoD = new VehiculoD();
            List<VehiculoE> vehiculos = oVehiculoD.obtenerVehiculosOrdenTrabajo(pCedula);

            foreach (VehiculoE oVehiculoE in vehiculos)
            {
                this.cmbVehiculo.Items.Add(oVehiculoE);
                this.cmbVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbVehiculo.SelectedIndex = cmbVehiculo.Items.Count - 1;
            }
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cmbVehiculo.Items.Clear();
            this.llenarComboVehiculo(((ClienteE)this.cmbCliente.SelectedItem).Cedula);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmSeleccionarRepuestos oFrm = new FrmSeleccionarRepuestos(this.listOredenRepuesto);
            oFrm.ShowDialog();
            if(oFrm.Aceptar)
            {
                this.listOredenRepuesto = oFrm.CompararRepuesto;
                this.CargarDGviewRepuesto(this.listOredenRepuesto);
            }            
        }
        

        private void btnAgregarReparacion_Click(object sender, EventArgs e)
        {
            FrmSeleccionarReparaciones oFrm = new FrmSeleccionarReparaciones();
            oFrm.ShowDialog();

            if(oFrm.Aceptar)
            {
                this.agregarOrdenReparacion(oFrm.ListaOrdenReparacion);
                this.CargarDGviewReparacion(this.listOredenReparacion);
            }
        }

        
        private void agregarOrdenReparacion(List<OrdenReparacionE> pReparacion)
        {
            foreach (OrdenReparacionE oReparacion in pReparacion)
            {
                this.listOredenReparacion.Add(oReparacion);
            }
        }

        private void CargarDGviewRepuesto(List<OrdenRepuestoE> pRepuestos)
        {

            DTGrepuestos.Rows.Clear();


            foreach (OrdenRepuestoE oM in pRepuestos)
            {
                
                this.DTGrepuestos.Rows.Add(oM.IdCatalogoRepuesto.ToString(),
                    oM.NombreDelRepuesto.ToString(),
                    oM.AnnoAlQuePertenece.ToString(), oM.Precio.ToString()
                    , oM.Cantidad.ToString());
            }

        }

        private void CargarDGviewReparacion(List<OrdenReparacionE> pReparacion)
        {

            DTGreparaciones.Rows.Clear();


            foreach (OrdenReparacionE oM in pReparacion)
            {
                this.DTGreparaciones.Rows.Add(oM.Id_catalogoReparacion.ToString(),
                    oM.Descripcion.ToString(),
                    oM.HorasTotalReparacion.ToString(), oM.CostoReparacion.ToString()
                    , oM.CedulaEmpleado.ToString());
            }

        }
        public void llenarComboEmpleado()
        {

            EmpleadoD oEmpleadoD = new EmpleadoD();
            List<EmpleadoE> empleados = oEmpleadoD.obtenerEmpleados();

            foreach (EmpleadoE oEmpleadoE in empleados)
            {
                this.cmbEmpleado.Items.Add(oEmpleadoE);
                this.cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbEmpleado.SelectedIndex = cmbEmpleado.Items.Count - 1;
            }
        }

        private void setVehiculoActual(int id)
        {
            int i, x = 0;
            for (i = 0; i < this.cmbVehiculo.Items.Count; i++)
            {
                VehiculoE oVe = (VehiculoE)this.cmbVehiculo.Items[i];
                if (oVe.IdVehiculo == id)
                {
                    x = i;
                    i = this.cmbVehiculo.Items.Count;
                }
            }
            this.cmbVehiculo.SelectedIndex = x;
        }


    }
}
