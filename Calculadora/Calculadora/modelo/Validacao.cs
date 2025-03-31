using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Validacao
    {

        private Double n1;
        private Double n2;
        private String mensagem;

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

        public double N1 { get => n1; }
        public double N2 { get => n2; }
        public string Mensagem { get => mensagem; }
    }
}
