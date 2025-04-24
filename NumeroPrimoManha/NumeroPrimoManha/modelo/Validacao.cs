using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoManha.modelo
{
    public class Validacao
    {
		public string mensagem;
		public int num;
		public string numero;

        public Validacao(string numero)
        {
            this.numero = numero;
			this.Executar();
        }

		public void Executar()
		{
			this.mensagem = "";
			try
			{
				this.num = Convert.ToInt32(this.numero);
			}
			catch
			{
				this.mensagem = "Digite valores válidos";
			}
		}
	}
}
