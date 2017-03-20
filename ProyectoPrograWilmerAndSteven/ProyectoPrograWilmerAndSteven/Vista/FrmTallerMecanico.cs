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

        private void FrmTallerMecanico_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEmpleado oFrm = new FrmEmpleado();
            oFrm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
    }
}
