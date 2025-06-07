
using System;
using SimuladorDePatos.Behaviors;

namespace SimuladorDePatos.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
            FotoPath = "Resources/imgs/MallardDuck.png";
            SoundPath = "Resources/sounds/MallardDuck.wav";
        }

        public override void Display()
        {
            Console.WriteLine("Sou um pato-real!");
        }
    }
}
