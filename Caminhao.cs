using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class Caminhao : Veiculos
    {

        private int Carga;

        private Caminhao(int Carga)
        {

        }

        public override double GetPrecoVenda()
        {
            double aux = 0;

            if (this.Carga > 2000)
            {
                aux = base.GetPrecoVenda() - (base.GetPrecoVenda() / 10);
            }

            else
            {
                aux = base.GetPrecoVenda() - (base.GetPrecoVenda() / 20);
            }

            return aux;
        }
    }
}
       
