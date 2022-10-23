using CapaLoogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficeManagerTest
    {
        [TestMethod]
        public void Register()
        {
            bool response;
            SportControler.Alta("Test3", "Test3");
            response = new SportControler().ExistSport(new SportControler().GetId("Test3"));

            if (response)
            {
                AsociationControler.Alta("Test2", "Test2", "Test2", "Test2", 1111, "Test2", "Test2", "1111-11-11", "1111-11-11", new SportControler().GetId("Test3"), "Test2", 1);
                response = new AsociationControler().ExistAsociation(new AsociationControler().GetId("Test2"));
                if(response)
                {
                    ManagerControler.Alta("Test", "Test", "Test", "Test", "Test", "Test", "Test", new AsociationControler().GetId("Test2"), "11-11-1111", "11-11-1111");
                    response = new ManagerControler().ExistManager(new ManagerControler().GetId("Test"));
                    Assert.AreEqual(true, response);
                }
                else Assert.Fail();
            }
            else Assert.Fail();


           
        }
        [TestMethod]
        public void Modify()
        {
            bool response;
            response = new SportControler().ExistSport(new SportControler().GetId("Test3"));
            if (response)
            {
                response = new AsociationControler().ExistAsociation(new AsociationControler().GetId("Test2"));
                if (response)
                {
                    int id = new ManagerControler().GetId("Test");
                    ManagerControler.Modificar(id, "Test", "Test", "Test", "Test", "Test", "n", "Test");
                    response = new ManagerControler().HaveChange(id);
                    Assert.AreEqual(true, response);
                }
                else Assert.Fail();
            }
            else Assert.Fail();
        }
        [TestMethod]
        public void Delete()
        {
            bool response;
            response = new SportControler().ExistSport(new SportControler().GetId("Test3"));
            if (response)
            {
                response = new AsociationControler().ExistAsociation(new AsociationControler().GetId("Test2"));
                if (response)
                {
                    int id = new ManagerControler().GetId("Test"); 
                    ManagerControler.Eliminar(id);
                    AsociationControler.Eliminar(new AsociationControler().GetId("Test2"));
                    SportControler.Delete(new SportControler().GetId("Test3"));
                    response = new ManagerControler().ExistManager(id);
                    Assert.AreEqual(false, response);
                }
                else Assert.Fail();
            }
            else Assert.Fail();
        }
    }
}
