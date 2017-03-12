using Datos;
using Logica;
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
                        "u.gestion_gerencial as gestionGerencial"+
                         "from Usuario u";

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
    }
}
