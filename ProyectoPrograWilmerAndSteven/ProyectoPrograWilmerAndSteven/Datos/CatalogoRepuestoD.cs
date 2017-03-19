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

            string sql = "select * from CatalogoRepuesto";

            dsetCatalogoRepuestos = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetCatalogoRepuestos.Tables[0].Rows)
            {

                CatalogoRepuestoE oCatalogoRepuestos = new CatalogoRepuestoE(Convert.ToInt32(tupla[0].ToString()), tupla[1].ToString(),
                        Convert.ToInt32(tupla[2].ToString()), Convert.ToDouble(tupla[3].ToString()));
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
                string sql = "INSERT INTO catalogorepuesto("+
            "id_catalogo_de_repuesto, nombre_del_repuesto, anio_al_que_pertenece," +
            "precio)"+
            "VALUES(@id_catalogo_de_repuesto, @nombre_del_repuesto, @anio_al_que_pertenece," +
            "@precio); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_catalogo_de_repuesto", NpgsqlDbType.Integer, pCatalogoRepuesto.IdCatalogoRepuesto);
                oP.agregarParametro("@nombre_del_repuesto", NpgsqlDbType.Varchar, pCatalogoRepuesto.NombreDelRepuesto);
                oP.agregarParametro("@anio_al_que_pertenece", NpgsqlDbType.Integer, pCatalogoRepuesto.AnnoAlQuePertenece);
                oP.agregarParametro("@precio", NpgsqlDbType.Double, pCatalogoRepuesto.Precio);
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
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
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
        public bool modificarCatalogoRepuesto(CatalogoRepuestoE pCatalogoRepuesto , int codigo)
        {
            bool estado = true;

            try
            {

                string sql = "update catalogoRepuesto set id_catalogo_de_repuesto  = @id_catalogo_de_repuesto  , nombre_del_repuesto = @nombre_del_repuesto, anio_al_que_pertenece = @anio_al_que_pertenece," +
                     "precio = @Precio where id_catalogo_de_repuesto = @catalogoRepuesto";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_catalogo_de_repuesto ", NpgsqlDbType.Integer, pCatalogoRepuesto.IdCatalogoRepuesto);
                oP.agregarParametro("@nombre_del_repuesto ", NpgsqlDbType.Varchar, pCatalogoRepuesto.NombreDelRepuesto);
                oP.agregarParametro("@anio_al_que_pertenece ", NpgsqlDbType.Integer, pCatalogoRepuesto.AnnoAlQuePertenece);
                oP.agregarParametro("@precio", NpgsqlDbType.Double, pCatalogoRepuesto.Precio);
                oP.agregarParametro("@catalogoRepuesto", NpgsqlDbType.Integer, codigo
                    );
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
