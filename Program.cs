using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class Program
    {
        static void Main(string[] args)
        {
            // CLASSE DATA

            Data aux = new Data(30, 9, 2018);

           Console.WriteLine(aux.GetDia());
           Console.WriteLine(aux.GetMes());
           Console.WriteLine(aux.GetAno());

           aux.AdicionarDias(1);

           Console.WriteLine(aux.GetDia());

            // CLASSE PESSOA
            Console.Write("Digite o nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Digite o CPF: ");
            string CPF = Console.ReadLine();
            Console.Write("Digite a idade: ");
            int Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o sexo [M] - Masculino - [F] - Feminino: ");
            char Sexo = char.Parse(Console.ReadLine());
            Pessoa pessoaComParametro = new Pessoa(Nome, CPF, Idade, Sexo);
            string Leitura = "\nNome: " + pessoaComParametro.GetNome() + "\n CPF: " + pessoaComParametro.GetCPF() + "\n Idade: " + pessoaComParametro.GetIdade() + "\n Sexo: " + pessoaComParametro.GetSexo();
            Console.WriteLine(Leitura);
            Console.WriteLine(pessoaComParametro.MaiorIdade());
            Pessoa pessoaSemParametro = new Pessoa();
            Leitura = "\nNome: " + pessoaSemParametro.GetNome() + "\n CPF: " + pessoaSemParametro.GetCPF() + "\n Idade: " + pessoaSemParametro.GetIdade() + "\n Sexo: " + pessoaSemParametro.GetSexo();
            Console.WriteLine(Leitura);
            Console.WriteLine(pessoaSemParametro.MaiorIdade());
        }
    }
}
