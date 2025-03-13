using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Validacao
    {
        public Double n1;
        public Double n2;
        public String mensagem;

        public void validar(String numero1, String numero2, String op)
        {
            mensagem = "";
            try
            {
                n1 = Convert.ToDouble(numero1);
                n2 = Convert.ToDouble(numero2);
                if (n2.Equals(0) && op.Equals("/"))
                {
                    mensagem = "Divisão por zero";
                }
            }
            catch
            {
                mensagem = "Digite números válidos";
            }
        }
    }
}
