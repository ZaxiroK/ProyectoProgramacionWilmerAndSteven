using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograWilmerAndSteven.Datos;
using Logica;

namespace ProyectoPrograWilmerAndSteven.Vista
{
    public partial class FrmClientes : Form
    {
        ClienteD oClienteD = new ClienteD();
        public FrmClientes()
        {
            InitializeComponent();
            this.CargarDGview();
            dGViewClientes.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente oFrm = new FrmRegistroCliente();
            oFrm.ShowDialog();

            if (oFrm.aceptar)
            {
                if (oClienteD.agregarCliente(oFrm.oCliente))
                {
                    this.CargarDGview();
                    MessageBox.Show("Cliente agregado");
                }
                else
                {
                    MessageBox.Show("Error al agregar cliente: " +
                               oClienteD.ErrorMsg, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarDGview()
        {
            this.dGViewClientes.DataSource = "";

            List<ClienteE> cliente = oClienteD.obtenerClientes();
            if (!oClienteD.Error)
            {
                this.dGViewClientes.DataSource = cliente;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.CargarDGview();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dGViewClientes.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de borrar?",
                                                         "Error",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    int fila = this.dGViewClientes.CurrentRow.Index;

                    ClienteE oClienteE = new ClienteE(Convert.ToInt32(this.dGViewClientes[0, fila].Value.ToString()),
                                             this.dGViewClientes[1, fila].Value.ToString(),
                                             this.dGViewClientes[2, fila].Value.ToString(),
                                             this.dGViewClientes[3, fila].Value.ToString(),
                                             this.dGViewClientes[4, fila].Value.ToString(),
                                             this.dGViewClientes[5, fila].Value.ToString(),
                                             this.dGViewClientes[6, fila].Value.ToString(),
                                             this.dGViewClientes[7, fila].Value.ToString());


                    if (oClienteD.borrarCliente(oClienteE))
                    {
                        this.CargarDGview();
                        MessageBox.Show("Cliente borrado");
                    }
                    else
                    {
                        MessageBox.Show("Error borrando el cliente: " +
                                   oClienteD.ErrorMsg, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {

            if (this.dGViewClientes.Rows.Count > 0)
            {

                int fila = this.dGViewClientes.CurrentRow.Index;

                ClienteE oClienteE = new ClienteE(Convert.ToInt32(this.dGViewClientes[0, fila].Value.ToString()),
                                         this.dGViewClientes[1, fila].Value.ToString(),
                                         this.dGViewClientes[2, fila].Value.ToString(),
                                         this.dGViewClientes[3, fila].Value.ToString(),
                                         this.dGViewClientes[4, fila].Value.ToString(),
                                         this.dGViewClientes[5, fila].Value.ToString(),
                                         this.dGViewClientes[6, fila].Value.ToString(),
                                         this.dGViewClientes[7, fila].Value.ToString());

                FrmRegistroCliente oFrm = new FrmRegistroCliente(oClienteE);
                oFrm.ShowDialog();
                if (oFrm.aceptar)
                {

                    if (oClienteD.modificarCliente(oFrm.oCliente, Convert.ToInt32(this.dGViewClientes[0, fila].Value.ToString())));
                    {
                        this.CargarDGview();
                        MessageBox.Show("Cliente actualizado");
                    }

                }

            }
        }
    }
}
