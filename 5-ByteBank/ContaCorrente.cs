//MINHA PRIMEIRA CLASSE DE CONTA CORRENTE

//using _5_ByteBank; com o namespace essa linha torna-se desnecess

namespace _5_ByteBank
{
    public class ContaCorrente
    {
        //public _5_ByteBank.Cliente titular;
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor) // usases verbos em caso de criação de função; temos que colocar // PODEMOS CHAMAR DE FUNÇÃO PORQUE ELE RETORNA ALGO
        {
            if (this.saldo < valor) //this é uma paçavra reservada que diz que eu estou acessando o saldo desssa isntancia, desse objeto
            {
                return false;
            }
            else // somso obrigados a colocar o else porque garantimos que essa função retorna um bool
            {
                this.saldo -= valor;

                return true;
            }
        }
        public void Depositar(double valor) // como nao tem retorno e portanto colocamos VOID // PODEMOS CHAMAR DE METODOS PORQUE TEM O VOID
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }
}

    
