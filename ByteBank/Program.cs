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
            leonardo.nome = "Leonardo";
            leonardo.cpf = "146.285.286-67";
            leonardo.profissao = "Pedreiro";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = leonardo;
            conta.agencia = 2525;
            conta.numero = 12345;
            conta.saldo = 800;

            Console.WriteLine(leonardo.nome);
            Console.WriteLine(conta.titular.nome); // Manipulando o mesmo objeto
            Console.WriteLine(conta.titular);

            Console.ReadLine();


        }
    }
}
