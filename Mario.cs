namespace Aula10Polimorfismo
{
    public class Mario : Player
    {
        public override void Correr(){
            System.Console.WriteLine("o Mario esta correndo mais rapido");
        }

        public override void Saudar(){
           System.Console.WriteLine("oi, eu sou Mário"); 
        }
    }
}