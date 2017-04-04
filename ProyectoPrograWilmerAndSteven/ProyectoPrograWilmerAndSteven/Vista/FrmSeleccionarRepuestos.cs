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
    public partial class FrmSeleccionarRepuestos : Form
    {
        private CatalogoRepuestoE oRepuesto;
        private OrdenRepuestoE oOrdenRepuesto;
        private List<OrdenRepuestoE> listaOrdenRepuesto = new List<OrdenRepuestoE>();
        private bool aceptar;

        public CatalogoRepuestoE ORepuesto
        {
            get
            {
                return oRepuesto;
            }

            set
            {
                oRepuesto = value;
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

        public List<OrdenRepuestoE> ListaOrdenRepuesto
        {
            get
            {
                return listaOrdenRepuesto;
            }

            set
            {
                listaOrdenRepuesto = value;
            }
        }

        public FrmSeleccionarRepuestos()
        {
            InitializeComponent();
            this.llenarComboCantidad();
            this.llenarComboRepuesto();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            if ((this.cmbCantidad.SelectedItem != null) && (this.cmbRepuestos.SelectedItem != null))
            {
                this.oRepuesto = ((CatalogoRepuestoE)this.cmbRepuestos.SelectedItem);

                this.oOrdenRepuesto = new OrdenRepuestoE(((Int32)this.cmbCantidad.SelectedItem),
                   this.oRepuesto.IdCatalogoRepuesto, this.oRepuesto.NombreDelRepuesto, this.oRepuesto.AnnoAlQuePertenece,
                    this.oRepuesto.Precio);


                this.aceptar = true;
                this.ListaOrdenRepuesto.Add(oOrdenRepuesto);
                MessageBox.Show("¡Repuesto agregado!" +"\n" + "Presione salir para volver al menu principal "+"\n" +" o continue seleccionando más repuestos.");
                this.cmbCantidad.SelectedIndex = -1;
                this.cmbRepuestos.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar el repuesto y la cantidad!");
            }
        }

        public void llenarComboRepuesto()
        {

            CatalogoRepuestoD oRepuestosD = new CatalogoRepuestoD();
            List<CatalogoRepuestoE> repuestos = oRepuestosD.obtenerCatalogoRepuestos();

            foreach (CatalogoRepuestoE oRespuestoE in repuestos)
            {
                this.cmbRepuestos.Items.Add(oRespuestoE);
            }
        }

        public void llenarComboCantidad()
        {
          for (int i = 1; i < 300; i++)
            {
                this.cmbCantidad.Items.Add(i);
            }

        }
    }
}
