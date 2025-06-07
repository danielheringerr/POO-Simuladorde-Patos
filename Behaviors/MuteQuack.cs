
using System;

namespace SimuladorDePatos.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silêncio >>");
        }
    }
}
