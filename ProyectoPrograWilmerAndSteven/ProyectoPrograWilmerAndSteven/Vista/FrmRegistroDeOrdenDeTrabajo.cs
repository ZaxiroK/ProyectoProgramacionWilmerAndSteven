using Datos;
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
        //VehiculoE pVehiculoE = new VehiculoE();
        ClienteE pClienteE = new ClienteE();
        AccesoDatosPostgre cnx;
        List<OrdenReparacionE> listOredenReparacion = new List<OrdenReparacionE>();
        List<OrdenRepuestoE> listOredenRepuesto = new List<OrdenRepuestoE>();
        OrdenTrabajoE ordenTrabajo;
        OrdenRepuestoD oOrdenRepuestoD = new OrdenRepuestoD();
        OrdenReparacionD oOrdenRepracionD = new OrdenReparacionD();
        OrdenTrabajoD oOrdenTrabajoD = new OrdenTrabajoD();
        int numeroOrdenFactura = 0;
        //OrdenTrabajoE pOrdenTrabajoE = new OrdenTrabajoE();
        int estado; // variable para saber si es edición o agregar
        
        public FrmRegistroDeOrdenDeTrabajo()
        {
            InitializeComponent();
            this.cnx = AccesoDatosPostgre.Instance;
            this.llenarComboClientes();
            this.llenarComboEmpleado();
            this.cmbVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.estado = 1;

        }

        public FrmRegistroDeOrdenDeTrabajo(OrdenTrabajoE pOrdenTrabajo)
        {
            InitializeComponent();
            this.cnx = AccesoDatosPostgre.Instance;
            this.llenarComboClientes();
            this.llenarComboEmpleado();
            this.ordenTrabajo = pOrdenTrabajo;
            this.validarEstado(this.ordenTrabajo);
            this.listOredenReparacion = pOrdenTrabajo.OrdenReparacion;
            this.listOredenRepuesto = pOrdenTrabajo.OrdenRepuesto;
            this.CargarDGviewReparacion(this.listOredenReparacion);
            this.CargarDGviewRepuesto(this.listOredenRepuesto);
            this.seleccionarItemsCombo();//setea los combos
            this.estado = 2;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            OrdenTrabajoE oOrdenTrabajoE = null;
            int numeroOrden = 0;
            if ((this.cmbCliente.SelectedIndex != -1) && (this.cmbEmpleado.SelectedIndex != -1)
                && (this.cmbVehiculo.SelectedIndex != -1))
            {
                this.cnx.iniciarTransaccion();// inicia transaccion
                if (estado == 1)
                {

                    oOrdenTrabajoE = new OrdenTrabajoE(DateTime.Now, DateTime.Now, DateTime.Now,
                        ((EmpleadoE)this.cmbEmpleado.SelectedItem), ((VehiculoE)this.cmbVehiculo.SelectedItem), 'N', 0,
                        this.listOredenRepuesto, this.listOredenReparacion);


                    String strNumeroOrden = oOrdenTrabajoD.agregarOrdenDeTrabajo(oOrdenTrabajoE,
                        oOrdenTrabajoE.CalculoCostoTotal());

                    numeroOrden = Convert.ToInt32(strNumeroOrden);

                }
                if (estado == 2)
                {
                    oOrdenTrabajoE = new OrdenTrabajoE(this.ordenTrabajo.FechaDeIngreso, this.ordenTrabajo.FechaDeSalida,
                        this.ordenTrabajo.FechaDeFacturacion, ((EmpleadoE)this.cmbEmpleado.SelectedItem), ((VehiculoE)this.cmbVehiculo.SelectedItem),
                        'N', 0, this.listOredenRepuesto, this.listOredenReparacion);

                    numeroOrden = this.ordenTrabajo.IdOrdenDetrabajo;
                    oOrdenTrabajoE.IdOrdenDetrabajo = this.ordenTrabajo.IdOrdenDetrabajo;

                    this.oOrdenTrabajoD.modificarOrdenDeTrabajo(oOrdenTrabajoE, oOrdenTrabajoE.CalculoCostoTotal());

                }

                if (oOrdenTrabajoD.Error)
                {
                    MessageBox.Show(oOrdenTrabajoD.ErrorMsg);
                    this.cnx.rollbackTransaccion();//en caso de error "rollback"
                    MessageBox.Show("¡Ha ocurrido un error al agregar orden de trabajo!");
                    return;
                }
                else
                {
                    bool estado = this.AgregarOrdenes(numeroOrden, oOrdenTrabajoE);
                    if (!estado)
                    {
                        this.cnx.rollbackTransaccion();//en caso de error "rollback"
                        MessageBox.Show("¡Ha ocurrido un error al agregar orden de trabajo!");
                        return;
                    }
                }



                if (estado == 1)
                {
                    
                    this.cnx.commitTransaccion();
                    MessageBox.Show("¡Orden de trabajo agregada con exito!");

                    

                }
                else
                {
                    this.cnx.commitTransaccion();
                    MessageBox.Show("¡Orden de trabajo editada con exito!");
                }

                this.restablecerValores();
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar todos los datos!");
            }

        }
        
        public void validarEstado(OrdenTrabajoE pOrdenTrabajoE)
        {
            if (pOrdenTrabajoE.Estado.Equals('S'))
            {
                this.btnFinalizar.Enabled = false;
                this.btnSalvar.Enabled = false;
                this.cmbCliente.Enabled = false;
                this.cmbVehiculo.Enabled = false;
                this.cmbEmpleado.Enabled = false;
                this.btnAgregar.Enabled = false;
                this.btnAgregarReparacion.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnEliminarReparacion.Enabled = false;
                this.btnEliminarRepuestos.Enabled = false;
                this.DTGreparaciones.Enabled = false;
                this.DTGrepuestos.Enabled = false;
            }
        }

        public void restablecerValores()
        {
            DTGrepuestos.Rows.Clear();
            DTGreparaciones.Rows.Clear();
            this.cmbCliente.SelectedIndex = -1;
            this.cmbEmpleado.SelectedIndex = -1;
            this.cmbVehiculo.SelectedIndex = -1;
            this.listOredenReparacion.Clear();
            this.listOredenRepuesto.Clear();
            this.ordenTrabajo = null;
        }

        public bool AgregarOrdenes(int numeroOrdenTrabajo, OrdenTrabajoE oOrdenTrabajoE)
        {
            bool estado = true;

            this.oOrdenRepracionD.borrarOrdenReparacion(this.ordenTrabajo);//borrar
            this.oOrdenRepuestoD.borrarOrdenDeRepuesto(this.ordenTrabajo);//borrar

            if ((oOrdenRepracionD.Error) || (oOrdenRepuestoD.Error))
            {
                estado = false;
            }


            if (oOrdenTrabajoE.OrdenReparacion.Count > 0)
            {
                foreach (OrdenReparacionE oR in oOrdenTrabajoE.OrdenReparacion)
                {
                    oOrdenRepracionD.agregarOrdenReparacion(oR, numeroOrdenTrabajo);
                    if (oOrdenRepracionD.Error)
                    {
                        estado = false;
                    }
                }
            }
            else
            {
                estado = false;
                MessageBox.Show("¡Error: debe haber almenos una orden de reparación seleccionada!");

            }

            if (oOrdenTrabajoE.OrdenRepuesto.Count > 0)
            {
                foreach (OrdenRepuestoE oR in oOrdenTrabajoE.OrdenRepuesto)
                {
                    oOrdenRepuestoD.agregarOrdenRpuesto(oR, numeroOrdenTrabajo);
                    if (oOrdenRepuestoD.Error)
                    {
                        estado = false;
                    }
                }
            }

            return estado;
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
                cmbCliente.SelectedIndex = -1;
            }
        }

        public void llenarComboVehiculo(int pCedula)
        {
            pClienteE.Cedula = pCedula;

            VehiculoD oVehiculoD = new VehiculoD();
            List<VehiculoE> vehiculos = oVehiculoD.obtenerVehiculosOrdenTrabajo(pCedula);

            foreach (VehiculoE oVehiculoE in vehiculos)
            {
                this.cmbVehiculo.Items.Add(oVehiculoE);
                this.cmbVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbVehiculo.SelectedIndex = -1;
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
            if (oFrm.Aceptar)
            {
                this.listOredenRepuesto = oFrm.CompararRepuesto;
                this.CargarDGviewRepuesto(this.listOredenRepuesto);
            }
        }


        private void btnAgregarReparacion_Click(object sender, EventArgs e)
        {
            FrmSeleccionarReparaciones oFrm = new FrmSeleccionarReparaciones();
            oFrm.ShowDialog();

            if (oFrm.Aceptar)
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
                cmbEmpleado.SelectedIndex = -1;
            }

        }

        public void seleccionarItemsCombo()
        {
            foreach (ClienteE cliente in cmbCliente.Items)
            {
                if (cliente.Cedula == this.ordenTrabajo.OVehiculo.OClienteE.Cedula)
                {
                    this.cmbCliente.SelectedItem = cliente;
                    this.cmbVehiculo.Items.Add(this.ordenTrabajo.OVehiculo);
                    this.cmbVehiculo.SelectedItem = this.ordenTrabajo.OVehiculo;
                }
            }

            foreach (EmpleadoE empleado in this.cmbEmpleado.Items)
            {
                if (empleado.Cedula == this.ordenTrabajo.OMecanicoResponsable.Cedula)
                {
                    this.cmbEmpleado.SelectedItem = empleado;
                }
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            OrdenTrabajoE oOrdenTrabajoE = null;
            int numeroOrden = 0;


            if ((this.cmbCliente.SelectedIndex != -1) && (this.cmbEmpleado.SelectedIndex != -1)
                && (this.cmbVehiculo.SelectedIndex != -1))
            {
                this.cnx.iniciarTransaccion();//Comienza transaccion
                if (estado == 1)
                {

                    oOrdenTrabajoE = new OrdenTrabajoE(DateTime.Now, DateTime.Now, DateTime.Now,
                        ((EmpleadoE)this.cmbEmpleado.SelectedItem), ((VehiculoE)this.cmbVehiculo.SelectedItem), 'S', 0,
                        this.listOredenRepuesto, this.listOredenReparacion);


                    String strNumeroOrden = oOrdenTrabajoD.agregarOrdenDeTrabajoFactura(oOrdenTrabajoE,
                        oOrdenTrabajoE.CalculoCostoTotal());

                    numeroOrden = Convert.ToInt32(strNumeroOrden);

                }
                if (estado == 2)
                {
                    oOrdenTrabajoE = new OrdenTrabajoE(this.ordenTrabajo.FechaDeIngreso, DateTime.Now,
                        this.ordenTrabajo.FechaDeFacturacion, ((EmpleadoE)this.cmbEmpleado.SelectedItem), ((VehiculoE)this.cmbVehiculo.SelectedItem),
                        'S', 0, this.listOredenRepuesto, this.listOredenReparacion);

                    numeroOrden = this.ordenTrabajo.IdOrdenDetrabajo;
                    oOrdenTrabajoE.IdOrdenDetrabajo = this.ordenTrabajo.IdOrdenDetrabajo;

                    this.oOrdenTrabajoD.modificarOrdenDeTrabajoFactura(oOrdenTrabajoE, oOrdenTrabajoE.CalculoCostoTotal());

                }
                if (oOrdenTrabajoD.Error)
                {
                    MessageBox.Show(oOrdenTrabajoD.ErrorMsg);
                    this.cnx.rollbackTransaccion();//en caso de error "rollback"
                    MessageBox.Show("¡Ha ocurrido un error al finalizar orden de trabajo!");
                    return;
                }
                else
                {
                    bool estado = this.AgregarOrdenes(numeroOrden, oOrdenTrabajoE);
                    if (!estado)
                    {
                        this.cnx.rollbackTransaccion();//en caso de error "rollback"
                        MessageBox.Show("¡Ha ocurrido un error al finalizar orden de trabajo!");
                        return;
                    }
                }

                this.cnx.commitTransaccion();//commit

                this.validarEstado(oOrdenTrabajoE);


                MessageBox.Show("¡Orden de trabajo finalizada con exito!");
                numeroOrdenFactura = numeroOrden;
                DialogResult result = MessageBox.Show("¿Desea facturar la orden?", "Facturar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    FrmReporteOrdenDeTrabajo oReporte = new FrmReporteOrdenDeTrabajo(numeroOrdenFactura, pClienteE.Cedula);
                    oReporte.ShowDialog();
                }
                else if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Cancel)
                {
                }
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar todos los datos!");
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

            if (ordenTrabajo == null)
            {
                MessageBox.Show("¡No hay orden de trabajo que facturar!");
            }
            else
            {
                 numeroOrdenFactura = ordenTrabajo.IdOrdenDetrabajo;
                FrmReporteOrdenDeTrabajo oReporte = new FrmReporteOrdenDeTrabajo(numeroOrdenFactura, pClienteE.Cedula);
                oReporte.ShowDialog();
            }
            
        }

        private void btnEliminarRepuestos_Click(object sender, EventArgs e)
        {
            if (this.DTGrepuestos.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.DTGrepuestos.CurrentRow.Index;


                    this.listOredenRepuesto.RemoveAt(fila);

                    this.CargarDGviewRepuesto(this.listOredenRepuesto);
                    MessageBox.Show("Repuesto borrado");
                }
            }
        }

        private void btnEliminarReparacion_Click(object sender, EventArgs e)
        {
            if (this.DTGreparaciones.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.DTGreparaciones.CurrentRow.Index;


                    this.listOredenReparacion.RemoveAt(fila);

                    this.CargarDGviewReparacion(this.listOredenReparacion);
                    MessageBox.Show("Reparación borrada");
                }
            }
        }
    }
}
