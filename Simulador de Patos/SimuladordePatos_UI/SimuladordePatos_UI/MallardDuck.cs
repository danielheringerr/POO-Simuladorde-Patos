using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_Patos
{
    internal class MallardDuck: Duck, IFlyable, IQuackable
    {

        public MallardDuck(string caminhoFoto, string caminhoSom): base(caminhoFoto, caminhoSom)  {
        
        }

        /*public override string display()
        {
          
        }*/

        public override void swim()
        {
            
        }
        public void fly()
        {
            
        }

        public void quack()
        {
            
        }
    }
}
