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
    public partial class FrmTallerMecanico : Form
    {
        public FrmTallerMecanico()
        {
            InitializeComponent();
        }
        

        private void ItemRegistroEmpleados(object sender, EventArgs e)
        {
            FrmEmpleado oFrm = new FrmEmpleado();
            oFrm.ShowDialog();
        }


        private void ItemRegistroClientes_Click(object sender, EventArgs e)
        {
            FrmClientes oFrmCliente = new FrmClientes();
            oFrmCliente.ShowDialog();
        }

        private void itemRegistroCatalogoRepuestos_Click(object sender, EventArgs e)
        {
            FrmCatalogoDeRepuesto oFrm = new FrmCatalogoDeRepuesto();
            oFrm.ShowDialog();
        }

        private void ItemRegistroCatalogoReparaciones_Click(object sender, EventArgs e)
        {
            FrmCatalogoDeReparaciones2 oFrm = new FrmCatalogoDeReparaciones2();
            oFrm.ShowDialog();
        }

        private void itemRegistroMarcas_Click(object sender, EventArgs e)
        {
            FrmMarca oFrm = new FrmMarca();
            oFrm.ShowDialog();
        }

        private void ItemRegistroDeModelo_Click(object sender, EventArgs e)
        {
            FrmModelo oFrm = new FrmModelo();
            oFrm.ShowDialog();
        }

        private void itemRegistroPuestos_Click(object sender, EventArgs e)
        {
            FrmPuesto oFrm = new FrmPuesto();
            oFrm.ShowDialog();
        }

        private void ItemRegistroVehiculos_Click(object sender, EventArgs e)
        {
            FrmVehiculo oFrm = new FrmVehiculo();
            oFrm.ShowDialog();
        }
        private void itemDerechosUsuarios_Click(object sender, EventArgs e)
        {
            FrmDerechosPorUsuarios oFrm = new FrmDerechosPorUsuarios();
            oFrm.ShowDialog();
        }

        private void itemCambioContrasenia_Click(object sender, EventArgs e)
        {

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuItemOrdenTrabajo_Click(object sender, EventArgs e)
        {
            FrmOrdenTrabajo oFrm = new FrmOrdenTrabajo();
            oFrm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInformeOrdenesFinalizadas frm = new frmInformeOrdenesFinalizadas();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmInformeOrdenesSinFinalizar frm = new FrmInformeOrdenesSinFinalizar();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmReparacionesAtendidasXmecánico frm = new FrmReparacionesAtendidasXmecánico();
            frm.ShowDialog();
        }

        private void gestíonGerencialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            FrmRespuestosInformacion frm = new FrmRespuestosInformacion();
            frm.ShowDialog();
        }
    }
}
