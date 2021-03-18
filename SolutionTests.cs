/*Igor Dubovets unit tests Unique email task*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_Unique_email;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Unique_email.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void NumberOfUniqueEmailAddressesTest()
        {
            string[] emails = { "bob@kuku.com", "  ben@bubu.com ", "ben+2more@bubu.com", "+@kuku.com", "  @  ",  "a22noMail", "+@a", " @a "};
            Assert.AreEqual(4, Solution.NumberOfUniqueEmailAddresses(emails));
        }

        [TestMethod()]
        public void ConvertEmailTest()
        {
            Assert.AreEqual("", Solution.ConvertEmail("  d more@d.com"));
        }
    }
}

