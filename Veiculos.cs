using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class Veiculos
    {
        protected int velocidade;
        protected double preco;
        protected string cor;

       public virtual double GetPrecoVenda()
        {
            return this.preco;
        }
    }
}
