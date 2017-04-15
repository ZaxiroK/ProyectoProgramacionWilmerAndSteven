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
        
        List<OrdenReparacionE> listOredenReparacion = new List<OrdenReparacionE>();
        List<OrdenRepuestoE> listOredenRepuesto = new List<OrdenRepuestoE>();
        OrdenTrabajoE ordenTrabajo;

        public FrmRegistroDeOrdenDeTrabajo()
        {
            InitializeComponent();
            this.llenarComboClientes();
            this.llenarComboEmpleado();
        }

        public FrmRegistroDeOrdenDeTrabajo(OrdenTrabajoE pOrdenTrabajo)
        {
            InitializeComponent();
            this.llenarComboClientes();
            this.llenarComboEmpleado();
            this.ordenTrabajo = pOrdenTrabajo;
            this.listOredenReparacion = pOrdenTrabajo.OrdenReparacion;
            this.listOredenRepuesto = pOrdenTrabajo.OrdenRepuesto;
            this.CargarDGviewReparacion(this.listOredenReparacion);
            this.CargarDGviewRepuesto(this.listOredenRepuesto);
            this.seleccionarItemsCombo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

                OrdenTrabajoE oOrdenTrabajoE = new OrdenTrabajoE(DateTime.Now, DateTime.Now, DateTime.Now,
                    ((EmpleadoE)this.cmbEmpleado.SelectedItem), ((VehiculoE)this.cmbVehiculo.SelectedItem), 'N', 0,
                    this.listOredenRepuesto, this.listOredenReparacion);


                OrdenTrabajoD oOrdenTrabajoD = new OrdenTrabajoD();
                string numeroOrden = oOrdenTrabajoD.agregarOrdenDeTrabajo(oOrdenTrabajoE,
                    oOrdenTrabajoE.CalculoCostoTotal());

                if (!oOrdenTrabajoD.Error)
                {
                    MessageBox.Show(oOrdenTrabajoD.ErrorMsg);
                }

                OrdenReparacionD oOrdenRepracionD = new OrdenReparacionD();
                foreach (OrdenReparacionE oR in oOrdenTrabajoE.OrdenReparacion)
                {
                    oOrdenRepracionD.agregarOrdenReparacion(oR, Convert.ToInt32(numeroOrden));
                }

                OrdenRepuestoD oOrdenRepuestoD = new OrdenRepuestoD();
                foreach (OrdenRepuestoE oR in oOrdenTrabajoE.OrdenRepuesto)
                {
                    oOrdenRepuestoD.agregarOrdenRpuesto(oR, Convert.ToInt32(numeroOrden));
                }
        

            FrmReporteOrdenDeTrabajo oReporte = new FrmReporteOrdenDeTrabajo(int.Parse(numeroOrden));
            oReporte.ShowDialog();

    

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
                cmbCliente.SelectedIndex =  - 1;
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
                cmbVehiculo.SelectedIndex =  - 1;
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
                cmbEmpleado.SelectedIndex =  - 1;
            }

        }

        public void seleccionarItemsCombo()
        {
            foreach (ClienteE cliente in cmbCliente.Items)
            {
                if(cliente.Cedula == this.ordenTrabajo.OVehiculo.OClienteE.Cedula)
                {
                    this.cmbCliente.SelectedItem = cliente;
                    this.cmbVehiculo.Items.Add(this.ordenTrabajo.OVehiculo);
                    this.cmbVehiculo.SelectedItem = this.ordenTrabajo.OVehiculo;
                }
            }

            foreach (EmpleadoE empleado in this.cmbEmpleado.Items)
            {
                if(empleado.Cedula == this.ordenTrabajo.OMecanicoResponsable.Cedula)
                {
                    this.cmbEmpleado.SelectedItem = empleado;
                }
            }



        }
    }
}
