﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoManha.modelo
{
    public class Validacao
    {
		private string mensagem;
		private int n1;
		private string numero;

        public Validacao(string numero)
        {
            this.numero = numero;
			this.Validar();
        }

		private void Validar()
		{
			this.mensagem = "";
			try
			{
				this.n1 = Convert.ToInt32(this.numero);
			}
			catch
			{
				this.mensagem = "Digite valores válidos";
			}
		}

        public int N1
		{
			get { return n1; }
		}


		public string Mensagem
		{
			get { return mensagem; }
		}

	}
}
