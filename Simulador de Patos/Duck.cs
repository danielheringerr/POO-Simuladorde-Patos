using System.Drawing;
using System.IO;
using System.Media;

namespace Simulador_de_Patos
{
    abstract class Duck
    {
        public string fotoPatoPath {  get;  set; }
        public string quackSoundPath { get;  set; }

        // Construtor da classe base
        public Duck(string caminhoFoto, string caminhoSom)
        { 
            fotoPatoPath = caminhoFoto;
            quackSoundPath = caminhoSom;  
        }

        public virtual void swim()
        {

        }

    }
}
