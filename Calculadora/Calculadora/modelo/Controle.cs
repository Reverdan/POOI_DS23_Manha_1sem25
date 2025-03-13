using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Controle
    {
        public String mensagem;

        public void executar(String numero1, String numero2, String op)
        {
            mensagem = "";
            Validacao validacao = new Validacao();
            validacao.validar(numero1, numero2, op);
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                mensagem = calculos.calcular(validacao.n1, validacao.n2, op).ToString();
            }
            else
            {
                mensagem = validacao.mensagem;
            }
        }
    }
}
