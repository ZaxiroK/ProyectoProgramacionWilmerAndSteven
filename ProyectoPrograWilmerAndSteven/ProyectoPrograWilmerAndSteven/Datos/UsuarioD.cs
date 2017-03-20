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
        public bool agregarUsuario(UsuarioE pUsuario)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.usuario(" +
            "login, contrasenia, administrador, sistema, parametros, administracionOrdenes, gestionGerencial ); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@login", NpgsqlDbType.Integer, pUsuario.Login);
                oP.agregarParametro("@contrasenia", NpgsqlDbType.Integer, pUsuario.Contrasenia);
                oP.agregarParametro("@administrador", NpgsqlDbType.Integer, pUsuario.Administrador);
                oP.agregarParametro("@sistema", NpgsqlDbType.Integer, pUsuario.Sistema);
                oP.agregarParametro("@parametros", NpgsqlDbType.Integer, pUsuario.Parametros);
                oP.agregarParametro("@administracionOrdenes", NpgsqlDbType.Integer, pUsuario.AdministracionDeOrdenes);
                oP.agregarParametro("@gestionGerencial", NpgsqlDbType.Integer, pUsuario.GestionGerencial);
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
        public bool borrarUsuario(UsuarioE pUsuario)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.usuario where login = @login";

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
        public bool modificarUsuario(UsuarioE pUsuario, string login)
        {
            bool estado = true;

            try
            {
                
                string sql = "update schtaller.usuario set login = @login, contrasenia = @contrasenia, administrador = @administrador, sistema = @sistema, parametros =<@parametros," +
                    "administracionOrdenes = @administracionOrdenes,gestionGerencial = @gestionGerencial where usuario = @usuario";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@login", NpgsqlDbType.Integer, pUsuario.Login);
                oP.agregarParametro("@contrasenia", NpgsqlDbType.Integer, pUsuario.Contrasenia);
                oP.agregarParametro("@administrador", NpgsqlDbType.Integer, pUsuario.Administrador);
                oP.agregarParametro("@sistema", NpgsqlDbType.Integer, pUsuario.Sistema);
                oP.agregarParametro("@parametros", NpgsqlDbType.Integer, pUsuario.Parametros);
                oP.agregarParametro("@administracionOrdenes", NpgsqlDbType.Integer, pUsuario.AdministracionDeOrdenes);
                oP.agregarParametro("@gestionGerencial", NpgsqlDbType.Integer, pUsuario.GestionGerencial);
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
