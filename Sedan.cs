using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class Sedan : Veiculos
    {
        private int Comprimento;
        private Sedan(int Comprimento)
        {

        }
    
        public override double GetPrecoVenda()
        {
            double aux = 0;

            if (this.Comprimento > 6000)
            {
                aux = base.GetPrecoVenda() - (base.GetPrecoVenda() / 5);
            }

            else
            {
                aux = base.GetPrecoVenda() - (base.GetPrecoVenda() / 10);
            }

            return aux;
        }
    }
}




