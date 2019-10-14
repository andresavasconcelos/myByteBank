//MINHA PRIMEIRA CLASSE DE CONTA CORRENTE

//using _5_ByteBank; com o namespace essa linha torna-se desnecess

namespace _6_ByteBank
{
    public class ContaCorrente
    {
        //public _5_ByteBank.Cliente titular;
        //public Cliente titular;
        private Cliente _titular;
        public int agencia;
        public int numero;
        private double _saldo = 100; //só é visivel dentro da classe


        public Cliente Titular
        {

            get;
            set;

            //simplificando e nao muda nada // USA-SE QUANDO NAO TEM NENHUMA REGRA

           // get
           // {
           //     return _titular;
           // }
           // set
           // {
           //     _titular = value;
           // }
        }
        public double Saldo // propriedade
        {
            get // sempre retorna
            {
                return _saldo; // precisa ter um retorno // _saldo é um campo privado
            }

            set // define o valor saldo
            {
                if (value < 0) // o valor que estamos recebendo que seria saldo
                {
                    return; // para de executar quando para assim
                            //verifica o argumento saldo
                }

                this._saldo = value; // acessa o campo saldo // acontece colisao de nomes entao temos que colcocar o this
            }
        }

       //public void SetSaldo(double saldo) //definir == set
       //{
       //    if(saldo < 0)
       //    {
       //        return; // para de executar quando para assim
       //        //verifica o argumento saldo
       //    }
       //    
       //    this.saldo = saldo; // acessa o campo saldo // acontece colisao de nomes entao temos que colcocar o this
       //    
       //}

       //public double GetSaldo() //  obter == get
       //{
       //    return saldo;
       //}

        public bool Sacar(double valor) // usases verbos em caso de criação de função; temos que colocar // PODEMOS CHAMAR DE FUNÇÃO PORQUE ELE RETORNA ALGO
        {
            if (_saldo < valor) //this é uma paçavra reservada que diz que eu estou acessando o saldo desssa isntancia, desse objeto
            {
                return false;
            }
            else // somso obrigados a colocar o else porque garantimos que essa função retorna um bool
            {
                _saldo -= valor;

                return true;
            }
        }
        public void Depositar(double valor) // como nao tem retorno e portanto colocamos VOID // PODEMOS CHAMAR DE METODOS PORQUE TEM O VOID
        {
            //this.saldo += valor; não é necessario colocar o this porque nao tem conflito de argumentos ja que tem o nome diferentes
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }
}

    
