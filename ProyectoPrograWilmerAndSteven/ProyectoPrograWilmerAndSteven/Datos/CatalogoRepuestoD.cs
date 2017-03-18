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
    public class CatalogoRepuestoD
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

        public CatalogoRepuestoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<CatalogoRepuestoE> obtenerCatalogoRepuestos()
        {

            this.limpiarError();
            List<CatalogoRepuestoE> catalogoRepuestos = new List<CatalogoRepuestoE>();
            DataSet dsetCatalogoRepuestos;

            string sql = "select cro.id_catalogo_de_repuesto  as idCatalogoRepuesto, cro.nombre_del_repuesto  as nombreDelRepuesto, " +
                            "cro.anio_al_que_pertenece  as annoAlQuePertenece, cro.precio as precio" +
                             "from CatalogoRepuesto cro";

            dsetCatalogoRepuestos = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetCatalogoRepuestos.Tables[0].Rows)
            {

                CatalogoRepuestoE oCatalogoRepuestos = new CatalogoRepuestoE(Convert.ToInt32(tupla["id_catalogo_de_repuesto"].ToString()), tupla["nombreDelRepuesto"].ToString(),
                        Convert.ToInt32(tupla["annoAlQuePertenece"].ToString()), Convert.ToDouble(tupla["precio"].ToString()));
                catalogoRepuestos.Add(oCatalogoRepuestos);
            }
            return catalogoRepuestos;
        }
        public bool agregarCatalogoRepuesto(CatalogoRepuestoE pCatalogoRepuesto)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.catalogoRepuesto(" +
            "id_catalogo_reparacion,nombreDelRepuesto, annoAlQuePertenece, precio); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_catalogo_de_repuesto ", NpgsqlDbType.Integer, pCatalogoRepuesto.IdCatalogoRepuesto);
                oP.agregarParametro("@nombre_del_repuesto ", NpgsqlDbType.Integer, pCatalogoRepuesto.NombreDelRepuesto);
                oP.agregarParametro("@anio_al_que_pertenece ", NpgsqlDbType.Integer, pCatalogoRepuesto.AnnoAlQuePertenece);
                oP.agregarParametro("@precio", NpgsqlDbType.Integer, pCatalogoRepuesto.Precio);
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
        public bool borrarCatalogoRepuesto(CatalogoRepuestoE pCatalogoRepuesto)
        {
            bool estado = true;
            try
            {
                string sql = "delete from catalogoRepuesto where id_catalogo_de_repuesto  = @id_catalogo_de_repuesto ";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@id_catalogo_de_repuesto ";
                parametros[0].Value = pCatalogoRepuesto.IdCatalogoRepuesto;

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
        public bool modificarCatalogoRepuesto(CatalogoRepuestoE pCatalogoRepuesto)
        {
            bool estado = true;

            try
            {

                string sql = "update catalogoRepuesto set IdCatalogoRepuesto  = @id_catalogo_de_repuesto  , NombreDelRepuesto = @nombre_del_repuesto, AnnoAlQuePertenece = @anio_al_que_pertenece," +
                     "Precio = @Precio where catalogoRepuesto = @catalogoRepuesto";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_catalogo_de_repuesto ", NpgsqlDbType.Integer, pCatalogoRepuesto.IdCatalogoRepuesto);
                oP.agregarParametro("@nombre_del_repuesto ", NpgsqlDbType.Integer, pCatalogoRepuesto.NombreDelRepuesto);
                oP.agregarParametro("@anio_al_que_pertenece ", NpgsqlDbType.Integer, pCatalogoRepuesto.AnnoAlQuePertenece);
                oP.agregarParametro("@precio", NpgsqlDbType.Integer, pCatalogoRepuesto.Precio);
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
