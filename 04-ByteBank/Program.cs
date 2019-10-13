using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
                
            Console.WriteLine(contaDoBruno.saldo);           // antes da função, então retornará 10
            bool resultadoSaque = contaDoBruno.Sacar(500);   // por estar chamando uma função devemso colocar os parametros dentro do parenteses // logo ele visitara a função e verificara se 50 é menor que o valor que o saldo do Bruno // bool pq é um tipo da variavel da funcao/ dessa forma estamos guadando o valor da variavel contaDoBruno
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);         // apos a função, então retornará 50;

            contaDoBruno.Depositar(500); // somando mais 500 no saldo

            Console.WriteLine("Saldo do Bruno" + contaDoBruno.saldo);

            ContaCorrente contaDaBruna = new ContaCorrente();

            contaDaBruna.titular = "Bruna";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Bruna: " + contaDaBruna.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaBruna); // referencia e destino

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Bruna: " + contaDaBruna.saldo);

            Console.WriteLine("resultado da transferencia: " + resultadoTransferencia); // true porque essa trabsferencia ocorreu como esperado

            bool resultadoSegundaTransferencia = contaDaBruna.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Bruna: " + contaDaBruna.saldo);

            Console.WriteLine("Resultado da transferencia: " + resultadoSegundaTransferencia);
            Console.Read();
        }
    }
}
