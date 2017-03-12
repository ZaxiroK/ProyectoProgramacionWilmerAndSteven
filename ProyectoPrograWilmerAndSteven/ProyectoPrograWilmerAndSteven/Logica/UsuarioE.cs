using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioE
    {
        private string login;
        private string contrasenia;
        private Boolean administrador;
        private Boolean sistema;
        private Boolean parametros;
        private Boolean administracionDeOrdenes;
        private Boolean gestionGerencial;


        public UsuarioE(string pLogin, string pContrasennia,Boolean pAdministrador, Boolean pSistema, Boolean pParametros, Boolean pAdminisitracion, Boolean pGestionGerencial)
        {
            this.login = pLogin;
            this.contrasenia = pContrasennia;
            this.administrador = pAdministrador;
            this.sistema = pSistema;
            this.parametros = pParametros;
            this.administracionDeOrdenes = pAdminisitracion;
            this.gestionGerencial = pGestionGerencial;
        }
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                contrasenia = value;
            }
        }

        public bool Sistema
        {
            get
            {
                return sistema;
            }

            set
            {
                sistema = value;
            }
        }

        public bool Parametros
        {
            get
            {
                return parametros;
            }

            set
            {
                parametros = value;
            }
        }

        public bool AdministracionDeOrdenes
        {
            get
            {
                return administracionDeOrdenes;
            }

            set
            {
                administracionDeOrdenes = value;
            }
        }

        public bool GestionGerencial
        {
            get
            {
                return gestionGerencial;
            }

            set
            {
                gestionGerencial = value;
            }
        }

        public bool Administrador
        {
            get
            {
                return administrador;
            }

            set
            {
                administrador = value;
            }
        }

        public override string ToString()
        {
            return (this.login + " " + this.contrasenia + " " + this.administrador + " " + this.sistema + " " +
                this.parametros + " " + this.administracionDeOrdenes + " " + this.gestionGerencial);
        }
    }
}
