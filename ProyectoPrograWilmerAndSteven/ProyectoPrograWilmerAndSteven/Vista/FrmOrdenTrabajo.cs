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
        public FrmOrdenTrabajo()
        {
            InitializeComponent();
            this.cargarDTGview();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
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

            this.ordenTrabajos = oTrabajoD.obtenerOrdenTrabajos();

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
            this.cargarDTGview();
        }
    }
}
