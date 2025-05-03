using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_Patos
{
    internal class RubberDuck : Duck, IQuackable
    {
        public override void display()
        {
            Console.WriteLine("Sou um pato de borracha!");
        }

       
        public void quack()
        {
            Console.WriteLine("Squeak! (Som de pato de borracha)");
        }
    }
}
