using System;
using System.Collections.Generic;

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

            int indiceAtual = 0;
            bool executando = true;

            while (executando)
            {
                Console.Clear();
                Console.WriteLine($"Pato {indiceAtual + 1} de {patos.Count}");

                patos[indiceAtual].display();

                Console.WriteLine("\n[ N ] Próximo  |  [ V ] Voltar  |  [ S ] Selecionar  |  [ F ] Finalizar");
                Console.Write("Escolha uma opção: ");
                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "N":
                        indiceAtual = (indiceAtual + 1) % patos.Count;
                        break;

                    case "V":
                        indiceAtual = (indiceAtual - 1 + patos.Count) % patos.Count;
                        break;

                    case "S":
                        Console.Clear();
                        Console.WriteLine("=== Informações do Pato Selecionado ===\n");
                        patos[indiceAtual].display();
                        patos[indiceAtual].swim();

                        if (patos[indiceAtual] is IFlyable voador)
                            voador.fly();

                        if (patos[indiceAtual] is IQuackable quackable)
                            quackable.quack();

                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                        break;

                    case "F":
                        executando = false;
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
