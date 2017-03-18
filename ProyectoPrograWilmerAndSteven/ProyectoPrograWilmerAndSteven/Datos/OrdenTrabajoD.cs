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
    public class OrdenTrabajoD
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

        public OrdenTrabajoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<OrdenTrabajoE> obtenerOrdenTrabajos(VehiculoE pVehiculo, EmpleadoE pEmpleado)
        {

            this.limpiarError();
            List<OrdenTrabajoE> ordenesTrabajos = new List<OrdenTrabajoE>();
            DataSet dsetOrdenTrabajos;



            string sql = "select t.id_orden_de_trabajo  as idOrdenDetrabajo, t.anio   as anno," +
                           " t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida," +
                            "t.fecha_de_facturacion as fechaDeFacturacion," +/* t.costo_total as costoTotal," +*/
                           " t.estado as estado, t.factura_numero as facturaNumero," +


                             "e.cedula as cedula , e.nombre as nombre, e.apellido1 as apellido1, e.apellido2 as apellido2," +
                              " e.direccion as direccion, e.telefono1 as telefono1, e.telefono2 as telefono2, e.telefono3 as telefono3," +
                               "p.id_puesto as id_puesto, p.salario as salario, " +
                              " p.puesto as puesto, p.descripcion as descripcion," +


                               " v.id_vehiculo as idVehiculo, v.placa as placa, v.clase_de_vehiculo as claseVehiculo," +
                                " v.capacidad_de_personas as capacidadPersonas, v.numero_de_motor as numeroMotor, v.numero_de_chasis as numeroChasis," +
                                "v.combustible as combustible," +
                                " c.cedula as cedula, c.nombre as nombre," +
                                " c.apellido1 as apellido1, c.apellido2 as apellido2," +
                                "c.direccion as direccion, c.telefono1 as telefono1, c.telefono2 as telefono2,c.telefono3 as telefono3," +
                               " mo.id_modelo as idModelo, mo.descripcion as descripcion, mo.anio as anno," +
                               " m.id_marca as idMarca, m.descripcion as descripcion" +
                               " from OrdenDeTrabajo t, empleado e, cliente c, modelo mo, marca m, puesto p, vehiculo v" +
                                " where t.id_empleado = e.cedula and t.id_vehiculo = v.id_vehiculo";



            dsetOrdenTrabajos = this.conexion.ejecutarConsultaSQL(sql);
            if (pVehiculo != null)
            {
                sql += "and v.id_vehiculo = @vehiculo";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@vehiculo", NpgsqlDbType.Varchar, pVehiculo.IdVehiculo);
                dsetOrdenTrabajos = this.conexion.ejecutarConsultaSQL(sql, "ordenDeTrabajo", oParametro.obtenerParametros());
            }
            else
            {
                dsetOrdenTrabajos = this.conexion.ejecutarConsultaSQL(sql);
            }
            if (pEmpleado != null)
            {
                sql += "and e.cedula = @empleado";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@empleado", NpgsqlDbType.Varchar, pEmpleado.Cedula);
                dsetOrdenTrabajos = this.conexion.ejecutarConsultaSQL(sql, "ordenDeTrabajo", oParametro.obtenerParametros());
            }
            else
            {
                dsetOrdenTrabajos = this.conexion.ejecutarConsultaSQL(sql);
            }
            foreach (DataRow tupla in dsetOrdenTrabajos.Tables[0].Rows)
            {
                PuestoE oPuesto = new PuestoE(Int32.Parse(tupla["id_puesto"].ToString()), Convert.ToDouble(tupla["salario"].ToString())
                    , Convert.ToChar(tupla["puesto"].ToString()), tupla["descripcion"].ToString());

                EmpleadoE oEmpleado = new EmpleadoE(Convert.ToInt32(tupla["cedula"].ToString()), tupla["nombre"].ToString(), tupla["apellido1"].ToString()
                    , tupla["apellido2"].ToString(), tupla["direccion"].ToString(), oPuesto, tupla["telefono1"].ToString(), tupla["telefono2"].ToString()
                    , tupla["telefono3"].ToString());

                ClienteE oCliente = new ClienteE(Convert.ToInt32(tupla["cedula"].ToString()), tupla["nombre"].ToString(),
                    tupla["apellido1"].ToString(), tupla["apellido2"].ToString(), tupla["direccion"].ToString(), tupla["telelfono1"].ToString(),
                    tupla["telefono2"].ToString(), tupla["telefono3"].ToString());

                MarcaE oMarca = new MarcaE(Convert.ToInt32(tupla["idMarca"].ToString()), tupla["descripcion"].ToString());

                ModeloE oModelo = new ModeloE(Convert.ToInt32(tupla["idModelo"].ToString()), tupla["descripcion"].ToString(), oMarca, Convert.ToInt32(tupla["anio"].ToString()));

                VehiculoE oVehiculo = new VehiculoE(Convert.ToInt32(tupla["idVehiculo"].ToString()), tupla["placa"].ToString(), tupla["claseVehiculo"].ToString()
                    , Convert.ToInt32(tupla["capacidadPersonas"].ToString()), oCliente, oModelo, tupla["numeroMotor"].ToString(), tupla["numeroChasis"].ToString()
                    , tupla["combustible"].ToString());

                OrdenTrabajoE oOrdenTrabajo = new OrdenTrabajoE(Convert.ToInt32(tupla["idOrdenDetrabajo"].ToString()), Convert.ToInt32(tupla["anno"].ToString()), Convert.ToDateTime(tupla["fechaDeIngreso"].ToString()),
                    Convert.ToDateTime(tupla["fechaDeSalida"].ToString()), Convert.ToDateTime(tupla["fechaDeFacturacion"].ToString()), oEmpleado, oVehiculo, Convert.ToChar(tupla["estado"].ToString()), Convert.ToInt32(tupla["facturaNumero"].ToString()));
                ordenesTrabajos.Add(oOrdenTrabajo);
            }
            return ordenesTrabajos;
        }
        public bool agregarOrdenDeTrabajo(OrdenTrabajoE pOrdenTrabajo)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.OrdenDeTrabajo(" +
            "id_orden_de_trabajo,anio, fecha_de_ingreso_de_vehiculo, fecha_de_salida, fecha_de_facturacion, costo_total, id_empleado, id_vehiculo, estado, factura_numero ); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_orden_de_trabajo", NpgsqlDbType.Integer, pOrdenTrabajo.IdOrdenDetrabajo);
                oP.agregarParametro("@fecha_de_ingreso_de_vehiculo", NpgsqlDbType.Integer, pOrdenTrabajo.FechaDeIngreso);
                oP.agregarParametro("@fecha_de_salida", NpgsqlDbType.Integer, pOrdenTrabajo.FechaDeSalida);
                oP.agregarParametro("@fecha_de_facturacion", NpgsqlDbType.Integer, pOrdenTrabajo.FechaDeFacturacion);
                /*oP.agregarParametro("@costo_total", NpgsqlDbType.Integer, pOrdenTrabajo.CostoTotal);*/
                oP.agregarParametro("@id_empleado", NpgsqlDbType.Integer, pOrdenTrabajo.OMecanicoResponsable);
                oP.agregarParametro("@id_vehiculo", NpgsqlDbType.Integer, pOrdenTrabajo.OVehiculo);
                oP.agregarParametro("@estado", NpgsqlDbType.Integer, pOrdenTrabajo.Estado);
                oP.agregarParametro("@factura_numero", NpgsqlDbType.Integer, pOrdenTrabajo.FacturaNumero);
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
        public bool borrarOrdenDeTrabajo(OrdenTrabajoE pOrdenTrabajo)
        {
            bool estado = true;
            try
            {
                string sql = "delete from OrdenDeTrabajo where id_orden_de_trabajo = @id_orden_de_trabajo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@id_orden_de_trabajo";
                parametros[0].Value = pOrdenTrabajo.IdOrdenDetrabajo;

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
        public bool modificarOrdenDeTrabajo(OrdenTrabajoE pOrdenTrabajo)
        {
            bool estado = true;

            try
            {

                string sql = "update OrdenDeTrabajo set id_orden_de_trabajo = @id_orden_de_trabajo , anio = @anio, fecha_de_ingreso_de_vehiculo = @fecha_de_ingreso_de_vehiculo," +
                     "fecha_de_salida = @fecha_de_salida, fecha_de_facturacion = @fecha_de_facturacion, costo_total = @costo_total, id_empleado = @id_empleado," +
                     "id_vehiculo = @id_vehiculo, estado = @estado, factura_numero = @factura_numero where OrdenDeTrabajo = @OrdenDeTrabajo";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_orden_de_trabajo", NpgsqlDbType.Integer, pOrdenTrabajo.IdOrdenDetrabajo);
                oP.agregarParametro("@fecha_de_ingreso_de_vehiculo", NpgsqlDbType.Integer, pOrdenTrabajo.FechaDeIngreso);
                oP.agregarParametro("@fecha_de_salida", NpgsqlDbType.Integer, pOrdenTrabajo.FechaDeSalida);
                oP.agregarParametro("@fecha_de_facturacion", NpgsqlDbType.Integer, pOrdenTrabajo.FechaDeFacturacion);
                /*oP.agregarParametro("@costo_total", NpgsqlDbType.Integer, pOrdenTrabajo.CostoTotal);*/
                oP.agregarParametro("@id_empleado", NpgsqlDbType.Integer, pOrdenTrabajo.OMecanicoResponsable);
                oP.agregarParametro("@id_vehiculo", NpgsqlDbType.Integer, pOrdenTrabajo.OVehiculo);
                oP.agregarParametro("@estado", NpgsqlDbType.Integer, pOrdenTrabajo.Estado);
                oP.agregarParametro("@factura_numero", NpgsqlDbType.Integer, pOrdenTrabajo.FacturaNumero);
                this.conexion.ejecutarSQL(sql, oP.obtenerParametros());

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