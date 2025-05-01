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
            Console.WriteLine("Voar");
        }

        public  void fly()
        {
        
        }

        public void quack()
        {

        }



    }
}
