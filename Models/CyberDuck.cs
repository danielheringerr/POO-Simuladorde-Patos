
using System;
using SimuladorDePatos.Behaviors;

namespace SimuladorDePatos.Models
{
    public class CyberDuck : Duck
    {
        public CyberDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new MuteQuack();
            FotoPath = "Resources/imgs/CyberDuck.png";
            SoundPath = "Resources/sounds/CyberDuck.wav";
        }

        public override void Display()
        {
            Console.WriteLine("Sou um pato cibernético!");
        }
    }
}
