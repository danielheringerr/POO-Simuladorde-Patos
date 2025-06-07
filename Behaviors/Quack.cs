
using System;

namespace SimuladorDePatos.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
