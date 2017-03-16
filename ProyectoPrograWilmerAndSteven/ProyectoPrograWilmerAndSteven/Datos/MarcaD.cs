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
    public class MarcaD
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

        public MarcaD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<MarcaE> obtenerMarcas()
        {

            this.limpiarError();
            List<MarcaE> marcas = new List<MarcaE>();
            DataSet dsetMarcas;
            string sql = "select m.id_marca  as idMarca, m.descripcion  as descripcion" +
                         "from marca m";

            dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
            {
                MarcaE oMarca = new MarcaE(Convert.ToInt32(tupla["idMarca"].ToString()),tupla["descripcion"].ToString());
                marcas.Add(oMarca);
            }
            return marcas;
        }
        public bool agregarMarca(MarcaE pMarca)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.marca(" +
            "id_marca, id_cliente, descripcion); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_marca", NpgsqlDbType.Integer, pMarca.IdMarca);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Integer, pMarca.Descripcion);
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
        public bool borrarMarca(MarcaE pMarca)
        {
            bool estado = true;
            try
            {
                string sql = "delete from marca where id_marca = @id_marca";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@id_marca";
                parametros[0].Value = pMarca.IdMarca;

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
        public bool modificarMarca(MarcaE pMarca)
        {
            bool estado = true;

            try
            {
                string sql = "update marca set id_marca = @id_marca , descripcion = @descripcion where marca = @marca";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_marca", NpgsqlDbType.Integer, pMarca.IdMarca);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Integer, pMarca.Descripcion);
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
