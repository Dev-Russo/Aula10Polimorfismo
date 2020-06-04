using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Luigi();
            Player player2 = new Mario();
            player1.Saudar();
            player1.Correr();
            player2.Saudar();
            player2.Correr();
        }
    }
}
