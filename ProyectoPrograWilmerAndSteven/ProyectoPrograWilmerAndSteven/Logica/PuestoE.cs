using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PuestoE
    {
        private int id_puesto;
        private double salario;
        private char puesto;
        private string descripcion;

        public PuestoE(int pId_puesto, double pSalario, char pPuesto, string pDescripcion)
        {
            this.id_puesto = pId_puesto;
            this.salario = pSalario;
            this.puesto = pPuesto;
            this.descripcion = pDescripcion;
        }

        public int IdPuesto
        {
            get
            {
                return id_puesto;
            }

            set
            {
                id_puesto = value;
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
            return (this.id_puesto +"-"+ this.descripcion);
        }

    }
}
