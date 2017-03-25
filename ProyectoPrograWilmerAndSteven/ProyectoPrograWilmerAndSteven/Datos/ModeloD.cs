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
    public class ModeloD
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

        public ModeloD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ModeloE> obtenerModelos()
        {

            this.limpiarError();
            List<ModeloE> modelos = new List<ModeloE>();
            DataSet dsetMarcas;
            string sql = "select mo.id_modelo  as idModelo, mo.descripcion  as descripcion, mo.anio as anno," +
                            "m.id_marca as idMarca, m.descripcion as descripcion" +
                               " from schtaller.modelo mo, schtaller.marca m " +
                               "where  m.id_marca = mo.id_marca";

            dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
            {
                MarcaE oMarca = new MarcaE(Convert.ToInt32(tupla[3].ToString()), tupla[4].ToString());
                ModeloE oModelo = new ModeloE(Convert.ToInt32(tupla[0].ToString()), tupla[1].ToString(), oMarca, Convert.ToInt32(tupla[2].ToString()));
                modelos.Add(oModelo);
            }
            return modelos;
        }
        public bool agregarModelo(ModeloE pModelo)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.modelo(" +
            "id_modelo, id_marca, descripcion, anio)" +
               "VALUES(@id_modelo, @id_marca, @descripcion, @anio)";


                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_modelo", NpgsqlDbType.Integer, pModelo.IdModelo);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Varchar, pModelo.Descripcion);
                oP.agregarParametro("@anio", NpgsqlDbType.Integer, pModelo.Anno);
                oP.agregarParametro("@id_marca", NpgsqlDbType.Integer, pModelo.OMarca.IdMarca);
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
        public bool borrarModelo(ModeloE pModelo)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.modelo where id_modelo = @id_modelo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_modelo";
                parametros[0].Value = pModelo.IdModelo;

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
        public bool modificarModelo(ModeloE pModelo, int codigo)
        {
            bool estado = true;

            try
            {
                string sql = "update schtaller.modelo set id_modelo = @id_modelo , descripcion = @descripcion," +
                    "id_marca = @id_marca, anio = @anio where id_modelo = @idViejo";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_modelo", NpgsqlDbType.Integer, pModelo.IdModelo);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Varchar, pModelo.Descripcion);
                oP.agregarParametro("@anio", NpgsqlDbType.Integer, pModelo.Anno);
                oP.agregarParametro("@id_marca", NpgsqlDbType.Integer, pModelo.OMarca.IdMarca);
                oP.agregarParametro("@idViejo", NpgsqlDbType.Integer, codigo);
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

