using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Logica
{
    public class Combustible
    {
        private string combustiblee;
        private string descripcion;
        private double combus_costo;

        public string Combustiblee
        {
            get
            {
                return combustiblee;
            }

            set
            {
                combustiblee = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public double Combus_costo
        {
            get
            {
                return combus_costo;
            }

            set
            {
                combus_costo = value;
            }
        }

        public Combustible(string pcombustiblee, string pdescripcion, double pcombus_costo)
        {
            this.combustiblee = pcombustiblee;
            this.descripcion = pdescripcion;
            this.combus_costo = pcombus_costo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
