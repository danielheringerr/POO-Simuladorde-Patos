using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_Patos
{
    internal class CyberDuck : Duck, IFlyable, IQuackable
    {
        public override void display()
        {
            Console.WriteLine("Sou um pato Cibernético!");
            string cyberduck = @"
                 _______
                __(o o)__
               /|| || |||\
              |||====|||==|
              \|| _ || _ |/
                || || ||
               === === ===
                CyberDuck
            ";
            Console.WriteLine(cyberduck);
        }

        public override void swim()
        {
            Console.WriteLine("Eu consigo nadar até 3 metros de profundidade! (Mais que isso eu estrago)");
        }

        public void fly()
        {
            Console.WriteLine("Propulsores ativados! O PatoCibernético está voando com jatos!");
        }

        public void quack()
        {
            Console.WriteLine("Consigo grasnar como um pato real e em código binário, como você prefere?");
            Console.WriteLine("1 -> Quack real     | 2 -> Quack binário");
            string entrada = Console.ReadLine().ToUpper();

            switch (entrada)
            {
                case "1":
                    Console.WriteLine("Quack Quack");
                    break;

                case "2":
                    Console.WriteLine("01010011 01110001 01110101 01100001 01100011 01101011!");
                    break;


            }
        }

    }
}
