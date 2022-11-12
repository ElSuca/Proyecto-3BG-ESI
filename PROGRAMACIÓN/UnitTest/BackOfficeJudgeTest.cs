using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficeJudgeTest
    {
        [TestMethod]
        public void Register()
        {
            JudgeControler.Alta("Test", "Test", "Test", "Test", "Test", "Test");
            bool response = new JudgeControler().ExistJudge("Test");
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            JudgeControler.Modify(new JudgeControler().GetId("Test"), "Test", "Test", "Test", "n", "Test", "Test");
            bool response = new JudgeControler().HaveChange(new JudgeControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            JudgeControler.Delete(new JudgeControler().GetId("Test"));
            bool response = new JudgeControler().ExistJudge("Test");
            Assert.AreEqual(false, response);
        }
    }
}
