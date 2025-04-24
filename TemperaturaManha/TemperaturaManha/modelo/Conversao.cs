using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaManha.modelo
{
    public class Conversao : absPropriedades
    {
        public Conversao(string tipo, double temperatura) : base(tipo, temperatura)
        {
        }

        public override void Executar()
        {
            throw new NotImplementedException();
        }
    }
}
