using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        FootballPlayer playerOk = new FootballPlayer() {Id = 1, Name = "Søren Godmand", Age = 28, ShirtNumber = 35 };
        FootballPlayer playerNoName = new FootballPlayer() {Id = 2, Age = 24, ShirtNumber = 35 };
        FootballPlayer playerShortName = new FootballPlayer() {Id = 3, Name = "X", Age = 45, ShirtNumber = 35 };
        FootballPlayer playerBadAge = new FootballPlayer() { Id = 4, Name = "Levi Jensen", Age = 0, ShirtNumber = 35 };
        FootballPlayer playerLowShirtNumber = new FootballPlayer() { Id = 5, Name = "Peter Flemmingsen", Age = 50, ShirtNumber = 0 };
        FootballPlayer playerHighShirtNumber = new FootballPlayer() { Id = 6, Name = "Tom Timsen", Age = 53, ShirtNumber = 100 };

        [TestMethod()]
        public void ValidateNameTest()
        {
            playerOk.ValidateName();
            Assert.ThrowsException<ArgumentException>(() => playerNoName.ValidateName());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShortName.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            playerOk.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerBadAge.ValidateAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            playerOk.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerLowShirtNumber.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerHighShirtNumber.ValidateShirtNumber());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            playerOk.Validate();
        }
    }
}