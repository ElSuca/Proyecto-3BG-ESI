﻿using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficActionTest
    {
        [TestMethod]
        public void Register()
        {
            
            TeamControler.Alta("Test2", "Test2", "Test2","Test2");
            PlayerControler.Alta("Test2", "Test2", "Test2", "Test2", "1111/11/11 10:10", "Test2", "Test2", "Test2");
            StageControler.Alta("Test2", "Test2", "Test2", 1, "Test2", "Test2");
            FamilyControler.Alta("Test2", "Test2", "Test2", "Test2");
            EventControler.Alta("Test2", "1111-11-11", "1111-11-11", new StageControler().GetId("Test2"), 1, "Test2",new FamilyControler().GetId("Test2"));
         
            ActionControler.Alta(new TeamControler().GetId("Test2"),new PlayerControler().GetId("Test2"),new EventControler().GetIdTime(1),1, "Test", "Test", "1111-11-11", "Test","Test2");
            bool response = new ActionControler().ExistAction(new ActionControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            ActionControler.Modify(new ActionControler().GetId("Test"), new TeamControler().GetId("Test2"), new PlayerControler().GetId("Test2"), new EventControler().GetIdTime(1), 1, "n", "Test", "1111-11-11", "Test");
            bool response = new ActionControler().HaveChange(new ActionControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            int id2;
            int id = new ActionControler().GetId("Test");
            ActionControler.Delete(id);
            id2 = new EventControler().GetId("Test2");
            EventControler.Delete(id2);
            id2 = new StageControler().GetId("Test2");
            StageControler.Delete(id2);

            id2 = new PlayerControler().GetId("Test2");
            PlayerControler.Delete(id2);
            id2 = new TeamControler().GetId("Test2");
            TeamControler.Delete(id2);
            bool response = new ActionControler().ExistAction(id);
            Assert.AreEqual(false, response);
        }
    }
}
