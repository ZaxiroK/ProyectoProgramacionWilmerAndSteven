using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class ModeloE
    {
        private int idModelo;
        private string descripcion;
        private MarcaE oMarca;
        private int anno;

        public ModeloE(int pIdModelo, string pDescripcion, MarcaE pOMarcaE, int pAnno)
        {
            this.idModelo = pIdModelo;
            this.descripcion = pDescripcion;
            this.oMarca = pOMarcaE;
            this.Anno = pAnno;
        }

        public int IdModelo
        {
            get { return idModelo; }
            set { idModelo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public MarcaE OMarca
        {
            get
            {
                return oMarca;
            }
            set
            {
                oMarca = value;
            }
        }

        public int Anno
        {
            get
            {
                return anno;
            }
            set
            {
                anno = value;
            }
        }

        public override string ToString()
        {
            return (this.oMarca.Descripcion +": "+ this.descripcion +"-"+ this.anno);
        }
    }
}
