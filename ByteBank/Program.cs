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
            CalcularBonificacao();
            Console.ReadLine();

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            // Funcionario leonardo = new Funcionario(); Não é mais permitido pois a classe Funcionário é abstrata

            Designer pedro = new Designer("883.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("222.222.947-22");
            pedro.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("234.456.222-39");
            pedro.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("856.222.048-12");
            pedro.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
