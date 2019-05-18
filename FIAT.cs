using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class FIAT : Veiculos
    {

        private int DescontoDeFabrica;

        public override double GetPrecoVenda()
        {
            return base.GetPrecoVenda() - DescontoDeFabrica;
        }
    }
}
