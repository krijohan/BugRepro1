using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace BugRepro1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public async Task AlwaysSkip()
        {
            Assert.Inconclusive("always skip");
        }

        [TestMethod]
        public async Task AlwaysPass()
        {
            Assert.IsTrue(true);
        }

    }
}
