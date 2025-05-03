using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_Patos
{
    internal class MallardDuck : Duck, IFlyable
    {
        public override void display()
        {
            Console.WriteLine("Sou um pato-real!");
        }

        public void fly()
        {
            Console.WriteLine("Voando como um pato-real!");
        }
    }
}
