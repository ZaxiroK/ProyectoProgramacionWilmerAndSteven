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
            
            string sql = "select * from CatalogoReparacion";

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
                string sql = "INSERT INTO catalogoreparacion("+
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
                string sql = "delete from catalogoReparacion where id_catalogo_reparacion = @id_catalogo_reparacion";

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
                
                string sql = "update catalogoReparacion set id_catalogo_reparacion = @id_catalogo_reparacion , descripcion = @descripcion, horas_reparacion = @horas_reparacion," +
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
    }
}
