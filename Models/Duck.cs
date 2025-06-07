
using SimuladorDePatos.Behaviors;

namespace SimuladorDePatos.Models
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public string FotoPath { get; set; }
        public string SoundPath { get; set; }

        public void PerformFly() => flyBehavior.Fly();
        public void PerformQuack() => quackBehavior.Quack();
        public void Swim() => Console.WriteLine("Todos os patos nadam!");

        public void SetFlyBehavior(IFlyBehavior fb) => flyBehavior = fb;
        public void SetQuackBehavior(IQuackBehavior qb) => quackBehavior = qb;

        public abstract void Display();
    }
}
