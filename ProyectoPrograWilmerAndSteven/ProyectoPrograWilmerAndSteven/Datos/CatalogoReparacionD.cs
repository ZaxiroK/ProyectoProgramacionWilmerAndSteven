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
            
            string sql = "select c.id_catalogo_reparacion as id_catalogo_reparacion, c.descripcion as descripcion, " +
                        "c.horas_reparacion as horasReparacion, c.costo_reparacion as costoReparacion" +
                         "from CatalogoReparacion c";

            dsetCatalogoReparaciones = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetCatalogoReparaciones.Tables[0].Rows)
            {

            CatalogoReparacionE oCatalogoReparacion = new CatalogoReparacionE(Convert.ToInt32(tupla["id_catalogo_reparacion"].ToString()),tupla["descripcion"].ToString(),
                    Convert.ToInt32(tupla["horasReparacion"].ToString()),Convert.ToDouble(tupla["costoReparacion"].ToString()));
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
                string sql = "INSERT INTO schtaller.catalogoReparacion(" +
            "id_catalogo_reparacion,descripcion, horas_reparacion, costo_reparacion); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_catalogo_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.Id_catalogoReparacion);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Integer, pCatalogoReparacion.Descripcion);
                oP.agregarParametro("@horas_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.HorasReparacion);
                oP.agregarParametro("@costo_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.CostoReparacion);
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
                string sql = "delete from catalogoReparacion where id_catalogo_reparacion = @id_catalogo_reparacion";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
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
        public bool modificarCatalogoReparacion(CatalogoReparacionE pCatalogoReparacion)
        {
            bool estado = true;

            try
            {
                
                string sql = "update modelo set id_catalogo_reparacion = @id_catalogo_reparacion , descripcion = @descripcion, horas_reparacion = @horas_reparacion,"+
                     "costo_reparacion = @costo_reparacion where CatalogoReparacion = @CatalogoReparacion";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_catalogo_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.Id_catalogoReparacion);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Integer, pCatalogoReparacion.Descripcion);
                oP.agregarParametro("@horas_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.HorasReparacion);
                oP.agregarParametro("@costo_reparacion", NpgsqlDbType.Integer, pCatalogoReparacion.CostoReparacion);
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
