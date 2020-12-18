using System;

namespace POO_Polimorfismo.Classes
{
    public abstract class Player
    {
        public virtual void Correr(){
            Console.WriteLine("Correndo em velocidade 10");
        }
    }
}