using POOPRATICA.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace POOPRATICA.Interfaces
{
    interface IVeiculo
    {
        Velocidade VelMax { get; }
        Velocidade VelAtual { get; }
        Cor CorCarro { get; }

        void Acelerar();
    }
}
