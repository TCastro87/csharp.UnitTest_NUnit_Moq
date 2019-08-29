using System;

namespace Principal
{
    public class ValidadorCreditoFake : IValidadorCredito

    {
        public bool ValidarCredito(string cpf, decimal valor)
        {
            //não acessa nenhum webservice
            return true;
        }
    }
}
