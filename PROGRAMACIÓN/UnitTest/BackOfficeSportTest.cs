using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficeSportTest
    {
        [TestMethod]
        public void Register()
        {
            SportControler.Alta("Test", "Test");
            bool response = new SportControler().ExistSport(new SportControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            int id = new SportControler().GetId("Test");
            SportControler.Modify(id, "Test", "n");
            bool response = new SportControler().HaveChange(id);
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            int id = new SportControler().GetId("Test");
            SportControler.Delete(id);
            bool response = new SportControler().ExistSport(id);
            Assert.AreEqual(false, response);
        }

    }
}

