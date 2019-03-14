using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppCalculoSalario.Tests
{
    [TestClass()]
    public class CalculoDeduccionesTests
    {
        [TestMethod()]
        public void CalculoSaludTest()
        {
            var acout = new CalculoDeducciones(0, 0, 0, 0, 0);
            acout.Sueldo = 830000;
            double expected = 124500;
            double result = acout.CalculoSalud();

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CalculoRiesgosTest()
        {
            double expected = 16600;
            var acout = new CalculoDeducciones(0, 0, 0, 0, 0);
            acout.Sueldo = 830000;
            double result = acout.CalculoRiesgos(1);

            Assert.AreEqual(expected, result);
        }
    }
}