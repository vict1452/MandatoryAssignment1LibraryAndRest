using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballRESTService.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignment;

namespace FootballRESTService.Managers.Tests
{
    [TestClass()]
    public class FootballPlayersManagerTests
    {
        FootballPlayersManager _manager = new FootballPlayersManager();

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.AreEqual(4, _manager.GetAll().Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.AreEqual("Victor", _manager.GetById(1).Name);
        }

        [TestMethod()]
        public void AddTest()
        {
            _manager.Add(new FootballPlayer());
            Assert.AreEqual(5, _manager.GetAll().Count());
        }

        [TestMethod()]
        public void DeleteTest()
        {
            _manager.Delete(5);
            Assert.AreEqual(4, _manager.GetAll().Count());
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.AreEqual("Victor", _manager.GetById(1).Name);
            _manager.Update(1, new FootballPlayer() { Name = "Søren" });
            Assert.AreEqual("Søren", _manager.GetById(1).Name);
        }
    }
}