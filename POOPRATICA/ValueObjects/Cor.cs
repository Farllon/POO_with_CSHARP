using System;
using System.Collections.Generic;
using System.Text;

namespace POOPRATICA.ValueObjects
{
    class Cor
    {
        public Cor(string cor)
        {
            NomeCor = cor;
        }

        public string NomeCor { get; private set; }

        public override string ToString()
        {
            return NomeCor;
        }
    }
}
