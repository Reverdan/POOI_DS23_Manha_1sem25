using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Calculos
    {
        #region Atributos

        private Double n1;
        private Double n2;
        private String op;
        private Double resultado;

        #endregion

        #region Construtores

        public Calculos(Double n1, Double n2, string op)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
            this.calcular();
        }

        #endregion

        #region Métodos

        private void calcular()
        {
            if (this.op.Equals("+")) resultado = this.n1 + this.n2;
            if (this.op.Equals("-")) resultado = this.n1 - this.n2;
            if (this.op.Equals("*")) resultado = this.n1 * this.n2;
            if (this.op.Equals("/")) resultado = this.n1 / this.n2;
        }

        #endregion

        #region Propriedades

        public double Resultado { get => resultado;}

        #endregion

    }
}
