using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class BackOfficeTeamsTest
    {
        [TestMethod]
        public void Register()
        {
            TeamControler.Alta("Test", "Test", "Test", "Test");
            bool response = new TeamControler().ExistTeam(new TeamControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            int id = new TeamControler().GetId("Test");
            TeamControler.Modificar(id, "Test", "n", "Test", "Test");
            bool response = new TeamControler().HaveChange(id);
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            int id = new TeamControler().GetId("Test");
            TeamControler.Eliminar(id);
            bool response = new TeamControler().ExistTeam(id);
            Assert.AreEqual(false, response);
        }
    }
}