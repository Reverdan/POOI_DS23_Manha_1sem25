using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Controle
    {
        private String mensagem;

        public void executar(String numero1, String numero2, String op)
        {
            mensagem = "";
            Validacao validacao = new Validacao();
            validacao.validar(numero1, numero2, op);
            if (validacao.Mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.N1, validacao.N2, op);
                mensagem = calculos.Resultado.ToString();
            }
            else
            {
                mensagem = validacao.Mensagem;
            }
        }

        public string Mensagem { get => mensagem;}

        public Calculos Calculos
        {
            get => default;
            set
            {
            }
        }

        public Validacao Validacao
        {
            get => default;
            set
            {
            }
        }
    }
}
