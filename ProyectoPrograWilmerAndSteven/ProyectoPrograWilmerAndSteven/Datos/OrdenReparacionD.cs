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
   public class OrdenReparacionD
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

        public OrdenReparacionD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<OrdenReparacionE> obtenerOredenesReaparaciones(int pOrdenTrabajo)
        {

            this.limpiarError();
            List<OrdenReparacionE> ordenesReparaciones = new List<OrdenReparacionE>();
            DataSet dsetOredenesReparaciones;


            string sql = "select t.id_orden_de_trabajo  as idOrdenDetrabajo,"+ 
                           "t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida,"+
                            "t.fecha_de_facturacion as fechaDeFacturacion, t.costo_total as costoTotal,"+
                            "t.estado as estado, t.factura_numero as facturaNumero,"+


                             "e.cedula as cedula , e.nombre as nombre, e.apellido1 as apellido1, e.apellido2 as apellido2,"+
                               "e.direccion as direccion, e.telefono1 as telefono1, e.telefono2 as telefono2, e.telefono3 as telefono3,"+
                               "p.id_puesto as id_puesto, p.salario as salario,"+
                               "p.puesto as puesto, p.descripcion as descripcion,"+


                                "v.id_vehiculo as idVehiculo, v.placa as placa, v.clase_de_vehiculo as claseVehiculo,"+
                                 "v.capacidad_de_personas as capacidadPersonas, v.numero_de_motor as numeroMotor, v.numero_de_chasis as numeroChasis,"+
                                "v.combustible as combustible,"+

                                 "c.cedula as cedula, c.nombre as nombre,"+
                                 "c.apellido1 as apellido1, c.apellido2 as apellido2,"+
                                "c.direccion as direccion, c.telefono1 as telefono1, c.telefono2 as telefono2,c.telefono3 as telefono3,"+
                                "mo.id_modelo as idModelo, mo.descripcion as descripcion, mo.anio as anno,"+
                                "m.id_marca as idMarca, m.descripcion as descripcion,"+

                                "cr.id_orden_reparacion  , cr.id_catalogo_reparacion , cr.id_orden_de_trabajo,"+
                                 "cr.id_empleado, cr.horas, cr.costo,"+

                                 "oe.id_catalogo_reparacion as rep , oe.descripcion, oe.horas_reparacion, oe.costo_reparacion"+


                                 " from schtaller.OrdenDeTrabajo t, schtaller.empleado e, schtaller.cliente c, schtaller.modelo mo, schtaller.marca m,"+
                                 "schtaller.puesto p, schtaller.vehiculo v, schtaller.catalogoreparacion oe, schtaller.ordenreparacion cr"+


                                  " where t.id_empleado = e.cedula and t.id_vehiculo = v.id_vehiculo"+
                                   " and v.id_modelo = mo.id_modelo and m.id_marca = mo.id_marca and c.cedula = v.id_cliente and "+
                                   "t.id_orden_de_trabajo = cr.id_orden_de_trabajo and cr.id_catalogo_reparacion = oe.id_catalogo_reparacion"+



                                  " and t.id_orden_de_trabajo = " + pOrdenTrabajo;


             dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetOredenesReparaciones.Tables[0].Rows)
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

                OrdenReparacionE oOrdenReparacion = new OrdenReparacionE(Convert.ToInt32(tupla[39].ToString()), Convert.ToInt32(tupla[42].ToString()), Convert.ToInt32(tupla[43].ToString()), oOrdenTrabajo
                     , Convert.ToInt32(tupla[40].ToString()), tupla[46].ToString(), Convert.ToInt32(tupla[43].ToString()), Convert.ToDouble(tupla[44].ToString()));
                  
                
               ordenesReparaciones.Add(oOrdenReparacion);
     
            }
            return ordenesReparaciones;
        }
        public bool agregarOrdenReparacion(OrdenReparacionE pOrdenReparacionE, int pOrdenReparacion)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.ordenreparacion(" +
            "id_catalogo_reparacion, id_orden_de_trabajo," +
            "id_empleado, horas, costo)"+
            " VALUES(@id_catalogo_reparacion, @id_orden_de_trabajo," +
            " @id_empleado, @horas, @costo); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                
                oP.agregarParametro("@id_catalogo_reparacion", NpgsqlDbType.Integer, pOrdenReparacionE.Id_catalogoReparacion);
                oP.agregarParametro("@id_orden_de_trabajo", NpgsqlDbType.Integer, pOrdenReparacion);
                oP.agregarParametro("@id_empleado", NpgsqlDbType.Integer, pOrdenReparacionE.CedulaEmpleado);
                oP.agregarParametro("@horas", NpgsqlDbType.Integer, pOrdenReparacionE.HorasTotalReparacion);
                oP.agregarParametro("@costo", NpgsqlDbType.Double, pOrdenReparacionE.CostoReparacion);
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
        public bool borrarOrdenReparacion(OrdenTrabajoE pOrdenTrabajoE)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.OrdenReparacion where id_orden_de_trabajo = @id_orden_de_trabajo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_orden_de_trabajo";
                parametros[0].Value = pOrdenTrabajoE.IdOrdenDetrabajo;

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
        public bool modificarOrdenReparacion(OrdenReparacionE pOrdenReparacionE)
        {
            bool estado = true;

            try
            {

               // "@id_orden_reparacion, @id_catalogo_reparacion, @id_orden_de_trabajo, @id_empleado, @horas, @costo ); ";
                string sql = "update schtaller.OrdenReparacion set id_orden_reparacion = @id_orden_reparacion , id_catalogo_reparacion = @id_catalogo_reparacion, " +
                     "id_empleado = @id_empleado, horas = @horas, costo = @costo where schtaller.OrdenReparacion = @OrdenReparacion";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_orden_reparacion", NpgsqlDbType.Integer, pOrdenReparacionE.IdOrdenReparacion);
                oP.agregarParametro("@id_catalogo_reparacion", NpgsqlDbType.Integer, pOrdenReparacionE.Id_catalogoReparacion);
                oP.agregarParametro("@id_orden_de_trabajo", NpgsqlDbType.Integer, pOrdenReparacionE.OOrdenTrabajo);
                oP.agregarParametro("@id_empleado", NpgsqlDbType.Integer, pOrdenReparacionE.CedulaEmpleado);
                oP.agregarParametro("@horas", NpgsqlDbType.Integer, pOrdenReparacionE.HorasReparacion);
                oP.agregarParametro("@costo", NpgsqlDbType.Double, pOrdenReparacionE.HorasTotalReparacion);
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

        public DataTable reporteReparacionesEmpleado(DateTime fecha1, DateTime fecha2, int empleadoCed)
        {
            DataSet dsetInformeOrdenesPendientes;
            DataTable tabla = null;

            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@idOrdenDeTrabajo", NpgsqlDbType.Numeric, 'N');

            string sql = "select  cr.id_orden_reparacion  , cr.id_catalogo_reparacion , cr.id_orden_de_trabajo, " +
                                 "cr.id_empleado, cr.horas, cr.costo,  " +


        "oe.id_catalogo_reparacion as rep , oe.descripcion, oe.horas_reparacion, oe.costo_reparacion, " +


            "t.id_orden_de_trabajo as idOrdenDetrabajo, " +
                           "t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida, " +


            "e.cedula as cedula , e.nombre as nombre, e.apellido1 as apellido1, e.apellido2 as apellido2 " +


            "from schtaller.catalogoreparacion oe, schtaller.ordenreparacion cr, schtaller.OrdenDeTrabajo t, schtaller.empleado e " +



            "where cr.id_catalogo_reparacion = oe.id_catalogo_reparacion and cr.id_orden_de_trabajo = t.id_orden_de_trabajo and cr.id_empleado = " + empleadoCed +


            "and cast(fecha_de_ingreso_de_vehiculo as date) between '" + fecha1 + "' and '" + fecha2 + "'";
            dsetInformeOrdenesPendientes = this.conexion.ejecutarConsultaSQL(sql);

            if (!this.conexion.IsError)
            {
                tabla = dsetInformeOrdenesPendientes.Tables[0].Copy();

            }

            return tabla;


        }

    }
}
