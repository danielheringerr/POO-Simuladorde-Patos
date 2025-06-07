
using System;
using SimuladorDePatos.Behaviors;

namespace SimuladorDePatos.Models
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
            FotoPath = "Resources/imgs/RubberDuck.png";
            SoundPath = "Resources/sounds/RubberDuck.wav";
        }

        public override void Display()
        {
            Console.WriteLine("Sou um pato de borracha!");
        }
    }
}
