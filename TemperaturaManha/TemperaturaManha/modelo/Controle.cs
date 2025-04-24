using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaManha.modelo
{
    public class Controle : absPropriedades
    {
        public Controle(string tipo, string temp) : base(tipo, temp)
        {
        }

        public override void Executar()
        {
            throw new NotImplementedException();
        }
    }
}
