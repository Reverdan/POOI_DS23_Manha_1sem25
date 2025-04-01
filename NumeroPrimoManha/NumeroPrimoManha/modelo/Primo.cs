using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoManha.modelo
{
    public class Primo
    {
		private string mensagem;
		private int num;

        public Primo(int num)
        {
            this.num = num;
            this.Verificar();
        }

        private void Verificar()
        {

        }

        public string Mensagem
		{
			get { return mensagem; }
		}

	}
}
