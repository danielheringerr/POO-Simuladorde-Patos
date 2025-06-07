
using SimuladorDePatos.Models;
using System;

namespace SimuladorDePatos
{
    class Program
    {
        static void Main()
        {
            Duck[] patos = new Duck[]
            {
                new MallardDuck(),
                new RubberDuck(),
                new CyberDuck()
            };

            foreach (var pato in patos)
            {
                pato.Display();
                pato.PerformFly();
                pato.PerformQuack();
                Console.WriteLine();
            }
        }
    }
}
