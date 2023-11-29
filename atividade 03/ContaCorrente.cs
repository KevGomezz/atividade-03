
namespace Exercicio3
{
    public class ContaCorrente : Conta, Tributavel
    {
        public double calculaTributos()
        {

            return base.Saldo * 1 / 100;
        }
    }
}

