using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerHandsApp;

namespace Test
{
    [TestFixture]
    public class Test
    {

        Poker poker = new Poker();

        [Test]
        public void CheckOfSplitInputIs12()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            bool output = poker.CheckInputLength12(input);
            Assert.AreEqual(true,  output);
        }

        [Test]
        public void GetHands()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            
        }
    }
}
