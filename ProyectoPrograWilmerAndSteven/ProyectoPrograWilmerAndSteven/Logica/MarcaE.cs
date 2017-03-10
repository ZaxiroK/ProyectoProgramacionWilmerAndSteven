using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MarcaE
    {
        private int idMarca;
        private string descripcion;

        public MarcaE(int pIdMarca, string pDescripcion)
        {
            this.idMarca = pIdMarca;
            this.Descripcion = pDescripcion;
        }

        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public override string ToString()
        {
            return (this.idMarca + "-" + this.descripcion);
        }
    }
}
