﻿using Logica;
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
        OrdenRepuestoD oOrdenRepuestoD = new OrdenRepuestoD();
        OrdenReparacionD oOrdenRepracionD = new OrdenReparacionD();
        OrdenTrabajoD oOrdenTrabajoD = new OrdenTrabajoD();
        int estado; // variable para saber si es edición o agregar

        public FrmRegistroDeOrdenDeTrabajo()
        {
            InitializeComponent();
            this.llenarComboClientes();
            this.llenarComboEmpleado();
            this.estado = 1;
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
            this.seleccionarItemsCombo();//setea los combos
            this.estado = 2; 
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            OrdenTrabajoE oOrdenTrabajoE = null;
            int numeroOrden = 0;

            if (estado == 1)
            {

                oOrdenTrabajoE = new OrdenTrabajoE(DateTime.Now, DateTime.Now, DateTime.Now,
                    ((EmpleadoE)this.cmbEmpleado.SelectedItem), ((VehiculoE)this.cmbVehiculo.SelectedItem), 'N', 0,
                    this.listOredenRepuesto, this.listOredenReparacion);
            
                
                String strNumeroOrden = oOrdenTrabajoD.agregarOrdenDeTrabajo(oOrdenTrabajoE,
                    oOrdenTrabajoE.CalculoCostoTotal());

                numeroOrden = Convert.ToInt32(strNumeroOrden);

            }
            if(estado == 2)
            {
                oOrdenTrabajoE = new OrdenTrabajoE(this.ordenTrabajo.FechaDeIngreso, this.ordenTrabajo.FechaDeSalida,
                    this.ordenTrabajo.FechaDeFacturacion,((EmpleadoE)this.cmbEmpleado.SelectedItem), ((VehiculoE)this.cmbVehiculo.SelectedItem),
                    'N', 0,this.listOredenRepuesto, this.listOredenReparacion);

                numeroOrden = this.ordenTrabajo.IdOrdenDetrabajo;
                oOrdenTrabajoE.IdOrdenDetrabajo = this.ordenTrabajo.IdOrdenDetrabajo;

                this.oOrdenTrabajoD.modificarOrdenDeTrabajo(oOrdenTrabajoE, oOrdenTrabajoE.CalculoCostoTotal());

            }   

                if (!oOrdenTrabajoD.Error)
                {
                    MessageBox.Show(oOrdenTrabajoD.ErrorMsg);
                }
                else
                {
                    this.AgregarOrdenes(numeroOrden, oOrdenTrabajoE);
                }

                    
           //FrmReporteOrdenDeTrabajo oReporte = new FrmReporteOrdenDeTrabajo(numeroOrden);
            //oReporte.ShowDialog();
        }

        public void AgregarOrdenes(int numeroOrdenTrabajo, OrdenTrabajoE oOrdenTrabajoE)
        {

            this.oOrdenRepracionD.borrarOrdenReparacion(this.ordenTrabajo);//borrar
            this.oOrdenRepuestoD.borrarOrdenDeRepuesto(this.ordenTrabajo);//borrar

            foreach (OrdenReparacionE oR in oOrdenTrabajoE.OrdenReparacion)
            {
                oOrdenRepracionD.agregarOrdenReparacion(oR, numeroOrdenTrabajo);
            }


            foreach (OrdenRepuestoE oR in oOrdenTrabajoE.OrdenRepuesto)
            {
                oOrdenRepuestoD.agregarOrdenRpuesto(oR, numeroOrdenTrabajo);
            }
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            OrdenTrabajoE oOrdenTrabajoE = null;
            int numeroOrden = 0;

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

            if (!oOrdenTrabajoD.Error)
            {
                MessageBox.Show(oOrdenTrabajoD.ErrorMsg);
            }
            else
            {
                this.AgregarOrdenes(numeroOrden, oOrdenTrabajoE);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

        }
    }
}
