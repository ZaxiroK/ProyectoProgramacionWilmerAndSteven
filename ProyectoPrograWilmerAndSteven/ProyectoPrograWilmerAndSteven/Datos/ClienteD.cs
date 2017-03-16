using Datos;
using Logica;
using Npgsql;
using NpgsqlTypes;
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
                ClienteE oCliente = new ClienteE(Convert.ToInt32(tupla["cedula"].ToString()), tupla["nombre"].ToString(),
                    tupla["apellido1"].ToString(), tupla["apellido2"].ToString(), tupla["direccion"].ToString(), tupla["telelfono1"].ToString(),
                    tupla["telefono2"].ToString(), tupla["telefono3"].ToString());
                clientes.Add(oCliente);
            }
            return clientes;
        }
        public bool agregarCliente(ClienteE pCliente)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.cliente(" +
            "cedula, nombre, apellido1, apellido2, direccion, telefono1, telefono2, telefono3); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@cedula", NpgsqlDbType.Integer, pCliente.Cedula);
                oP.agregarParametro("@nombre", NpgsqlDbType.Integer, pCliente.Nombre);
                oP.agregarParametro("@apellido1", NpgsqlDbType.Integer, pCliente.Apellido1);
                oP.agregarParametro("@apellido2", NpgsqlDbType.Integer, pCliente.Apellido2);
                oP.agregarParametro("@direccion", NpgsqlDbType.Integer, pCliente.Direccion);
                oP.agregarParametro("@telefono1", NpgsqlDbType.Integer, pCliente.Telefono1);
                oP.agregarParametro("@telefono2", NpgsqlDbType.Integer, pCliente.Telefono2);
                oP.agregarParametro("@telefono3", NpgsqlDbType.Integer, pCliente.Telefono3);
                this.conexion.ejecutarSQL(sql, oP.obtenerParametros());
                if (this.conexion.IsError)
                {

                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }

            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }
        public bool borrarCliente(ClienteE pCliente)
        {
            bool estado = true;
            try
            {
                string sql = "delete from cliente where cedula = @cedula";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@cedula";
                parametros[0].Value = pCliente.Cedula;

                this.conexion.ejecutarSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }
        public bool modificarCliente(ClienteE pCliente)
        {
            bool estado = true;

            try
            {
               
                string sql = "update cliente set cedula = @cedula , descripcion = @descripcion, apellido1 = @apellido1, apellido2 = @apellido2,"+
                    "direccion = @ direccion, telefono1 = @telefono1, telefono2 = telefono2, telefono3 = telefono3 where cliente = @cliente";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@cedula", NpgsqlDbType.Integer, pCliente.Cedula);
                oP.agregarParametro("@nombre", NpgsqlDbType.Integer, pCliente.Nombre);
                oP.agregarParametro("@apellido1", NpgsqlDbType.Integer, pCliente.Apellido1);
                oP.agregarParametro("@apellido2", NpgsqlDbType.Integer, pCliente.Apellido2);
                oP.agregarParametro("@direccion", NpgsqlDbType.Integer, pCliente.Direccion);
                oP.agregarParametro("@telefono1", NpgsqlDbType.Integer, pCliente.Telefono1);
                oP.agregarParametro("@telefono2", NpgsqlDbType.Integer, pCliente.Telefono2);
                oP.agregarParametro("@telefono3", NpgsqlDbType.Integer, pCliente.Telefono3);

                this.conexion.ejecutarSQL(sql, oP.obtenerParametros());
                if (this.conexion.IsError)
                {

                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }

            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }
    }
}