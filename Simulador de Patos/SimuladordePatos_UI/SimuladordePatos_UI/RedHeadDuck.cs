using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_Patos
{
    internal class RedHeadDuck:Duck, IFlyable, IQuackable
    {

        public RedHeadDuck(string caminhoFoto, string caminhoSom) : base(caminhoFoto, caminhoSom)
        {
        }

        /*
        public override void display()
        {
           
        }*/

        public override void swim()
        {
            
        }

        public  void fly()
        {
            
        }

        public void quack()
        {
            
        }
    }
}
