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
    public class BackOfficeFamilyTest
    {
        [TestMethod]
        public void Register()
        {
            FamilyControler.Alta("Test", "Test", "Test", "Test");
            FamilyControler.Alta("Test2", "Test2", "Test2", "Test2");
            FamilyControler.AltaParents(new FamilyControler().GetId("Test"),new FamilyControler().GetId("Test2"), "Test", "Test");
            bool response = new FamilyControler().ExistFamilty("Test");
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Modify()
        {
            FamilyControler.Modificar(new FamilyControler().GetId("Test"), "Test", "Test", "Test", "n");
            bool response = new FamilyControler().HaveChange(new FamilyControler().GetId("Test"));
            Assert.AreEqual(true, response);
        }
        [TestMethod]
        public void Delete()
        {
            FamilyControler.Eliminar(new FamilyControler().GetId("Test"));
            bool response = new FamilyControler().ExistFamilty("Test");
            Assert.AreEqual(false, response);
        }
    }
}
