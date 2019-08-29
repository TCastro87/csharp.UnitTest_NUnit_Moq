using System;
using Principal;

namespace ContaTesteNUnit
{
    class ContaTeste
    {
        static void Main(string[] args)
        {
            testContaSacar();
            testContaSacarSemSaldo();
        }

        public static void testContaSacar()
        {
            //Arrange
            Conta conta = new Conta("0001", 100);
            bool resultadoEsperado = true;

            //Act
            bool resultado = conta.Sacar(50); 

            //Assert
            if(resultado == resultadoEsperado)
            {
                Console.WriteLine("testContaSacar: OK");
            } else
            {
                Console.WriteLine("testContaSacar: Falha");
            }
        }

        public static void testContaSacarSemSaldo()
        {
            //Arrange
            Conta conta = new Conta("0001", 100);
            bool resultadoEsperado = false;

            //Act
            bool resultado = conta.Sacar(120); 

            //Assert
            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("testContaSacarSemSaldo: OK");
            }
            else
            {
                Console.WriteLine("testContaSacarSemSaldo: Falha");
            }
        }
    }
}
