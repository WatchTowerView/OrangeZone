﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SajUnitTest;

namespace SajTesting  //Comment #1
{
    [TestClass]
    public class UnitTest1  //Comment #2
    {
        [TestMethod]
        public void TestMethod1()
        {
            AbCStart bab = new AbCStart();

            var cc = 100;
            //Assert.AreEqual(cc , bab.toto);
        }


        [TestMethod]
        public void SajaIsRight()
        {
            AbCStart cac = new AbCStart();

            double  dd = 30;

            var cc = dd + 30;

            dd = dd + 30;
            Assert.AreEqual(dd, cc); // cac.toto);


        }
    }
}