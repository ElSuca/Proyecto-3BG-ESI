using CapaLogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficeUserTest
    {
        [TestMethod]
        public void Register()
        {
            UserControler.Alta("Test", "Test", "Test", "Test", "Test", "Test", "Test", 111111111, "Test", "Test", 11111111, "Test", "Test");
            bool response = new UserControler().ExistUser("Test");
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            UserControler.Modify(new UserControler().GetId("Test"), "n", "Test", "Test", "Test", "Test", "Test", "Test", 111111111, "Test", "Test", 11111111, "Test", "Test");
            bool response = new UserControler().HaveChange("Test");
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            UserControler.Delete(new UserControler().GetId("Test"));
            bool response = new UserControler().ExistUser("Test");
            Assert.AreEqual(false, response);
        }
    }
}
