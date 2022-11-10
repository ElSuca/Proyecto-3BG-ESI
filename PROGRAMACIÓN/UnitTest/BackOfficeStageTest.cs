using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    class BackOfficeStageTest
    {
        [TestMethod]
        public void Register()
        {
            StageControler.Alta("Test", "Test", "Test", 11111, "Test", "Test");
            bool response = new StageControler().ExistStage(new StageControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            int id = new StageControler().GetId("Test");
            StageControler.Modify(id, "Test", "n", "Test", 11111, "Test", "Test");
            bool response = new StageControler().HaveChange(id);
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            int id = new StageControler().GetId("Test");
            StageControler.Delete(id);
            bool response = new StageControler().ExistStage(id);
            Assert.AreEqual(false, response);
        }
    }
}
