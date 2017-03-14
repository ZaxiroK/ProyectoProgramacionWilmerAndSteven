﻿using Datos;
using Logica;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograWilmerAndSteven.Datos
{
    public class VehiculoD
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

        public VehiculoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<VehiculoE> obtenerVehiculos(ClienteE pClienten, ModeloE pModelo)
        {
            this.limpiarError();
        List<VehiculoE> vehiculos = new List<VehiculoE>();
        DataSet dsetVehiculos;
        string sql = "select v.id_vehiculo as idVehiculo, v.placa as placa, v.clase_de_vehiculo as claseVehiculo, " +
            "v.capacidad_de_personas as capacidadPersonas, v.numero_de_motor as numeroMotor, v.numero_de_chasis as numeroChasis, " +
            "v.combustible as combustible," +
            "c.cedula as cedula, c.nombre as nombre," +
            "c.apellido1 as apellido1, c.apellido2 as apellido2," +
            "c.direccion as direccion, c.telefono1 as telefono1, c.telefono2 as telefono2,c.telefono3 as telefono3," +
            "mo.id_modelo  as idModelo, mo.descripcion  as descripcion, mo.anio as anno," +
            "m.id_marca as idMarca, m.descripcion as descripcion" +
            "from Vehiculo v, Cliente c,Modelo mo, Marca m" +
            "where v.cedula = c.cedula and v.idModelo = mo.id_modelo";

            if (pClienten != null)
            {
                sql += "and c.cedula = @cliente";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@cliente", NpgsqlDbType.Varchar, pClienten.Cedula);
                dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql, "vehiculo", oParametro.obtenerParametros());
            }
            else
            {
                dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql);
            }
            if (pModelo != null)
            {
                sql += "and mo.idModelo = @modelo";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@modelo", NpgsqlDbType.Varchar, pClienten.Cedula);
                dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql, "vehiculo", oParametro.obtenerParametros());
            }
            else
            {
                dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql);
            }
            foreach (DataRow tupla in dsetVehiculos.Tables[0].Rows)
            {
                ClienteE oCliente = new ClienteE(Convert.ToInt32(tupla["cedula"].ToString()), tupla["nombre"].ToString(),
                    tupla["apellido1"].ToString(), tupla["apellido2"].ToString(), tupla["direccion"].ToString(), tupla["telelfono1"].ToString(),
                    tupla["telefono2"].ToString(), tupla["telefono3"].ToString());

                MarcaE oMarca = new MarcaE(Convert.ToInt32(tupla["idMarca"].ToString()), tupla["descripcion"].ToString());

                ModeloE oModelo = new ModeloE(Convert.ToInt32(tupla["idModelo"].ToString()), tupla["descripcion"].ToString(), oMarca, Convert.ToInt32(tupla["anio"].ToString()));

                VehiculoE oVehiculo = new VehiculoE(Convert.ToInt32(tupla["idVehiculo"].ToString()), tupla["placa"].ToString(), tupla["claseVehiculo"].ToString()
                    , Convert.ToInt32(tupla["capacidadPersonas"].ToString()),oCliente, oModelo, tupla["numeroMotor"].ToString(), tupla["numeroChasis"].ToString()
                    , tupla["combustible"].ToString());
                vehiculos.Add(oVehiculo);
            }
            return vehiculos;
        }     
    }
}