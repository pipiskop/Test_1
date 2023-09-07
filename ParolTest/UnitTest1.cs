using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Parol
{
    [TestClass]
    public class Check
    {
        [TestMethod]
        public void CheckPassword1()
        {
            string TestLine = "Stas@2005";
            int Result = 5;
            ParolTest.Parol test = new ParolTest.Parol();
            int fact = test.Check(TestLine);
            Assert.AreEqual(Result, fact);
        }
        [TestMethod]
        public void CheckPassword2()
        {
            string TestLine = "Stas2005";
            int Result = 4;
            ParolTest.Parol test = new ParolTest.Parol();
            int fact = test.Check(TestLine);
            Assert.AreEqual(Result, fact);
        }
        [TestMethod]
        public void CheckPassword3()
        {
            string TestLine = "StasStas";
            int Result = 3;
            ParolTest.Parol test = new ParolTest.Parol();
            int fact = test.Check(TestLine);

            Assert.AreEqual(Result, fact);
        }
        [TestMethod]
        public void CheckPassword4()
        {
            string TestLine = "STASSTAS";
            int Result = 2;
            ParolTest.Parol test = new ParolTest.Parol();
            int fact = test.Check(TestLine);

            Assert.AreEqual(Result, fact);
        }
        [TestMethod]
        public void CheckPassword5()
        {
            string TestLine = "!@#$%";
            int Result = 1;
            ParolTest.Parol test = new ParolTest.Parol();
            int fact = test.Check(TestLine);

            Assert.AreEqual(Result, fact);
        }
        [TestMethod]
        public void CheckPassword0()
        {
            string TestLine = "";
            int Result = 0;
            ParolTest.Parol test = new ParolTest.Parol();
            int fact = test.Check(TestLine);
            Assert.AreEqual(Result, fact);
        }
    }
}
