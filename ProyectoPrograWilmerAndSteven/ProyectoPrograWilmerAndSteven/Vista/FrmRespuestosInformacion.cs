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
    public partial class FrmRespuestosInformacion : Form
    {

        
        public FrmRespuestosInformacion()
        {
            InitializeComponent();
            llenarComboRepuesto();
        }

        public void llenarComboRepuesto()
        {

            CatalogoRepuestoD oRepuestosD = new CatalogoRepuestoD();
            List<Logica.CatalogoRepuestoE> repuestos = oRepuestosD.obtenerCatalogoRepuestos();

            foreach (CatalogoRepuestoE oRespuestoE in repuestos)
            {
                this.cmbRepuestos.Items.Add(oRespuestoE);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CatalogoRepuestoE pCata = ((CatalogoRepuestoE)this.cmbRepuestos.SelectedItem);
            FrmInformeRepuesto frm = new FrmInformeRepuesto(pCata.IdCatalogoRepuesto);
            frm.ShowDialog();
        }
    }

    
}
