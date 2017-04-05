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

        public List<OrdenReparacionE> obtenerOredenesReaparaciones(OrdenTrabajoE pOrdenTrabajoE, CatalogoReparacionE pCatalogoReparacionE, EmpleadoE pEmpleadoE)
        {

            this.limpiarError();
            List<OrdenReparacionE> ordenesReparaciones = new List<OrdenReparacionE>();
            DataSet dsetOredenesReparaciones;


            string sql = "select o.id_orden_reparacion as idOrdenReparacion, o.id_orden_de_trabajo as idOrdenReparacion, o.id_empleado as cedulaEmpleado, o.horas as horasTotalReparacion, " +

                           "cr.id_catalogo_reparacion as id_catalogo_reparacion, cr.descripcion as descripcion, " +
                           "cr.horas_reparacion as horasReparacion, cr.costo_reparacion as costoReparacion, " +
                            "t.id_orden_de_trabajo as idOrdenDetrabajo, " +
                                "t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida, " +
                               "t.fecha_de_facturacion as fechaDeFacturacion,t.costo_total as costoTotal, " +
                              "t.estado as estado, t.factura_numero as facturaNumero, " +

                              
                                 "e.cedula as cedula , e.nombre as nombre, e.apellido1 as apellido1, e.apellido2 as apellido2, " +
                                  "e.direccion as direccion, e.telefono1 as telefono1, e.telefono2 as telefono2, e.telefono3 as telefono3, " +
                                  "p.id_puesto as id_puesto, p.salario as salario, " +
                                  "p.puesto as puesto, p.descripcion as descripcion, " +



                                   "v.id_vehiculo as idVehiculo, v.placa as placa, v.clase_de_vehiculo as claseVehiculo, " +
                                     "v.capacidad_de_personas as capacidadPersonas, v.numero_de_motor as numeroMotor, v.numero_de_chasis as numeroChasis, " +
                                     "c.cedula as cedula, c.nombre as nombre, " +
                                    "c.apellido1 as apellido1, c.apellido2 as apellido2, " +
                                    "c.direccion as direccion, c.telefono1 as telefono1, c.telefono2 as telefono2,c.telefono3 as telefono3, " +
                                   "mo.id_modelo as idModelo, mo.descripcion as descripcion, mo.anio as anno, " +
                                   "m.id_marca as idMarca, m.descripcion as descripcion " +

    

                               " from OrdenReparacion o, CatalogoReparacion cr, OrdenDeTrabajo t, empleado e, cliente c, modelo mo, marca m, puesto p, vehiculo v " +
                                 "where o.id_catalogo_reparacion = cr.id_catalogo_reparacion and o.id_empleado = e.cedula and o.id_orden_de_trabajo = id_orden_reparacion ";

            dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql);
            if (pCatalogoReparacionE != null)
           {
                sql += "and cr.id_catalogo_reparacion = @CatalogoReparacion";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@CatalogoReparacion", NpgsqlDbType.Varchar, pCatalogoReparacionE.Id_catalogoReparacion);
                dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql, "OrdenReparacion ", oParametro.obtenerParametros());
           }
            else
            {
                dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql);
            }
            if (pOrdenTrabajoE != null)
            {
                sql += "and t.id_orden_de_trabajo = @OrdenDeTrabajo";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@OrdenDeTrabajo", NpgsqlDbType.Varchar, pOrdenTrabajoE.IdOrdenDetrabajo);
                dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql, "OrdenReparacion ", oParametro.obtenerParametros());
            }
            else
            {
                dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql);
            }

            if (pEmpleadoE != null)
            {
                sql += "and e.cedula = @empleado";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@empleado", NpgsqlDbType.Varchar, pEmpleadoE.Cedula);
                dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql, "OrdenReparacion ", oParametro.obtenerParametros());
            }
            else
          {
                dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql);
            }
            foreach (DataRow tupla in dsetOredenesReparaciones.Tables[0].Rows)
            {
                CatalogoReparacionE oCatalogoReparacion = new CatalogoReparacionE(Convert.ToInt32(tupla["id_catalogo_reparacion"].ToString()), tupla["descripcion"].ToString(),
                    Convert.ToInt32(tupla["horasReparacion"].ToString()), Convert.ToDouble(tupla["costoReparacion"].ToString()));

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

               OrdenTrabajoE oOrdenTrabajo = new OrdenTrabajoE(Convert.ToInt32(tupla["idOrdenDetrabajo"].ToString()), Convert.ToDateTime(tupla["fechaDeIngreso"].ToString()),
                   Convert.ToDateTime(tupla["fechaDeSalida"].ToString()), Convert.ToDateTime(tupla["fechaDeFacturacion"].ToString()), oEmpleado, oVehiculo, Convert.ToChar(tupla["estado"].ToString()), Convert.ToInt32(tupla["facturaNumero"].ToString()));



                OrdenReparacionE oOrdenReparacion = new OrdenReparacionE(Convert.ToInt32(tupla["idOrdenReparacion"].ToString()), Convert.ToInt32(tupla["cedulaEmpleado"].ToString()), Convert.ToInt32(tupla["horas"].ToString()), oOrdenTrabajo
                     , Convert.ToInt32(tupla["pIdCatalogoReparacion"].ToString()), tupla["pDescripcion"].ToString(), Convert.ToInt32(tupla["pHorasReparacion"].ToString()), Convert.ToDouble(tupla["pCostoReparacion"].ToString()));
                  
                
               ordenesReparaciones.Add(oOrdenReparacion);
     
            }
            return ordenesReparaciones;
        }
        public bool agregarOrdenReparacion(OrdenReparacionE pOrdenReparacionE)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.OrdenrReparacion(" +
            "@id_orden_reparacion, @id_catalogo_reparacion, @id_orden_de_trabajo, @id_empleado, @horas, @costo ); ";

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
        public bool borrarOrdenReparacion(OrdenReparacionE pOrdenReparacionE)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.OrdenReparacion where id_orden_reparacion = @id_orden_reparacion";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@id_orden_reparacion";
                parametros[0].Value = pOrdenReparacionE.Id_catalogoReparacion;

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

    }
}
