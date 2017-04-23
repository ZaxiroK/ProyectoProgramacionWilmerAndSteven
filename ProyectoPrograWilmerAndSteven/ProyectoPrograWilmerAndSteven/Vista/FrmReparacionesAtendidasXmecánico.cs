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
    public partial class FrmReparacionesAtendidasXmecánico : Form
    {
        private DateTime fechEntrada;
        private DateTime fechSalida;
        public FrmReparacionesAtendidasXmecánico()
        {
            InitializeComponent();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            fechEntrada = fechaEntrada.Value;
            fechSalida = FechaSalida.Value;
            FrmInformeReparacionesAtendidasXmecanico frm = new FrmInformeReparacionesAtendidasXmecanico(fechEntrada, fechSalida);
            frm.ShowDialog();
        }
    }
}
