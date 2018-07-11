using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum;

namespace Test
{
    [TestFixture]
    public class Test
    {
        [TestCase]
        public void ShouldBeTheSame()
        {
            TestSum justAList = new TestSum();
            List<int> testNumbers = new List<int>() { 10, 10, 10, 10 };
            Assert.AreEqual(justAList.Summerizer(testNumbers), 40);
        }
    }
}

