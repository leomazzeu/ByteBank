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

            Cliente leonardo = new Cliente();
            ContaCorrente conta = new ContaCorrente();

            leonardo.nome = "Leonardo";
            leonardo.profissao = "Programador";
            leonardo.cpf = "123.123.123-12";

            conta.Saldo = -10;
            conta.Titular = leonardo;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Titular.cpf);
            Console.WriteLine(conta.Titular.profissao);

            Console.ReadLine();


        }
    }
}
