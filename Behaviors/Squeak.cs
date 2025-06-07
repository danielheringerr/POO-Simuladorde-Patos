
using System;

namespace SimuladorDePatos.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Piii!");
        }
    }
}
