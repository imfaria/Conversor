using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class Pessoa
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private int Idade { get; set; }
        private char Sexo { get; set; }

        public Pessoa()
        {
            this.Nome = "";
            this.CPF = "00000000000";
            this.Idade = 0;
            this.Sexo = 'F';
        }

        public Pessoa(string Nome, string CPF, int Idade, char sexo)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Idade = Idade;
            this.Sexo = Sexo;
        }

        public string GetNome()
        {
            return (this.Nome);
        }

        public string GetCPF()
        {
            return (this.CPF);
        }

        public int GetIdade()
        {
            return (this.Idade);
        }

        public string GetSexo()
        {
            string aux = "";
            if (this.Sexo == 'M' || this.Sexo == 'F')
            {
                aux = "Masculino";
            }
            else
            {
                aux = "Feminino";
            }
            return (aux);
        }

        private void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        private void SetCPF(string CPF)
        {
            this.CPF = CPF;
        }

        private void SetIdade(int Idade)
        {
            this.Idade = Idade;
        }

        private void SetSexo(char Sexo)
        {
            this.Sexo = Sexo;
        }

        private bool VerificaMaiorIdade()
        {
            bool aux = false;
            if (GetIdade() >= 18)
            {
                aux = true;
            }
            return (aux);
        }

        public string MaiorIdade()
        {
            string aux = "";
            if (VerificaMaiorIdade())
            {
                aux = GetNome() + " é maior de idade.";
            }
            else
            {
                aux = GetNome() + " é menor de idade.";
            }
            return (aux);
        }
    }
}

