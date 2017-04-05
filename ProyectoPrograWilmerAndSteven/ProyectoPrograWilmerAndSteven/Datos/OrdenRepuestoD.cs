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

        public List<OrdenRepuestoE> obtenerOrdenesRepuestos(OrdenTrabajoE pOrdenDeTrabajo, CatalogoRepuestoE pCatalogoDeRepuesto)
        {

            this.limpiarError();
            List<OrdenRepuestoE> ordenesRepuesto = new List<OrdenRepuestoE>();
            DataSet dsetOrdenesRepuesto;
            string sql = "select r.id_orden_repuesto as idOrdenRepuesto  , r.cantidad_de_repuestos as cantidad, r.precio as precio, " +


               "  t.id_orden_de_trabajo as idOrdenDetrabajo , t.id_vehiculo as oVehiculo, t.id_empleado as oMecanicoResponsable, " +
  "  t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida, t.fecha_de_facturacion as fechaDeFacturacion, t.id_empleado as deoMecanicoResponsablescripcion, " +
                             "  t.costo_total as costoTotal, t.estado as estado, t.factura_numero as facturaNumero, " +

                              "  c.id_catalogo_de_repuesto as idCatalogoRepuesto, c.nombre_del_repuesto as nombreDelRepuesto,  " +
                       "  c.anio_al_que_pertenece as annoAlQuePertenece, c.precio as precio " +
                              "  from OrdenRepuesto r, OrdenDeTrabajo t, CatalogoRepuesto c " +
                              " where r.id_orden_de_trabajo = t.id_orden_de_trabajo and r.id_catalogo_de_repuestos = c.id_catalogo_de_repuesto";


            if (pOrdenDeTrabajo != null)
            {
                sql += "and t.pIdOrdenDetrabajo = @ordenDeTrabajo";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@ordenDeTrabajo", NpgsqlDbType.Varchar, pOrdenDeTrabajo.IdOrdenDetrabajo);
                dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql, "ordenRepuesto", oParametro.obtenerParametros());
            }
            else
            {
                dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql);
            }

            if (pCatalogoDeRepuesto != null)
            {
                sql += "and r.idCatalogoRepuesto = @catalogoRepuesto";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@catalogoRepuesto", NpgsqlDbType.Varchar, pCatalogoDeRepuesto.IdCatalogoRepuesto);
                dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql, "ordenRepuesto", oParametro.obtenerParametros());
            }
            else
            {
                dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql);
            }
            foreach (DataRow tupla in dsetOrdenesRepuesto.Tables[0].Rows)
            {
                PuestoE oPuesto = new PuestoE(Int32.Parse(tupla["id_puesto"].ToString()), Convert.ToDouble(tupla["salario"].ToString())
                    , Convert.ToChar(tupla["puesto"].ToString()), tupla["descripcion"].ToString());

                EmpleadoE oMecanico = new EmpleadoE(Convert.ToInt32(tupla["cedula"].ToString()), tupla["nombre"].ToString(), tupla["apellido1"].ToString()
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
                   Convert.ToDateTime(tupla["fechaDeSalida"].ToString()), Convert.ToDateTime(tupla["fechaDeFacturacion"].ToString()), oMecanico, oVehiculo,
                    Convert.ToChar(tupla["estado"].ToString()), Convert.ToInt32(tupla["facturaNumero"].ToString()));


                CatalogoRepuestoE oCatalogRepuesto = new CatalogoRepuestoE(Convert.ToInt32(tupla["idCatalogoRepuesto"].ToString()), tupla["nombreDelRepuesto"].ToString(),
                   Convert.ToInt32(tupla["cantidad"].ToString()), Convert.ToDouble(tupla["precio"].ToString()));

                /* OrdenRepuestoE oOrdenRepuestoE = new OrdenRepuestoE(Convert.ToInt32(tupla["idOrdenRepuesto"].ToString()), oOrdenTrabajo.IdOrdenDetrabajo,
                    oCatalogRepuesto.IdCatalogoRepuesto, tupla["cantidad"].ToString(), Convert.ToDouble(tupla["precio"].ToString()));

                 ordenesRepuesto.Add(oOrdenTrabajo);*/

            }
            return ordenesRepuesto;
        }

        public bool agregarOrdenRpuesto(OrdenRepuestoE pOrdenRepuestoE)
        {
            this.limpiarError();
            bool estado = true;
            try
            {

                string sql = "INSERT INTO schtaller.OrdenRepuesto(" +
                    "@id_orden_repuesto, @id_orden_de_trabajo, @id_catalogo_repuesto, @cantidad_de_repuestos, @precio; ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_orden_repuesto", NpgsqlDbType.Integer, pOrdenRepuestoE.IdOrdenRepuesto);
                oP.agregarParametro("@id_orden_de_trabajo", NpgsqlDbType.Integer, pOrdenRepuestoE.IdOrdenTrabajo);
                oP.agregarParametro("@id_catalogo_repuesto", NpgsqlDbType.Integer, pOrdenRepuestoE.IdCatalogoRepuesto);
                oP.agregarParametro("@cantidad_de_repuestos", NpgsqlDbType.Integer, pOrdenRepuestoE.Cantidad);
                oP.agregarParametro("@precio", NpgsqlDbType.Integer, pOrdenRepuestoE.Precio);
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
                string sql = "delete from schtaller.OrdenRepuesto where id_orden_repuesto = @id_orden_repuesto";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@id_orden_repuesto";
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
    }
}

