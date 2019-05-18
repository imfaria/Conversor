using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class Data
    {
        private int Ano = 0, Mes = 0, Dia = 0;
        public Data(int Ano, int Mes, int Dia)
        {
            this.Ano = Ano;
            this.Mes = Mes;
            this.Dia = Dia;
        }

        public Data()
        {

        }

        public int GetDia()
        {
            return this.Dia;
        }

        public int GetMes()
        {
            return this.Mes;
        }

        public int GetAno()
        {
            return this.Ano;
        }


        public void AdicionarDias(int dias)
        {
            this.Dia = this.Dia + dias;
            if (ProximoMes(dias))
            {
                this.Dia = 1;
            }
        }

        private bool AnoBisexto()
        {
            bool aux = false;
            if ((GetAno() % 400 == 0) || (GetAno() % 4 == 0 && GetAno() % 100 != 0))
            {
                aux = true;
            }
            return aux;
        }

        private bool ProximoMes(int dias)
        {
            bool aux = false;
            if (GetMes() == 1 || GetMes() == 3 || GetMes() == 5 || GetMes() == 7 || GetMes() == 8 || GetMes() == 10 || GetMes() == 12)
            {
                if (GetDia() + dias >= 31)
                {
                    aux = true;
                }
            }
            else if (GetMes() == 4 || GetMes() == 6 || GetMes() == 9 || GetMes() == 11)
            {
                if (GetDia() + dias >= 30)
                {
                    aux = true;
                }
            }
            else
            {
                if (AnoBisexto())
                {
                    if (GetDia() + dias >= 29)
                    {
                        aux = true;
                    }
                }
                else
                {
                    if (GetDia() + dias >= 28)
                    {
                        aux = true;
                    }
                }
            }
            return aux;
        }

    }
}
