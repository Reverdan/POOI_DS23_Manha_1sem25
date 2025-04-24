using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoManha.modelo
{
    public class Controle
    {
		public string mensagem;
		public string numero;

        public Controle(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.numero);
            if (validacao.mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.num);
                this.mensagem = primo.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

	}
}
