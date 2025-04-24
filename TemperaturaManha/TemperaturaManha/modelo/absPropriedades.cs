using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaManha.modelo
{
    public abstract class absPropriedades : intMetodos
    {
        public String mensagem;
        public String resposta;
        public String temp;
        public Double temperatura;
        public String tipo;

        protected absPropriedades(string tipo, double temperatura)
        {
            this.tipo = tipo;
            this.temperatura = temperatura;
            this.Executar();
        }

        protected absPropriedades(string tipo, string temp)
        {
            this.tipo = tipo;
            this.temp = temp;
            this.Executar();
        }

        protected absPropriedades(string temp)
        {
            this.temp = temp;
            this.Executar();
        }

        public abstract void Executar();
    }
}
