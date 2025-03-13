using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Calculos
    {
        public Double calcular(Double n1, Double n2, string op)
        {
            Double resultado = 0;
            if (op.Equals("+")) resultado = n1 + n2;
            if (op.Equals("-")) resultado = n1 - n2;
            if (op.Equals("*")) resultado = n1 * n2;
            if (op.Equals("/")) resultado = n1 / n2;
            return resultado;
        }
    }
}
