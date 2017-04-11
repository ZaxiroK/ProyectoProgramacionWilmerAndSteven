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

        public List<OrdenTrabajoE> obtenerOrdenTrabajos()
        {

            this.limpiarError();
            OrdenRepuestoD oOrdenRepuestoD = new OrdenRepuestoD();
            OrdenReparacionD oOrdenReparacionD = new OrdenReparacionD();
            List<OrdenTrabajoE> ordenesTrabajos = new List<OrdenTrabajoE>();
            
            
            DataSet dsetOrdenTrabajos;



            string sql = "select t.id_orden_de_trabajo  as idOrdenDetrabajo, " +
                           "t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida," +
                            "t.fecha_de_facturacion as fechaDeFacturacion, t.costo_total as costoTotal," +
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
                                "mo.id_modelo as idModelo, mo.descripcion as descripcion, mo.anio as anno," +
                                "m.id_marca as idMarca, m.descripcion as descripcion" +

                                " from schtaller.OrdenDeTrabajo t, schtaller.empleado e, schtaller.cliente c, schtaller.modelo mo, schtaller.marca m," +
                                 "schtaller.puesto p, schtaller.vehiculo v" +


                                 " where t.id_empleado = e.cedula and e.id_puesto = p.id_puesto and t.id_vehiculo = v.id_vehiculo" +
                                  " and v.id_modelo = mo.id_modelo and m.id_marca = mo.id_marca and c.cedula = v.id_cliente";
                                 

            dsetOrdenTrabajos = this.conexion.ejecutarConsultaSQL(sql);
            
            foreach (DataRow tupla in dsetOrdenTrabajos.Tables[0].Rows)
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

                List<OrdenRepuestoE> ordenRepuesto = oOrdenRepuestoD.obtenerOrdenesRepuestos(oOrdenTrabajo.IdOrdenDetrabajo);
                List<OrdenReparacionE> ordenReparacion = oOrdenReparacionD.obtenerOredenesReaparaciones(oOrdenTrabajo.IdOrdenDetrabajo);
                oOrdenTrabajo.OrdenReparacion = ordenReparacion;
                oOrdenTrabajo.OrdenRepuesto = ordenRepuesto;

                ordenesTrabajos.Add(oOrdenTrabajo);
            }

            return ordenesTrabajos;
        }
        public string agregarOrdenDeTrabajo(OrdenTrabajoE pOrdenTrabajo, double costo)
        {
            this.limpiarError();
            bool estado = true;
            string numero = "0";
            try
            {
                string sql = "INSERT INTO schtaller.ordendetrabajo(" +
                    "id_vehiculo, id_empleado, fecha_de_ingreso_de_vehiculo," +
            "fecha_de_salida, fecha_de_facturacion, costo_total, estado, factura_numero)"+
            "VALUES(@id_vehiculo, @id_empleado, @fecha_de_ingreso_de_vehiculo," +
                " @fecha_de_salida, @fecha_de_facturacion, @costo_total, @estado, @factura_numero) returning id_orden_de_trabajo";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();

                oP.agregarParametro("@fecha_de_ingreso_de_vehiculo", NpgsqlDbType.Timestamp, pOrdenTrabajo.FechaDeIngreso);
                oP.agregarParametro("@fecha_de_salida", NpgsqlDbType.Timestamp, pOrdenTrabajo.FechaDeSalida);
                oP.agregarParametro("@fecha_de_facturacion", NpgsqlDbType.Timestamp, pOrdenTrabajo.FechaDeFacturacion);
                oP.agregarParametro("@costo_total", NpgsqlDbType.Double, costo);
                oP.agregarParametro("@id_empleado", NpgsqlDbType.Integer, pOrdenTrabajo.OMecanicoResponsable.Cedula);
                oP.agregarParametro("@id_vehiculo", NpgsqlDbType.Integer, pOrdenTrabajo.OVehiculo.IdVehiculo);
                oP.agregarParametro("@estado", NpgsqlDbType.Varchar, pOrdenTrabajo.Estado);
                oP.agregarParametro("@factura_numero", NpgsqlDbType.Integer, pOrdenTrabajo.FacturaNumero);

                this.conexion.ejecutarSQL(sql, oP.obtenerParametros(), ref  numero);

                if (this.conexion.IsError)
                {

                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }

                return numero;

            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return numero;
        }
        public bool borrarOrdenDeTrabajo(OrdenTrabajoE pOrdenTrabajo)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.OrdenDeTrabajo where id_orden_de_trabajo = @id_orden_de_trabajo";

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

                string sql = "update schtaller.OrdenDeTrabajo set id_orden_de_trabajo = @id_orden_de_trabajo , fecha_de_ingreso_de_vehiculo = @fecha_de_ingreso_de_vehiculo," +
                     "fecha_de_salida = @fecha_de_salida, fecha_de_facturacion = @fecha_de_facturacion, costo_total = @costo_total, id_empleado = @id_empleado," +
                     "id_vehiculo = @id_vehiculo, estado = @estado, factura_numero = @factura_numero where schtaller.OrdenDeTrabajo = @OrdenDeTrabajo";
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

        public bool modificarFechaFinalizar(DateTime pFecha, int pCodigo)
        {
            bool estado = true;

            try
            {

                string sql = "update schtaller.OrdenDeTrabajo set fecha_de_salida = @fecha_de_salida where @id_orden_de_trabajo = @OrdenDeTrabajo";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@OrdenDeTrabajo", NpgsqlDbType.Integer, pCodigo);
                oP.agregarParametro("@fecha_de_salida", NpgsqlDbType.Timestamp, pFecha);

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
        public DataTable consultaOrdenDeTrabajoReporte(int pOrdenDeTraabajo)
        {
            DataSet dsetOrdenTrabajos;
            DataTable tabla = null;

            Parametro oParametro = new Parametro();
            oParametro.agregarParametro("@idOrdenDeTrabajo", NpgsqlDbType.Numeric, pOrdenDeTraabajo);

            string sql = "select t.id_orden_de_trabajo  as idOrdenDetrabajo, " +
                           "t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida," +
                            "t.fecha_de_facturacion as fechaDeFacturacion, t.costo_total as costoTotal," +
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
                                "mo.id_modelo as idModelo, mo.descripcion as descripcion, mo.anio as anno," +
                                "m.id_marca as idMarca, m.descripcion as descripcion" +

                                " from schtaller.OrdenDeTrabajo t, schtaller.empleado e, schtaller.cliente c, schtaller.modelo mo, schtaller.marca m," +
                                 "schtaller.puesto p, schtaller.vehiculo v" +


                                 " where t.id_empleado = e.cedula and e.id_puesto = p.id_puesto and t.id_vehiculo = v.id_vehiculo" +
                                  " and v.id_modelo = mo.id_modelo and m.id_marca = mo.id_marca and c.cedula = v.id_cliente";
            dsetOrdenTrabajos = this.conexion.ejecutarConsultaSQL(sql,"ordenDeTrabajo", oParametro.obtenerParametros());

            if (!this.conexion.IsError)
            {
                tabla = dsetOrdenTrabajos.Tables[0].Copy();
            }

            return tabla;
        }
    }

}
