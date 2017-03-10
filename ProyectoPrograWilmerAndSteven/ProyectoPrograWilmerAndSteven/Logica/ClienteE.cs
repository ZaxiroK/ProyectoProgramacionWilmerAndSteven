using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClienteE
    {
        private string cedula;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string telefono1;
        private string telefono2;
        private string telefono3;
        public ClienteE(string pCedula, string pNombre, string pApellido1, string pApellido2,
            string pTelefono1, string pTelefono2, string pTelefono3)
        {
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Apellido1 = pApellido1;
            this.Apellido2 = pApellido2;
            this.Telefono1 = pTelefono1;
            this.Telefono2 = pTelefono2;
            this.Telefono3 = pTelefono3;
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return apellido1;
            }

            set
            {
                apellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Telefono1
        {
            get
            {
                return telefono1;
            }

            set
            {
                telefono1 = value;
            }
        }

        public string Telefono2
        {
            get
            {
                return telefono2;
            }

            set
            {
                telefono2 = value;
            }
        }

        public string Telefono3
        {
            get
            {
                return telefono3;
            }

            set
            {
                telefono3 = value;
            }
        }

        public override string ToString()
        {
            return (this.cedula + "-" + this.nombre + " " + this.apellido1 + " " + this.Apellido2);
        }
    }
}
