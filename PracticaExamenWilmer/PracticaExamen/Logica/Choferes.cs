using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Logica
{
    public class Choferes
    {
        private string chofer;
        private string nombre;

        public Choferes(string pchofer, string pnombre)
        {
            this.chofer = pchofer;
            this.nombre = pnombre;
        }

        public string Chofer
        {
            get
            {
                return chofer;
            }

            set
            {
                chofer = value;
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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
