using System;
using CapaLogica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BackOfficeUserTest
    {
        [TestMethod]
        public void Register() => UserControler.Alta("Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", 11111111, "Test", "Test");
        [TestMethod]
        public void RegisterFail() => UserControler.Alta("Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", 11111111, "Test", "Test");
        [TestMethod]
        public void Modify() => UserControler.Modificar(new UserControler().GetId("Test"), "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", 11111111, "Test", "Test");
        [TestMethod]
        public void ModifyFail() => UserControler.Modificar(0, "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", 11111111, "Test", "Test");
        [TestMethod]
        public void Delete() => UserControler.Eliminar(new UserControler().GetId("Test"));
        [TestMethod]
        public void DeleteFail() => UserControler.Eliminar(0);
    }
}
