namespace Aula10Polimorfismo
{
    public abstract class Player
    {
        public virtual void Correr(){
            System.Console.WriteLine("Correndo normalmente");
        }

        public virtual void Saudar(){
           System.Console.WriteLine("oi"); 
        }
    }
}