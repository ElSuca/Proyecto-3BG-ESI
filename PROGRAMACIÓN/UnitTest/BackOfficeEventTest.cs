using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class BackOfficeEventTest
    {
        [TestMethod]
        public void Register()
        {
            StageControler.Alta("Test2","Test2","Test2", 2, "Test2", "Test2");
            FamilyControler.Alta("Test2", "Test2", "Test2", "Test2");
            EventControler.Alta("Test", "1111-11-11", "1111-11-11", new StageControler().GetId("Test2"), 1, "Test2", new FamilyControler().GetId("Test2"));
            EventControler.Alta("Test2", "2222-12-22", "2222-12-22", new StageControler().GetId("Test2"), 2, "Test2", new FamilyControler().GetId("Test2"));
            EventControler.AltaParents(new EventControler().GetId("Test"),"Test", "Test", "Test");
            bool response = new EventControler().ExistEvent("Test");
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            EventControler.Modificar(new EventControler().GetId("Test"), "Test", "2022-10-27", "1111-11-11", new StageControler().GetId("Test2"), 1, "Test");
            bool response = new EventControler().HaveChange(new EventControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            EventControler.Delete(new EventControler().GetId("Test"));
            EventControler.DeleteTime(new EventControler().GetId("Test"));
            bool response = new EventControler().ExistEvent("Test");
            Assert.AreEqual(false, response);
        }
    }
}
