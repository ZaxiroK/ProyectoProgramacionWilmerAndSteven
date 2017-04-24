using ProyectoPrograWilmerAndSteven.Datos;
using ProyectoPrograWilmerAndSteven.Reportes;
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
    public partial class FrmInformeRepuesto : Form
    {
        private int id_cata;
        public FrmInformeRepuesto()
        {
            InitializeComponent();
        }

        public FrmInformeRepuesto( int id)
        {
            InitializeComponent();
            this.id_cata = id;
            cargarReporte();
        }

        private void cargarReporte()
        {
             OrdenRepuestoD pOrdenRepuestoD = new OrdenRepuestoD();
            rpInformeRepuesto rp = new rpInformeRepuesto();

            rp.SetDataSource(pOrdenRepuestoD.reporteRepuestos(id_cata));
            this.crystalReportViewer1.ReportSource = rp;

        }
    }
}
