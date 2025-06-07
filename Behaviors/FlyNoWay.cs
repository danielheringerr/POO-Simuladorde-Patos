
using System;

namespace SimuladorDePatos.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Não posso voar.");
        }
    }
}
