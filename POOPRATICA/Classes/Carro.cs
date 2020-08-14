using POOPRATICA.Interfaces;
using POOPRATICA.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace POOPRATICA.Classes
{
    class Carro : IVeiculo
    {
        public Carro(Velocidade velmax, Cor cor)
        {
            VelMax = velmax;
            CorCarro = cor;
            VelAtual = new Velocidade(0);
        }
        
        public Velocidade VelMax { get; private set; }
        public Velocidade VelAtual { get; private set; }
        public Cor CorCarro { get; private set; }

        public void Acelerar()
        {
            if (Convert.ToInt16(VelAtual.ToString()) < Convert.ToInt16(VelMax.ToString()))
                VelAtual = new Velocidade(Convert.ToInt16(VelAtual.ToString()) + 10);

            Console.WriteLine(VelAtual);
        }
    }
}
