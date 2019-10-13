using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBruna = new ContaCorrente(); // instanciando uma classe -- obj DO TIPO CONTA CORRENTE

            contaDaBruna.titular = "Bruna"; // estamos acessando a instanvia da Bruna
            contaDaBruna.agencia = 863;
            contaDaBruna.numero = 863452;

            //CRIANDO UMA NOVA 
            ContaCorrente contaDaBrunaNeri = new ContaCorrente();
            contaDaBrunaNeri.titular = "Bruna Neri";
            contaDaBrunaNeri.agencia = 863;
            contaDaBrunaNeri.numero = 863452;

            Console.WriteLine("iguadade de tipo de referencia" + (contaDaBruna == contaDaBrunaNeri)); // False ou seja eles não sao iguais mesmo com as mesmas informações
            // essas duas instancias tem endereços diferentes e por isso que não sao iguais, quando criamos uma nova instancia estamos criando 
            // endereços diferentes -> ContaCorrente contaGabriela = new ContaCorrente(); 

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("igualdade de tipo de valor" + (idade == idadeMaisUmaVez)); // valor true -- colocar entre parenses a empressao bool

            contaDaBruna = contaDaBrunaNeri; // estamos destinando o mesmo valor para dois objetos

            Console.WriteLine(contaDaBruna == contaDaBrunaNeri); //nesse caso o resultado é true porque estamos apontando p end de uma para outra.

            contaDaBruna.saldo = 300;

            Console.WriteLine(contaDaBruna.saldo);
            Console.WriteLine(contaDaBrunaNeri.saldo); 
        // nesse caso o valor do saldo será igual paras as duas porque o endereço está com as variaveis que apontam para o mesmo objeto.

            if(contaDaBruna.saldo >= 100)
            {
                contaDaBruna.saldo -= 10;
            }

            Console.ReadLine();


        }
    }
}
