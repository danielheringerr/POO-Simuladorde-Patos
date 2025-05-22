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
                new MallardDuck(".\\imgs\\mallardDuck.png",".\\sounds\\MallardDuck.mp3"),
                new RedHeadDuck(".\\imgs\\redHeadDuck.png",".\\sounds\\MallardDuck.mp3"),
                new RubberDuck(".\\imgs\\rubberDuck.png", ".\\sounds\\RubberDuck.mp3"),
                new CyberDuck(".\\imgs\\cyberDuck.png",".\\sounds\\CyberDuck.mp3" )
            };

            int indiceAtual = 0;
            bool programaExecutando = true;

            while (programaExecutando)
            {
                Console.Clear();
                Console.WriteLine($"Pato {indiceAtual + 1} de {patos.Count}");

                patos[indiceAtual].display();

                Console.WriteLine("\n[ N ] Próximo  |  [ V ] Voltar  |  [ S ] Selecionar  |  [ F ] Finalizar");
                Console.Write("Escolha uma opção: ");
                string entrada = Console.ReadLine().ToUpper();

                switch (entrada)
                {
                    case "N":
                        indiceAtual = (indiceAtual + 1) % patos.Count;
                        break;

                    case "V":
                        indiceAtual = (indiceAtual - 1 + patos.Count) % patos.Count;
                        break;

                    case "S":
                        bool submenu = true;
                        while (submenu)
                        {
                            Console.Clear();
                            Console.WriteLine("=== Ações do Pato Selecionado ===\n");
                            patos[indiceAtual].display();

                            Console.WriteLine("\nEscolha uma ação:");
                            Console.WriteLine("1 - Nadar");
                            if (patos[indiceAtual] is IQuackable) Console.WriteLine("2 - Grasnar");
                            if (patos[indiceAtual] is IFlyable) Console.WriteLine("3 - Voar");
                            Console.WriteLine("0 - Voltar ao menu principal");

                            Console.Write("\nOpção: ");
                            string acao = Console.ReadLine();

                            switch (acao)
                            {
                                case "1":
                                    patos[indiceAtual].swim();
                                    break;
                                case "2":
                                    if (patos[indiceAtual] is IQuackable quackable)
                                        quackable.quack();
                                    else
                                        Console.WriteLine("Esse pato não pode grasnar.");
                                    break;
                                case "3":
                                    if (patos[indiceAtual] is IFlyable voador)
                                        voador.fly();
                                    else
                                        Console.WriteLine("Esse pato não pode voar.");
                                    break;
                                case "0":
                                    submenu = false;
                                    continue;
                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }

                            Console.WriteLine("\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;


                    case "F":
                            programaExecutando = false;
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
