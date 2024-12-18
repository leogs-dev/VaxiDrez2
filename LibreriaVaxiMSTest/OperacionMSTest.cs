using LibreriaVaxi;

namespace LibreriaVaxiMSTest
{
    [TestClass]
    public class OperacionMSTest
    {
        [TestMethod]
        public void SumarNumeros_InputDosNumeros_GetValorCorrecto()
        {
            // 1. Arrange - Inicializacion de las variables o componentes que ejecutaran el test.
            Operacion op = new Operacion();
            int numero1Test = 50;
            int numero2Test = 69;
            // 2. Act - Representa la ejecucion de la operacion.
            int resultado = op.SumarNumeros(numero1Test, numero2Test);
            // 3. Assert - Propio del paquete Unit Test, contiene libreias y operadores para comparar tu resultado.
            Assert.AreEqual(119, resultado);
        }
    }
}
