using NUnit.Framework;
using Principal;

namespace ContaTesteNUnit
{
    [TestFixture]
    public class ContaTeste
    {
        Conta conta;

        [OneTimeSetUp]
        public void SetUp()
        {
            conta = new Conta("0009", 200);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            // codigo executado apos o último teste unitário
            conta = null;
        }

        [Test]
        [Category("Principal")]
        public void testSacar()
        {
            bool resultado = conta.Sacar(120);

            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Principal")]
        public void testSacarSemSaldo()
        {
            bool resultado = conta.Sacar(250);

            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Valores Inválidos")]
        public void testSacarValorNegativo()
        {
            bool resultado = conta.Sacar(10);

            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Valores Inválidos")]
        [Ignore("pendencia")]
        public void testSacarValorZero()
        {
            bool resultado = conta.Sacar(0);

            Assert.IsFalse(resultado);
        }

        [Test]
        [Timeout(4000)]
        [Ignore("pendencia")]
        public void testMetodoLento()
        {
            bool resultado = conta.Sacar(0);

            Assert.IsFalse(resultado);
        }
    }
}
