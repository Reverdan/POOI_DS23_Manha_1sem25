using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoManha.modelo
{
    public class Primo
    {
		public string mensagem;
		public int num;

        public Primo(int num)
        {
            this.num = num;
            this.Executar();
        }

        public void Executar()
        {
            this.mensagem = "É primo";
            for (int i = 2; i < num / 2 + 1; i++)
            {
                if (num % i == 0)
                {
                    this.mensagem = "Não é primo";
                    break;
                }
            }
        }
	}
}
