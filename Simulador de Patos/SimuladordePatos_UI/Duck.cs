using System.Drawing;
using System.IO;

namespace Simulador_de_Patos
{
    public class Duck
    {
        public byte[] fotoPato {  get; set; }
        public byte[] quackSound { get; set; }

        // Construtor da classe base
        public Duck(string caminhoFoto, string caminhoSom)
        {
            carregarFoto(caminhoFoto);
            carregarQuackSound(caminhoSom);
        }

        public virtual void swim()
        {
            Console.WriteLine("Todos os patos nadam, mesmo os de borracha!");

        }
        public virtual void display()
        {
            
        }

        // Método para carregar a foto do pato (PNG)
        protected void carregarFoto(string caminho)
        {
            if (File.Exists(caminho) && Path.GetExtension(caminho).Equals(".png", StringComparison.OrdinalIgnoreCase))
            {
                fotoPato = File.ReadAllBytes(caminho);
                Console.WriteLine("Foto carregada");
            }
            else
            {
                Console.WriteLine("Erro: Arquivo de foto não encontrado ou formato inválido.");
            }
        }

        // Método para carregar o som do pato (MP3)
        protected void carregarQuackSound(string caminho)
        {
            if (File.Exists(caminho) &&  Path.GetExtension(caminho).Equals(".mp3", StringComparison.OrdinalIgnoreCase){
                quackSound = File.ReadAllBytes(caminho);
                Console.WriteLine("Som do pato carregado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro: Arquivo de som não encontrado ou formato inválido.");
            }
        }
    }
}
