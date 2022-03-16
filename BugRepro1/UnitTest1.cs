using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace BugRepro1
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void ForceStackTraceHelperInitialization(TestContext context)
        {
            Type? stackTraceHelperType = null;
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var tryGetType = assembly.GetType("Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.Execution.StackTraceHelper");
                if (tryGetType != null)
                {
                    stackTraceHelperType = tryGetType;
                    break;
                }
            }
            PropertyInfo? propertyInfo = stackTraceHelperType.GetProperty("TypeToBeExcluded", BindingFlags.NonPublic | BindingFlags.Static);
            Console.WriteLine($"{propertyInfo.GetValue(null)}");
        }

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
