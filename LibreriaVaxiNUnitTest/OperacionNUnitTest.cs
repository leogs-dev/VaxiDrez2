using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace LibreriaVaxi
{
    [TestFixture]
    public class OperacionNUnitTest
    {
        [Test]
        public void SumarNumeros_InputDosNumeros_GetValorCorrecto()
        {
            // 1. Arrange - Inicializacion de las variables o componentes que ejecutaran el test.
            Operacion op = new Operacion();
            int numero1Test = 50;
            int numero2Test = 69;
            // 2. Act - Representa la ejecucion de la operacion.
            int resultado = op.SumarNumeros(numero1Test, numero2Test);
            // 3. Assert - Propio del paquete Unit Test, contiene libreias y operadores para comparar tu resultado.
            ClassicAssert.AreEqual(119, resultado);
        }

        [Test]
        public void IsValorPar_InputNumeroImPar_ReturnFalse()
        {
            Operacion op = new Operacion();
            int numeroImpar = 3;

            bool isPar = op.IsValorPar(numeroImpar);
            // Dos maneras de hacer la evaluacion.
            // IsFalse() or That()
            ClassicAssert.IsFalse(isPar);
            Assert.That(isPar, Is.EqualTo(false));
        }

        [Test]
        public void IsValorPar_InputNumeroPar_ReturnTrue()
        {
            Operacion op = new Operacion();
            int numeroPar = 8;

            bool isPar = op.IsValorPar(numeroPar);

            ClassicAssert.IsTrue(isPar);
            Assert.That(isPar, Is.EqualTo(true));
        }
    }
}
