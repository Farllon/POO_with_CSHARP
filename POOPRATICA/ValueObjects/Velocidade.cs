using System;
using System.Collections.Generic;
using System.Text;

namespace POOPRATICA.ValueObjects
{
    class Velocidade
    {
        public Velocidade(double quantidade)
        {
            velocidade = quantidade.ToString();
        }

        public string velocidade { get; private set; }

        public override string ToString()
        {
            return velocidade;
        }
    }
}
