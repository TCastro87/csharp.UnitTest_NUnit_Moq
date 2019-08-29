using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class ValidadorCredito : IValidadorCredito
    {

        public bool ValidarCredito(string cpf, decimal valor)
        {

            bool StatusSerasa = VerificarSituacaoSerasa(cpf);
            bool StatusSPC = VerificarSituacaoSPC(cpf);

            return (StatusSerasa && StatusSPC);
        }

        private bool VerificarSituacaoSPC(string cpf)
        {
            //Chamada a um webservice para verificar situação SPC
            return true;
        }

        private bool VerificarSituacaoSerasa(string cpf)
        {
            //Chamada a um webservice para verificar situação Serasa
            return true;
        }
    }
}
