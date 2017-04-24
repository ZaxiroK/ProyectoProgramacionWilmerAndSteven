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
                this.cmbRepuestos.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbRepuestos.SelectedIndex = cmbRepuestos.Items.Count - 1;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogoRepuestoE pCata = ((CatalogoRepuestoE)this.cmbRepuestos.SelectedItem);
                FrmInformeRepuesto frm = new FrmInformeRepuesto(pCata.IdCatalogoRepuesto);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    
}
