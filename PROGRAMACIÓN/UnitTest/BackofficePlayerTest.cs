using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficePlayerTest
    {
        [TestMethod]
        public void Register()
        {
            PlayerControler.Alta("Test", "Test", "Test", "Test", "1111-11-11", "Test", "Test", "Test");
            bool response = new PlayerControler().ExistPlayer(new PlayerControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            int id = new PlayerControler().GetId("Test");
            PlayerControler.Modificar(id, "Test", "n", "Test", "Test", "1111-11-11", "Test", "Test", "Test");
            bool response = new PlayerControler().HaveChange(id);
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            int id = new PlayerControler().GetId("Test");
            PlayerControler.Eliminar(id);
            bool response = new PlayerControler().ExistPlayer(id);
            Assert.AreEqual(false, response);
        }
    }
}
