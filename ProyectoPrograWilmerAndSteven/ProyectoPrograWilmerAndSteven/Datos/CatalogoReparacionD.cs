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
    public class CatalogoReparacionD { 
    
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

        public CatalogoReparacionD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<CatalogoReparacionE> obtenerCatalogoReaparaciones()
        {

            this.limpiarError();
            List<CatalogoReparacionE> catalogoReparaciones = new List<CatalogoReparacionE>();
            DataSet dsetCatalogoReparaciones;
            
            string sql = "select * from schtaller.CatalogoReparacion";

            dsetCatalogoReparaciones = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetCatalogoReparaciones.Tables[0].Rows)
            {

            CatalogoReparacionE oCatalogoReparacion = new CatalogoReparacionE(Convert.ToInt32(tupla[0].ToString()),tupla[1].ToString(),
                    Convert.ToInt32(tupla[2].ToString()),Convert.ToDouble(tupla[3].ToString()));
                catalogoReparaciones.Add(oCatalogoReparacion);
            }

            return catalogoReparaciones;
        }
        public bool agregarCatalogoReparacion(CatalogoReparacionE pCatalogoReparacion)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.catalogoreparacion(" +
            "id_catalogo_reparacion, descripcion, horas_reparacion, costo_reparacion)"+
            "VALUES(@id_catalogo_reparacion, @descripcion, @horas_reparacion, @costo_reparacion);";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_catalogo_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.Id_catalogoReparacion);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Varchar, pCatalogoReparacion.Descripcion);
                oP.agregarParametro("@horas_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.HorasReparacion);
                oP.agregarParametro("@costo_reparacion", NpgsqlDbType.Double, pCatalogoReparacion.CostoReparacion);
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
        public bool borrarCatalogoReparacion(CatalogoReparacionE pCatalogoReparacion)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.catalogoReparacion where id_catalogo_reparacion = @id_catalogo_reparacion";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_catalogo_reparacion";
                parametros[0].Value = pCatalogoReparacion.Id_catalogoReparacion;

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
        public bool modificarCatalogoReparacion(CatalogoReparacionE pCatalogoReparacion, int codigo)
        {
            bool estado = true;

            try
            {
                
                string sql = "update schtaller.catalogoReparacion set id_catalogo_reparacion = @id_catalogo_reparacion , descripcion = @descripcion, horas_reparacion = @horas_reparacion," +
                     "costo_reparacion = @costo_reparacion where id_catalogo_reparacion = @CatalogoReparacion";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_catalogo_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.Id_catalogoReparacion);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Varchar, pCatalogoReparacion.Descripcion);
                oP.agregarParametro("@horas_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.HorasReparacion);
                oP.agregarParametro("@costo_reparacion", NpgsqlDbType.Double, pCatalogoReparacion.CostoReparacion);
                oP.agregarParametro("@CatalogoReparacion", NpgsqlDbType.Integer, codigo);

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
                                 "cr.id_empleado, cr.horas, cr.costo,  "+


        "oe.id_catalogo_reparacion as rep , oe.descripcion, oe.horas_reparacion, oe.costo_reparacion, " +


            "t.id_orden_de_trabajo as idOrdenDetrabajo, " +
                           "t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida, " +


            "e.cedula as cedula , e.nombre as nombre, e.apellido1 as apellido1, e.apellido2 as apellido2 " +


            "from schtaller.catalogoreparacion oe, schtaller.ordenreparacion cr, schtaller.OrdenDeTrabajo t, schtaller.empleado e " +



            "where cr.id_catalogo_reparacion = oe.id_catalogo_reparacion and cr.id_orden_de_trabajo = t.id_orden_de_trabajo and cr.id_empleado = "+ empleadoCed +


            "and cast(fecha_de_ingreso_de_vehiculo as date) between '" + fecha1 + "' and '"+ fecha2 + "'"; 
            dsetInformeOrdenesPendientes = this.conexion.ejecutarConsultaSQL(sql);

            if (!this.conexion.IsError)
            {
                tabla = dsetInformeOrdenesPendientes.Tables[0].Copy();

            }

            return tabla;


        }

    }
}
