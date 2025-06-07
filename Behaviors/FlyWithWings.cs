
using System;

namespace SimuladorDePatos.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Voando com asas!");
        }
    }
}
