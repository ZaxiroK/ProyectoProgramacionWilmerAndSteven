using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmpleadoE
    {
        private string cedula;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string direccion;
        private PuestoE oPuestoE;
        private string telefono1;
        private string telefono2;
        private string telefono3;
        public EmpleadoE(string pCedula, string pNombre, string pApellido1, string pApellido2,
               string pDireccion, PuestoE pOPuestoE, string pTelefono1, string pTelefono2,
               string pTelefono3)
        {
            this.cedula = pCedula;
            this.nombre = pNombre;
            this.apellido1 = pApellido1;
            this.apellido2 = pApellido2;
            this.direccion = pDireccion;
            this.oPuestoE = pOPuestoE;
            this.telefono1 = pTelefono1;
            this.telefono2 = pTelefono2;
            this.telefono3 = pTelefono3;
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

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        internal PuestoE OPuestoE
        {
            get
            {
                return oPuestoE;
            }

            set
            {
                oPuestoE = value;
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
            return (this.cedula + "-" + this.nombre +" "+ this.apellido1 +" "+ this.Apellido2);
        }
    }
}
