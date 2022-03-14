using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "123.123.123-32";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);

            Diretor elisa = new Diretor();
            elisa.Nome = "Elisa";
            elisa.CPF = "123.123.123-44";
            elisa.Salario = 5000;
            gerenciador.Registrar(elisa);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.CPF);
            Console.WriteLine(carlos.Salario);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(elisa.Nome);
            Console.WriteLine(elisa.CPF);
            Console.WriteLine(elisa.Salario);
            Console.WriteLine(elisa.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

            Console.ReadLine();


        }
    }
}
