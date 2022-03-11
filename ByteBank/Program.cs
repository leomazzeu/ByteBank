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

            Cliente conta = new Cliente();
            ContaCorrente cliente = new ContaCorrente(101, 8746375);

            conta.Nome = "Leonardo";
            conta.Profissao = "Programador";
            conta.CPF = "123.123.123-12";

            cliente.Saldo = -10;
            cliente.Titular = conta;

            Console.WriteLine(cliente.Titular.Nome);
            Console.WriteLine(cliente.Saldo);

            Console.WriteLine(cliente.Agencia);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();


        }
    }
}
