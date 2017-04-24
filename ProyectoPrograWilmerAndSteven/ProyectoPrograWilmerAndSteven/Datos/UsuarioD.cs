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
    public class UsuarioD
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

        public UsuarioD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }
        /// <summary>
        /// obtiene todos los UsuarioE de la bd
        /// </summary>
        /// <returns>una lista de UsuarioE</returns>
        public List<UsuarioE> obtenerUsuarios()
        {

            this.limpiarError();
            List<UsuarioE> usuarios = new List<UsuarioE>();
            DataSet dsetUsuarios;
            string sql = "select u.id_login as login, u.contrasenia as contrasenia, " +
                        " u.administrador as administrador, u.sistema as sistema," +
                        "u.parametros as parametros, u.administracion_de_ordenes as administracionOrdenes," +
                        "u.gestion_gerencial as gestionGerencial "+
                         "from schtaller.usuario u";

            dsetUsuarios = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetUsuarios.Tables[0].Rows)
            {
                UsuarioE oUsuario = new UsuarioE(tupla["login"].ToString(),tupla["contrasenia"].ToString(),Convert.ToBoolean(tupla["administrador"].ToString()),
                    Convert.ToBoolean(tupla["sistema"].ToString()),Convert.ToBoolean(tupla["parametros"].ToString()),Convert.ToBoolean(tupla["administracionOrdenes"].ToString()),
                    Convert.ToBoolean(tupla["gestionGerencial"].ToString()));
                usuarios.Add(oUsuario);
            }
            return usuarios;
        }
        /// <summary>
        /// comprueba los permisos del UsuarioE en el sistema
        /// </summary>
        /// <param name="login">un string llamado login</param>
        /// <param name="password">un string llamado password</param>
        /// <returns>los permisos del UsuarioE</returns>
        public UsuarioE comprobarUsuario(string login, string password)
        {

            this.limpiarError();
            UsuarioE usuario = null;
            DataSet dsetUsuarios;
            string sql = "select u.id_login as login, u.contrasenia as contrasenia, " +
                        " u.administrador as administrador, u.sistema as sistema," +
                        "u.parametros as parametros, u.administracion_de_ordenes as administracionOrdenes," +
                        "u.gestion_gerencial as gestionGerencial " +
                         "from schtaller.usuario u " +
                         "where id_login = " + "'"+ login + "' and contrasenia = " +"'"+ password +"'"  ;

            dsetUsuarios = this.conexion.ejecutarConsultaSQL(sql);

            if (!this.conexion.IsError)
            {
                if (dsetUsuarios.Tables[0].Rows.Count > 0)
                {
                    usuario = new UsuarioE(dsetUsuarios.Tables[0].Rows[0]["login"].ToString(), dsetUsuarios.Tables[0].Rows[0]["contrasenia"].ToString(), Convert.ToBoolean(dsetUsuarios.Tables[0].Rows[0]["administrador"].ToString()),
                    Convert.ToBoolean(dsetUsuarios.Tables[0].Rows[0]["sistema"].ToString()), Convert.ToBoolean(dsetUsuarios.Tables[0].Rows[0]["parametros"].ToString()), Convert.ToBoolean(dsetUsuarios.Tables[0].Rows[0]["administracionOrdenes"].ToString()),
                    Convert.ToBoolean(dsetUsuarios.Tables[0].Rows[0]["gestionGerencial"].ToString()));
                }
            }
            
            return usuario;
        }
        /// <summary>
        /// agrega un UsuarioE a la bd
        /// </summary>
        /// <param name="pUsuario">us UsuarioE llamado pUsuario</param>
        /// <returns>retorna un boleano dando a conocer si se agrego el UsuarioE a la bd o no</returns>
        public bool agregarUsuario(UsuarioE pUsuario)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.usuario(" +
            "id_login , contrasenia, administrador, sistema, parametros, administracion_de_ordenes , gestion_gerencial)" +
            "VALUES(@login, @contrasenia, @administrador,@sistema, @parametros, @administracionOrdenes," +
            "@gestionGerencial);";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@login", NpgsqlDbType.Varchar, pUsuario.Login);
                oP.agregarParametro("@contrasenia", NpgsqlDbType.Integer, pUsuario.Contrasenia);
                oP.agregarParametro("@administrador", NpgsqlDbType.Boolean, pUsuario.Administrador);
                oP.agregarParametro("@sistema", NpgsqlDbType.Boolean, pUsuario.Sistema);
                oP.agregarParametro("@parametros", NpgsqlDbType.Boolean, pUsuario.Parametros);
                oP.agregarParametro("@administracionOrdenes", NpgsqlDbType.Boolean, pUsuario.AdministracionDeOrdenes);
                oP.agregarParametro("@gestionGerencial", NpgsqlDbType.Boolean, pUsuario.GestionGerencial);
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
        /// <summary>
        /// borra un UsuarioE de la bd
        /// </summary>
        /// <param name="pUsuario">un UsuarioE llamado pUsuario</param>
        /// <returns>retorna un boleano dando a conocer si se borro el UsuarioE a la bd o no</returns>
        public bool borrarUsuario(UsuarioE pUsuario)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.usuario where id_login = @login";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@login";
                parametros[0].Value = pUsuario.Login;

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
        /// <summary>
        /// modifica un UsuarioE de la bd
        /// </summary>
        /// <param name="pUsuario">un UsuarioE llamado pUsuario</param>
        /// <param name="login">un string llamado login</param>
        /// <returns>retorna un boleano dando a conocer si se modifico el UsuarioE a la bd o no</returns>
        public bool modificarUsuario(UsuarioE pUsuario, string login)
        {
            bool estado = true;

            try
            {
                


                string sql = "update schtaller.usuario set id_login = @login, contrasenia = @contrasenia, administrador = @administrador, sistema = @sistema, parametros = @parametros," +
                    "administracion_de_ordenes = @administracionOrdenes,gestion_gerencial = @gestionGerencial where id_login = @login";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@login", NpgsqlDbType.Varchar, pUsuario.Login);
                oP.agregarParametro("@contrasenia", NpgsqlDbType.Integer, pUsuario.Contrasenia);
                oP.agregarParametro("@administrador", NpgsqlDbType.Boolean, pUsuario.Administrador);
                oP.agregarParametro("@sistema", NpgsqlDbType.Boolean, pUsuario.Sistema);
                oP.agregarParametro("@parametros", NpgsqlDbType.Boolean, pUsuario.Parametros);
                oP.agregarParametro("@administracionOrdenes", NpgsqlDbType.Boolean, pUsuario.AdministracionDeOrdenes);
                oP.agregarParametro("@gestionGerencial", NpgsqlDbType.Boolean, pUsuario.GestionGerencial);
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
