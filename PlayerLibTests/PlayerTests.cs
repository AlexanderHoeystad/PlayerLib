using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLib.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void A_ToStringTest()
        {
            Player player = new Player();
            player.Id = 1;
            player.FirstName = "Marcus";
            player.LastName = "Rashford";
            player.Number = 10;
            player.Position = "Forward";
            string expected = "1 Marcus Rashford (10) - Forward";
            string actual = player.ToString();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void B_ValidateFirstNameLengthTest()
        {
            Player player = new Player();
            player.FirstName = "Ma";
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateFirstNameLength());

        }

        [TestMethod()]
        public void C_ValidateLastNameLengthTest()
        {
            Player player = new Player();
            player.LastName = "Ra";
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateLastNameLength());
        }

        [TestMethod()]
        public void D_ValidateNumberTest()
        {
            Player player = new Player();
            player.Number = 100;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateNumber());

        }

        [TestMethod()]
        public void E_ValidatePositionTest()
        {
            Player player = new Player();
            player.Position = "Striker";
            Assert.ThrowsException<ArgumentException>(() => player.ValidatePosition());
        }
    }
}