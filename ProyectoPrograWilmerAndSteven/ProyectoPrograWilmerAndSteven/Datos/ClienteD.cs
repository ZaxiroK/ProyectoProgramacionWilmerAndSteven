﻿using Datos;
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
        /// <summary>
        /// obtiene un ClienteE de la bd
        /// </summary>
        /// <returns>retorna una lista de ClienteE</returns>
        public List<ClienteE> obtenerClientes()
        {

            this.limpiarError();
            List<ClienteE> clientes = new List<ClienteE>();
            DataSet dsetClientes;
            string sql = "select c.cedula as cedula, c.nombre as nombre," +
                            "c.apellido1 as apellido1, c.apellido2 as apellido2," +
                             "c.direccion as direccion, c.telefono1 as telefono1, c.telefono2 as telefono2,c.telefono3 as telefono3" +
                               " from schtaller.cliente c";

            dsetClientes = this.conexion.ejecutarConsultaSQL(sql);
            string error = this.conexion.ErrorDescripcion;
            foreach (DataRow tupla in dsetClientes.Tables[0].Rows)
            {
                ClienteE oCliente = new ClienteE(Convert.ToInt32(tupla[0].ToString()), tupla[1].ToString(),
                    tupla[2].ToString(), tupla[3].ToString(), tupla[4].ToString(), tupla[5].ToString(),
                    tupla[6].ToString(), tupla[7].ToString());
                clientes.Add(oCliente);
            }
            return clientes;
        }

       
        /// <summary>
        /// agrega un ClienteE a la bd
        /// </summary>
        /// <param name="pCliente">un ClienteE llamado pCliente</param>
        /// <returns>retorna un boleano dando a conocer si se guardo en la bd o no</returns>
        public bool agregarCliente(ClienteE pCliente)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.cliente(" +
            "cedula, nombre, apellido1, apellido2, direccion, telefono1, telefono2," +
            "telefono3)" +
        "VALUES(" +
            "@cedula, @nombre, @apellido1, @apellido2, @direccion, @telefono1, @telefono2," +
            "@telefono3);";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@cedula", NpgsqlDbType.Integer, pCliente.Cedula);
                oP.agregarParametro("@nombre", NpgsqlDbType.Varchar, pCliente.Nombre);
                oP.agregarParametro("@apellido1", NpgsqlDbType.Varchar, pCliente.Apellido1);
                oP.agregarParametro("@apellido2", NpgsqlDbType.Varchar, pCliente.Apellido2);
                oP.agregarParametro("@direccion", NpgsqlDbType.Varchar, pCliente.Direccion);
                oP.agregarParametro("@telefono1", NpgsqlDbType.Varchar, pCliente.Telefono1);
                oP.agregarParametro("@telefono2", NpgsqlDbType.Varchar, pCliente.Telefono2);
                oP.agregarParametro("@telefono3", NpgsqlDbType.Varchar, pCliente.Telefono3);
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
        /// <summary>
        /// borra un ClienteE de la bd
        /// </summary>
        /// <param name="pCliente">un ClienteE llamado pCliente</param>
        /// <returns>retorna un boleano dando a conocer si se borro en la bd o no</returns>
        public bool borrarCliente(ClienteE pCliente)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.cliente where cedula = @cedula";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
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
        /// <summary>
        /// modifica un ClienteE de la bd
        /// </summary>
        /// <param name="pCliente">un ClienteE llamado pCliente</param>
        /// <param name="cliente">un integer llamado cliente refiriendose a la cedula o id</param>
        /// <returns>retorna un boleano dando a conocer si se borro en la bd o no</returns>
        public bool modificarCliente(ClienteE pCliente, int cliente)
        {
            bool estado = true;

            try
            {

                string sql = "update schtaller.cliente set cedula = @cedula , nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2," +
                    "direccion = @direccion, telefono1 = @telefono1, telefono2 = @telefono2, telefono3 = @telefono3 where cedula = @cliente";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();

                oP.agregarParametro("@cedula", NpgsqlDbType.Integer, pCliente.Cedula);
                oP.agregarParametro("@nombre", NpgsqlDbType.Varchar, pCliente.Nombre);
                oP.agregarParametro("@apellido1", NpgsqlDbType.Varchar, pCliente.Apellido1);
                oP.agregarParametro("@apellido2", NpgsqlDbType.Varchar, pCliente.Apellido2);
                oP.agregarParametro("@direccion", NpgsqlDbType.Varchar, pCliente.Direccion);
                oP.agregarParametro("@telefono1", NpgsqlDbType.Varchar, pCliente.Telefono1);
                oP.agregarParametro("@telefono2", NpgsqlDbType.Varchar, pCliente.Telefono2);
                oP.agregarParametro("@telefono3", NpgsqlDbType.Varchar, pCliente.Telefono3);
                oP.agregarParametro("@cliente", NpgsqlDbType.Integer, cliente);

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
        /// <summary>
        /// comprueba si un ClienteE de la bd existe
        /// </summary>
        /// <param name="cedula">un integer llamado cedula refiriendose al id</param>
        /// <returns>un cliente si se encuentra en la bd</returns>
        public ClienteE comprobarDueño(int cedula)
        {

            this.limpiarError();
            ClienteE cliente = null;
            DataSet dsetClientes;
            string sql = "select c.cedula as cedula " +
                         "from schtaller.cliente c " +
                         "where cedula = " + "'" + cedula + "'";

            dsetClientes = this.conexion.ejecutarConsultaSQL(sql);

            if (!this.conexion.IsError)
            {
                if (dsetClientes.Tables[0].Rows.Count > 0)
                {
                    cliente = new ClienteE(Convert.ToInt32(dsetClientes.Tables[0].Rows[0].ToString()), dsetClientes.Tables[1].ToString(),
                    dsetClientes.Tables[2].ToString(), dsetClientes.Tables[3].ToString(), dsetClientes.Tables[4].ToString(), dsetClientes.Tables[5].ToString(),
                    dsetClientes.Tables[6].ToString(), dsetClientes.Tables[7].ToString());
                }
            }
            return cliente;
        }
        

    }
}