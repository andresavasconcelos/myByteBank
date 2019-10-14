using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente bruna = new Cliente();

           // bruna.nome = "Bruna Costa";
           // bruna.profissao = "Desenvolvedora C#";
           // bruna.cpf= "434.562.878-20";
           
            ContaCorrente conta = new ContaCorrente();

            //conta.titular = bruna;
            //conta.titular = new Cliente();

            //conta.titular.nome = "Bruna Neri";
            //conta.titular.cpf = "434.562.878-20";
            //conta.titular.profissao = "Desenvolvedora C#";


            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a referêcia em conta, titular é NULL");
            }
            //Console.WriteLine(bruna.nome); // é o mesmo que o objeto a baixo . São refenrcia ´para o mesmo objeto na memoria do computador
            Console.WriteLine(conta.titular); // é uma referencia vazia, ou seja nao retorna nada  - >> null
                        
            
            //Console.WriteLine(conta.titular.nome); // é analogo a linha a cima, mas de forma diferente
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();

 
            
        }
    }
}
