using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShootAssignment_Amandeep.Classes;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            gamePlay gm = new gamePlay();
            var myNum = gm.RndNumber();
            if (myNum > 1)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
