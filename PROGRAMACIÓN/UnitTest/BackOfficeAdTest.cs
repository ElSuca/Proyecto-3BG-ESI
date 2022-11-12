using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficeAdTest
    {
        [TestMethod]
        public void Register()
        {
            AdControler.Alta("Test", "Test", "Test");
            bool response = new AdControler().ExistAd("Test");
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            AdControler.Modify("Test",new AdControler().GetId("Test"),"Test", "n");
            bool response = new AdControler().HaveChange(new AdControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            AdControler.Delete(new AdControler().GetId("Test"));
            bool response = new AdControler().ExistAd("Test");
            Assert.AreEqual(false, response);
        }
    }
}
