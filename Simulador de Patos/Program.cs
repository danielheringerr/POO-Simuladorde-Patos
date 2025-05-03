namespace Simulador_de_Patos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> patos = new List<Duck>
            {
                new MallardDuck(),
                new RedHeadDuck(),
                new RubberDuck()
            };

            foreach (Duck pato in patos)
            {
                pato.display();
                pato.swim();

                if (pato is IFlyable voador)
                    voador.fly();

                if (pato is IQuackable quackable)
                    quackable.quack();

                Console.WriteLine(); 
            }

            Console.ReadKey();
        }
    }
}
