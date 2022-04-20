using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramacionIntermedia;
namespace Tests
{
    [TestClass]
    public class Test_Delegates
    {
        [TestMethod]
        public void TestMethod1()
        {
            Delegates del1 = new Delegates();

            del1.EjemploDelegado();

            del1.EjemploFunc(); 
        }
    }
}
