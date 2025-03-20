using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Calculos
    {
        public Double n1;
        public Double n2;
        public String op;
        public Double resultado;

        public Calculos(Double n1, Double n2, string op)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
            this.calcular();
        }

        public void calcular()
        {
            if (this.op.Equals("+")) resultado = this.n1 + this.n2;
            if (this.op.Equals("-")) resultado = this.n1 - this.n2;
            if (this.op.Equals("*")) resultado = this.n1 * this.n2;
            if (this.op.Equals("/")) resultado = this.n1 / this.n2;
        }
    }
}
