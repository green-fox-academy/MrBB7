using Apples;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnvironment
{
    [TestFixture]
    public class Class1
    {
        
         private Apple justAnApple;

         [SetUp]
         public void SetUp()
         {
             justAnApple = new Apple();
         }

         [TearDown]
         public void TearDown()
         {
             justAnApple = null;
         }

         [TestCase("apple")]
         public void Tester(string apple)
         {
             Assert.AreEqual(apple, justAnApple.GetApple());
         }
    }
}


