using POOPRATICA.Classes;
using POOPRATICA.ValueObjects;
using System;

namespace POOPRATICA
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro fiatUno = new Carro(new Velocidade(200), new Cor("Vermelho"));

            Console.WriteLine(fiatUno.VelMax);
            Console.WriteLine(fiatUno.CorCarro);

            for(int i = 0; i < 30; i++)
            {
                fiatUno.Acelerar();
            }

            Console.ReadKey();
        }
    }
}
