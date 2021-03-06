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
    public class OrdenRepuestoD
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

        public OrdenRepuestoD()
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
        /// Obtiene todos las OrdenRepuestoE de la bd
        /// </summary>
        /// <param name="pOrdenTrabajo">un integer llamado pOrdenTrabajo refiriendose al id</param>
        /// <returns>retorna una lista de OrdenRepuestoE</returns>
        /// 

        public List<OrdenRepuestoE> obtenerOrdenesRepuestos(int pOrdenTrabajo)
        {

            this.limpiarError();
            List<OrdenRepuestoE> ordenesRepuesto = new List<OrdenRepuestoE>();
            DataSet dsetOrdenesRepuesto;
            string sql = "select t.id_orden_de_trabajo  as idOrdenDetrabajo, " +
                          " t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida," +
                           " t.fecha_de_facturacion as fechaDeFacturacion, t.costo_total as costoTotal," +
                            "t.estado as estado, t.factura_numero as facturaNumero," +


                             "e.cedula as cedula , e.nombre as nombre, e.apellido1 as apellido1, e.apellido2 as apellido2," +
                              " e.direccion as direccion, e.telefono1 as telefono1, e.telefono2 as telefono2, e.telefono3 as telefono3," +
                               "p.id_puesto as id_puesto, p.salario as salario," +
                               "p.puesto as puesto, p.descripcion as descripcion," +


                                "v.id_vehiculo as idVehiculo, v.placa as placa, v.clase_de_vehiculo as claseVehiculo," +
                                 "v.capacidad_de_personas as capacidadPersonas, v.numero_de_motor as numeroMotor, v.numero_de_chasis as numeroChasis," +
                                "v.combustible as combustible," +

                                 "c.cedula as cedula, c.nombre as nombre," +
                                 "c.apellido1 as apellido1, c.apellido2 as apellido2," +
                                "c.direccion as direccion, c.telefono1 as telefono1, c.telefono2 as telefono2,c.telefono3 as telefono3," +
                               " mo.id_modelo as idModelo, mo.descripcion as descripcion, mo.anio as anno," +
                               " m.id_marca as idMarca, m.descripcion as descripcion," +

                                "oe.id_orden_repuesto, oe.id_orden_de_trabajo, oe.id_catalogo_de_repuestos , oe.cantidad_de_repuestos , oe.precio," +

                                "cr.id_catalogo_de_repuesto as catalogorep , cr.nombre_del_repuesto , cr.anio_al_que_pertenece ," +
                                 "cr.precio as preciorepuesto" +



                                 " from schtaller.OrdenDeTrabajo t, schtaller.empleado e, schtaller.cliente c, schtaller.modelo mo, schtaller.marca m," +
                                 "schtaller.puesto p, schtaller.vehiculo v, schtaller.ordenrepuesto oe, schtaller.catalogorepuesto cr" +


                                  " where t.id_empleado = e.cedula and t.id_vehiculo = v.id_vehiculo" +
                                  " and v.id_modelo = mo.id_modelo and m.id_marca = mo.id_marca and c.cedula = v.id_cliente and oe.id_orden_de_trabajo = t.id_orden_de_trabajo" +
                                   " and oe.id_catalogo_de_repuestos = cr.id_catalogo_de_repuesto" +

                                   " and t.id_orden_de_trabajo = " + pOrdenTrabajo;


            dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetOrdenesRepuesto.Tables[0].Rows)
            {
                PuestoE oPuesto = new PuestoE(Int32.Parse(tupla[15].ToString()), Convert.ToDouble(tupla[16].ToString())
                    , Convert.ToChar(tupla[17].ToString()), tupla[18].ToString());


                EmpleadoE oEmpleado = new EmpleadoE(Convert.ToInt32(tupla[7].ToString()), tupla[8].ToString(), tupla[9].ToString()
                    , tupla[10].ToString(), tupla[11].ToString(), oPuesto, tupla[12].ToString(), tupla[13].ToString()
                    , tupla[14].ToString());

                ClienteE oCliente = new ClienteE(Convert.ToInt32(tupla[26].ToString()), tupla[27].ToString(),
                    tupla[28].ToString(), tupla[29].ToString(), tupla[30].ToString(), tupla[31].ToString(),
                    tupla[32].ToString(), tupla[33].ToString());

                MarcaE oMarca = new MarcaE(Convert.ToInt32(tupla[37].ToString()), tupla[38].ToString());

                ModeloE oModelo = new ModeloE(Convert.ToInt32(tupla[34].ToString()), tupla[35].ToString(), oMarca, Convert.ToInt32(tupla[36].ToString()));

                VehiculoE oVehiculo = new VehiculoE(Convert.ToInt32(tupla[19].ToString()), tupla[20].ToString(), tupla[21].ToString()
                    , Convert.ToInt32(tupla[22].ToString()), oCliente, oModelo, tupla[23].ToString(), tupla[24].ToString()
                    , tupla[25].ToString());

                OrdenTrabajoE oOrdenTrabajo = new OrdenTrabajoE(Convert.ToInt32(tupla[0].ToString()), Convert.ToDateTime(tupla[1].ToString()),
                    Convert.ToDateTime(tupla[2].ToString()), Convert.ToDateTime(tupla[3].ToString()), oEmpleado, oVehiculo, Convert.ToChar(tupla[5].ToString()), Convert.ToInt32(tupla[6].ToString()));



                OrdenRepuestoE oOrdenRepuesto = new OrdenRepuestoE(Convert.ToInt32(tupla[39].ToString()), oOrdenTrabajo, Convert.ToInt32(tupla[42].ToString()),
                    Convert.ToInt32(tupla[41].ToString()), tupla[45].ToString(), Convert.ToInt32(tupla[46].ToString()), Convert.ToDouble(tupla[43].ToString()));

                ordenesRepuesto.Add(oOrdenRepuesto);

            }
            return ordenesRepuesto;
        }
        /// <summary>
        /// agrega una OrdenRepuestoE a la bd
        /// </summary>
        /// <param name="pOrdenRepuestoE">un OrdenRepuestoE llamado pOrdenRepuestoE</param>
        /// <param name="pOrdenTrabajo">un integer llamado pOrdenTrabajo refiriendose al id</param>
        /// <returns>retorna un boleano dando a conocer si se agrego la OrdenRepuestoE a la bd o no</returns>
        /// 
        public bool agregarOrdenRpuesto(OrdenRepuestoE pOrdenRepuestoE, int pOrdenTrabajo)
        {
            this.limpiarError();
            bool estado = true;
            try
            {

                string sql = " INSERT INTO schtaller.ordenrepuesto(" +
                "id_orden_de_trabajo, id_catalogo_de_repuestos," +
                "cantidad_de_repuestos, precio)" +
                "VALUES(@id_orden_de_trabajo, @id_catalogo_de_repuestos," +
                "@cantidad_de_repuestos, @precio)";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();

                oP.agregarParametro("@id_orden_de_trabajo", NpgsqlDbType.Integer, pOrdenTrabajo);
                oP.agregarParametro("@id_catalogo_de_repuestos", NpgsqlDbType.Integer, pOrdenRepuestoE.IdCatalogoRepuesto);
                oP.agregarParametro("@cantidad_de_repuestos", NpgsqlDbType.Integer, pOrdenRepuestoE.Cantidad);
                oP.agregarParametro("@precio", NpgsqlDbType.Double, pOrdenRepuestoE.Precio);
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
        /// borra una OrdenRepuestoE de la bd
        /// </summary>
        /// <param name="pOrdenTrabajo">un OrdenTrabajoE llamado pOrdenTrabajo </param>
        /// <returns>retorna un boleano dando a conocer si se borro la OrdenRepuestoE en la bd o no</returns>
        /// 
        public bool borrarOrdenDeRepuesto(OrdenTrabajoE pOrdenTrabajo)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.OrdenRepuesto where id_orden_de_trabajo = @id_orden_de_trabajo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
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
        /// <summary>
        /// modifica una OrdenRepuestoE de la bd
        /// </summary>
        /// <param name="pOrdenRepuestoE">un OrdenRepuestoE llamado pOrdenRepuestoE </param>
        /// <returns>retorna un boleano dando a conocer si se modifico la OrdenRepuestoE en la bd o no</returns>
        /// 
        public bool modificarOrdenRpuesto(OrdenRepuestoE pOrdenRepuestoE)
        {
            bool estado = true;

            try
            {

                string sql = "update schtaller.OrdenRepuesto set id_orden_repuesto = @id_orden_repuesto, id_orden_de_trabajo = @id_orden_de_trabajo, " +
                    "id_catalogo_repuesto = @id_catalogo_repuesto, cantidad_de_repuestos = @cantidad_de_repuestos, precio = @precio where schtaller.OrdenRepuesto = @OrdenRepuesto";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_orden_repuesto", NpgsqlDbType.Integer, pOrdenRepuestoE.IdOrdenRepuesto);
                oP.agregarParametro("@id_orden_de_trabajo", NpgsqlDbType.Integer, pOrdenRepuestoE.IdOrdenTrabajo);
                oP.agregarParametro("@id_catalogo_repuesto", NpgsqlDbType.Integer, pOrdenRepuestoE.IdCatalogoRepuesto);
                oP.agregarParametro("@cantidad_de_repuestos", NpgsqlDbType.Integer, pOrdenRepuestoE.Cantidad);
                oP.agregarParametro("@precio", NpgsqlDbType.Integer, pOrdenRepuestoE.Precio);
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
        /// <summary>
        /// obtiene un repuesto guardado en la bd con sus respectivos datos
        /// </summary>
        /// <param name="id">un integer llamado id refiriendose al id de los repuestos</param>
        /// <returns>retirna una tabla con el repuesto indicado </returns>
        public DataTable reporteRepuestos(int id)
        {
            DataSet dsetRepuesto;
            DataTable tabla = null;

            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@idOrdenReparacion", NpgsqlDbType.Numeric, 'N');

            string sql = "SELECT oe.id_orden_repuesto as idOrdenRepuesto, oe.id_catalogo_de_repuestos as idCatalogoRepuesto, oe.cantidad_de_repuestos as cantidadRepuestos, oe.precio as Precio,  " +

            "cr.id_catalogo_de_repuesto as catalogorep , cr.nombre_del_repuesto as NombreRepuesto, cr.anio_al_que_pertenece as anio, " +
                                 "cr.precio as preciorepuesto " +

            "from schtaller.ordenrepuesto oe, schtaller.catalogorepuesto cr " +

            "where oe.id_catalogo_de_repuestos = cr.id_catalogo_de_repuesto and cr.id_catalogo_de_repuesto = " + id;
            dsetRepuesto = this.conexion.ejecutarConsultaSQL(sql);

            if (!this.conexion.IsError)
            {
                tabla = dsetRepuesto.Tables[0].Copy();

            }

            return tabla;


        }
    }
}

