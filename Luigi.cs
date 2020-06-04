namespace Aula10Polimorfismo
{
    public class Luigi : Player
    {
        public override void Correr(){
            System.Console.WriteLine("Luigi correndo");
        }

         public override void Saudar(){
           System.Console.WriteLine("oi, eu sou luigi"); 
        }
    }
}