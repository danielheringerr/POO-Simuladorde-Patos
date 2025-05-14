using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_Patos
{
    internal class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void display()
        {
            Console.WriteLine("Sou um pato-real!");
            string mallardDuck = @"
                 __
             __(o )>
             \ <_. )
              `---'
            Mallard Duck
            ";
            Console.WriteLine(mallardDuck);
        }

        public override void swim()
        {
            Console.WriteLine("Sou o Pato real eu nado muito bem na minha lagoa!");
        }
        public void fly()
        {
            Console.WriteLine("Voando como um pato-real!");
        }

        public void quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
