using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class PuestoE
    {
        private int idPuesto;
        private double salario;
        private char puesto;
        private string descripcion;

        public PuestoE(int pIdPuesto, double pSalario, char pPuesto, string pDescripcion)
        {
            this.idPuesto = pIdPuesto;
            this.salario = pSalario;
            this.puesto = pPuesto;
            this.descripcion = pDescripcion;
        }

        public int IdPuesto
        {
            get
            {
                return idPuesto;
            }

            set
            {
                idPuesto = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public char Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
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

        public override string ToString()
        {
            return (this.idPuesto +"-"+ this.descripcion);
        }

    }
}
