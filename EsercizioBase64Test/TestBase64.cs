using Microsoft.VisualStudio.TestTools.UnitTesting;
using EsercizioBase64;

namespace EsercizioBase64Test
{
    [TestClass]
    public class TestBase64
    {
        [TestMethod]
        public void TestMethod1()
        {
            string risposta = LibraryBase64.Base64();
            Assert.AreEqual("Tmljb2xh", risposta);
        }
    }
}
