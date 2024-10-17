using Microsoft.VisualStudio.TestTools.UnitTesting;
using I1SD_Toets1_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I1SD_Toets1_Start.Tests
{
    [TestClass()]
    public class MyFunctionsTests
    {
        [TestMethod()]
        public void HalloTest()
        {
            Assert.AreEqual("Welkom bij deze ASP-NET / C# toets", MyFunctions.Hallo());
        }
    }
}