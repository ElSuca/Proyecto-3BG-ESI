using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficeAsociationTest
    {
        [TestMethod]
        public void Register()
        {
            bool response;
            SportControler.Alta("Test2", "Test2");
            response = new SportControler().ExistSport(new SportControler().GetId("Test2"));

            if (response)
            {
                AsociationControler.Alta("Test", "Test", "Test", "Test", 1111, "Test", "Test", "1111-11-11", "1111-11-11", new SportControler().GetId("Test2"), "Test", 1);
                response = new AsociationControler().ExistAsociation(new AsociationControler().GetId("Test"));
                Assert.AreEqual(true, response);
            }
            else Assert.Fail();
        }
        [TestMethod]
        public void Modify()
        {
            bool response;
            response = new SportControler().ExistSport(new SportControler().GetId("Test2"));

            if (response)
            {
                int id = new AsociationControler().GetId("Test");
                AsociationControler.Modify(id, "Test", "Test", "n", "Test", 1111, "Test", "Test", "1111-11-11", "1111-11-11", new SportControler().GetId("Test2"), "Test", 1);
                response = new AsociationControler().HaveChange(id);
                Assert.AreEqual(true, response);
            }
            else Assert.Fail();
        }
        [TestMethod]
        public void Delete()
        {
            bool response;
            response = new SportControler().ExistSport(new SportControler().GetId("Test2"));

            if (response)
            {
                int id = new AsociationControler().GetId("Test");
                AsociationControler.Delete(id);
                SportControler.Delete(new SportControler().GetId("Test2"));
                response = new AsociationControler().ExistAsociation(id);
                Assert.AreEqual(false, response);
            }
            else Assert.Fail();
        }
    }
}
