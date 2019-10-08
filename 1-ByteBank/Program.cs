using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //new ContaCorrente(); //estamos criando na memoria do  computador / minha primeira classe / primeiro objeto

            ContaCorrente contaDaBruna = new ContaCorrente();
            contaDaBruna.titular = "Bruna"; // dentro da linha titular tem o nome da Bruna
            contaDaBruna.agencia = 863;
            contaDaBruna.numero = 863452;
            contaDaBruna.saldo = 100;

            Console.WriteLine(contaDaBruna.titular);
            Console.WriteLine("Agência: " +  contaDaBruna.agencia);
            Console.WriteLine("Número: " +  contaDaBruna.numero);
            Console.WriteLine("Saldp: " +  contaDaBruna.saldo);

            contaDaBruna.saldo += 200;

            Console.WriteLine("Novo Saldo: " + contaDaBruna.saldo);

            
            Console.ReadLine();
           
        }
    }
}
