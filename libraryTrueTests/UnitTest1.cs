using System;
using libraryTrue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace libraryTrueTests
{
    [TestClass]
    public class UnitTest1
    {

        static string parol = "3QWWWWWWwe123";
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new  Class1();
            bool actual = c.cifri(parol);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Class1 c = new Class1();
            bool actual = c.UpReg(parol);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Class1 c = new Class1();
            bool actual = c.Lenght(parol);
            Assert.AreEqual(true, actual);
        }
    }
}
