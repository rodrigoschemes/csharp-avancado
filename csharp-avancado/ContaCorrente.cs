using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
   class ContaCorrente : Conta, ITributavel
    {
        private static int totalDeContas = 0;

        public ContaCorrente()
        {
                ContaCorrente.totalDeContas++;
        }

        public int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

        public override void Saca(double valor)
        {
            if (valor > this.Saldo )
            {
                throw new SaldoInsuficienteException("Valor do saque maior que o saldo");
            } else if(valor < 0) {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo -= (valor + 0.1);
            }
        }
    }
}
