using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieDatabaseV04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseV04.Tests
{
    [TestClass()]
    public class CheckTests
    {
        [TestMethod()]
        public void checkNameIsNoEmptyTest()
        {
            Check cs = new Check();
            Assert.IsFalse(cs.checkNameIsNoEmpty(""));
        }

        [TestMethod()]
        public void checkPasswordInNotEmptyTest()
        {
            Check cs = new Check();
            Assert.IsTrue(cs.checkPasswordInNotEmpty("any"));
        }
    }
}