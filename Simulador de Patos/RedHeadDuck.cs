using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_Patos
{
    internal class RedHeadDuck: Duck, IFlyable, IQuackable

    {
        public override void display()
        {
            Console.WriteLine("Sou um pato de cabeça vermelha!");
            string redheadDuck = @"
               |====|
             __(o )> 
             \ <_. )
              `---'
            Redhead Duck
            ";
            Console.WriteLine(redheadDuck);
        }

        public  void fly()
        {
            Console.WriteLine("Voando como um pato de cabeça vermelha!");
        }

        public void quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
