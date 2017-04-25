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
    public partial class FrmSeleccionarReparaciones : Form
    {
        private CatalogoReparacionE oReparacion;
        private OrdenReparacionE oOrdenReparacion;
        private List<OrdenReparacionE> listaOrdenReparacion = new List<OrdenReparacionE>();
        private bool aceptar;
        
        public CatalogoReparacionE OReparacion
        {
            get
            {
                return oReparacion;
            }

            set
            {
                oReparacion = value;
            }
        }

        public OrdenReparacionE OOrdenReparacion
        {
            get
            {
                return oOrdenReparacion;
            }

            set
            {
                oOrdenReparacion = value;
            }
        }

        public List<OrdenReparacionE> ListaOrdenReparacion
        {
            get
            {
                return listaOrdenReparacion;
            }

            set
            {
                listaOrdenReparacion = value;
            }
        }

        public bool Aceptar
        {
            get
            {
                return aceptar;
            }

            set
            {
                aceptar = value;
            }
        }

        public FrmSeleccionarReparaciones()
        {
            InitializeComponent();
            this.llenarComboEmpleado();
            this.llenarComboReparacion();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((this.numericHoras.Value > 0) && (this.cmbEmpleado.SelectedItem != null) && 
                (this.cmbReparacion.SelectedItem != null))
            {
                this.OReparacion = ((CatalogoReparacionE)this.cmbReparacion.SelectedItem);

                this.OOrdenReparacion = new OrdenReparacionE(((EmpleadoE)this.cmbEmpleado.SelectedItem).Cedula,
                   ((Int32)this.numericHoras.Value), OReparacion.Id_catalogoReparacion,
                   this.OReparacion.Descripcion,
                    this.OReparacion.HorasReparacion, this.OReparacion.CostoReparacion);


                this.Aceptar = true;
                this.ListaOrdenReparacion.Add(OOrdenReparacion);
                MessageBox.Show("¡Reparacion agregada!" + "\n" + "Presione salir para volver al menu principal " + "\n" + " o continue seleccionando más repuestos.");
                this.cmbReparacion.SelectedIndex = -1;
                this.cmbEmpleado.SelectedIndex = -1;
                this.numericHoras.Value = 0;
            }
            else
            {
                MessageBox.Show("¡Por favor ingrese todos los datos!");
            }
        }
        /// <summary>
        /// llena el cmbReparacion con ReparacionE
        /// </summary>
        public void llenarComboReparacion()
        {

            CatalogoReparacionD oReparacionD = new CatalogoReparacionD();
            List<CatalogoReparacionE> reparacion = oReparacionD.obtenerCatalogoReaparaciones();

            foreach (CatalogoReparacionE oReparacionE in reparacion)
            {
                this.cmbReparacion.Items.Add(oReparacionE);
                this.cmbReparacion.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbReparacion.SelectedIndex = -1;
            }
        }
        /// <summary>
        /// llena el cmbEmpleado con EmpleadoE
        /// </summary>
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




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
