
namespace Exercicio3
{
    public class Conta
    {
        protected double _saldo;
        public double Saldo
        {
            get => _saldo;
            set
            {
                if (value >= 0)
                {
                    Saldo = value;
                }
                else
                {
                    Console.WriteLine("Saldo não pode ser menor que zero");
                }
            }
        }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public double ObterSaldo()
        {
            return this.Saldo;
        }
    }
}
