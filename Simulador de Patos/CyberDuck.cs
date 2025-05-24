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

        public CyberDuck(string caminhoFoto, string caminhoSom) : base(caminhoFoto, caminhoSom)
        {

        }

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
