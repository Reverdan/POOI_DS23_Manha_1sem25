using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoManha.modelo
{
    public class Controle
    {
		private string mensagem;
		private string numero;

        public Controle(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        private void Executar()
        {

        }

        public string Mensagem
		{
			get { return mensagem; }
		}

	}
}
