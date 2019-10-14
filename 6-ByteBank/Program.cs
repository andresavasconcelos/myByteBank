using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();
            cliente.nome = "Guilherme";
            cliente.cpf = "434.564.879-20";
            cliente.profissao = "Desenvolvedor c#";


            conta.Saldo = -10;
            conta.Titular = cliente; // usa-se a propri titular

            //Console.WriteLine(conta.GetSaldo());
            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Saldo);
            

            Console.ReadLine();
        }
    }
}
