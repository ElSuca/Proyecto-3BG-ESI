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
    class BackofficePlayerTest
    {
        [TestMethod]
        public void Register() => PlayerControler.Alta("Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test");
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
