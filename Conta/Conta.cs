using System;

namespace Principal
{
    public class Conta
    {
        private String cpf;
        private decimal saldo;
        private IValidadorCredito validadorCredito;

        public Conta(String cpf, decimal valor)
        {
            this.cpf = cpf;
            this.saldo = valor;
        }

        public void SetValidadorCredito(IValidadorCredito validador)
        {
            this.validadorCredito = validador;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                return false;
            }

            if (saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public bool SolicitarEmprestimo(decimal valor)
        {
            bool resultado = false;

            if (valor >= this.saldo * 10)
            {
                return resultado;
            }

            try
            {
                resultado = validadorCredito.ValidarCredito(this.cpf, valor);
            }
            catch (InvalidOperationException)
            {
                return resultado;
            }

            if (resultado)
            {
                this.saldo += valor;
            }

            return resultado;
        }
    }
}
