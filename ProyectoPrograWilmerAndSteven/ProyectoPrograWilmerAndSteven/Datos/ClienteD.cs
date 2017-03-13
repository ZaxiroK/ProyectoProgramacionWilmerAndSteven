using Datos;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograWilmerAndSteven.Datos
{
    public class ClienteD
    {
        private AccesoDatosPostgre conexion;

        private bool error;
        public bool Error
        {
            get { return error; }
        }

        private string errorMsg;
        public string ErrorMsg
        {
            get { return errorMsg; }
        }

        public ClienteD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ClienteE> obtenerClientes()
        {

            this.limpiarError();
            List<ClienteE> clientes = new List<ClienteE>();
            DataSet dsetClientes;
            string sql = "select c.cedula as cedula, c.nombre as nombre," +
                            "c.apellido1 as apellido1, c.apellido2 as apellido2," +
                             "c.direccion as direccion, c.telefono1 as telefono1, c.telefono2 as telefono2,c.telefono3 as telefono3" +
                               "from cliente c";

            dsetClientes = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetClientes.Tables[0].Rows)
            {
                ClienteE oCliente = new ClienteE(Convert.ToInt32(tupla["cedula"].ToString()),tupla["nombre"].ToString(),
                    tupla["apellido1"].ToString(), tupla["apellido2"].ToString(),tupla["direccion"].ToString(), tupla["telelfono1"].ToString(),
                    tupla["telefono2"].ToString(), tupla["telefono3"].ToString());
                clientes.Add(oCliente);
            }
            return clientes;
        }
    }
}
