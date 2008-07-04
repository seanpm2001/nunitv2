using NUnit.Framework;
using NUnit.TestData;
using NUnit.TestUtilities;
using System.Collections;

namespace NUnit.Core.Tests
{
    [TestFixture]
    public class FactoryTests
    {
        [Test, Factory("StaticProperty")]
        public void FactoryCanBeStaticProperty(string factory)
        {
            Assert.AreEqual("StaticProperty", factory);
        }

        static IEnumerable StaticProperty
        {
            get { return new object[] { new object[] { "StaticProperty" } }; }
        }

        [Test, Factory("InstanceProperty")]
        public void FactoryCanBeInstanceProperty(string factory)
        {
            Assert.AreEqual("InstanceProperty", factory);
        }

        IEnumerable InstanceProperty
        {
            get { return new object[] { new object[] { "InstanceProperty" } }; }
        }

        [Test, Factory("StaticMethod")]
        public void FactoryCanBeStaticMethod(string factory)
        {
            Assert.AreEqual("StaticMethod", factory);
        }

        static IEnumerable StaticMethod()
        {
            return new object[] { new object[] { "StaticMethod" } };
        }

        [Test, Factory("InstanceMethod")]
        public void FactoryCanBeInstanceMethod(string factory)
        {
            Assert.AreEqual("InstanceMethod", factory);
        }

        IEnumerable InstanceMethod()
        {
            return new object[] { new object[] { "InstanceMethod" } };
        }

        [Test, Factory("StaticField")]
        public void FactoryCanBeStaticField(string factory)
        {
            Assert.AreEqual("StaticField", factory);
        }

        static object[] StaticField =
            { new object[] { "StaticField" } };

        [Test, Factory("InstanceField")]
        public void FactoryCanBeInstanceField(string factory)
        {
            Assert.AreEqual("InstanceField", factory);
        }

        static object[] InstanceField =
            { new object[] { "InstanceField" } };

        [Test, Factory("CheckCurrentDirectory")]
        public void FactoryIsInvokedWithCorrectCurrentDirectory(bool isOK)
        {
            Assert.That(isOK);
        }

        [Test, Factory("MyData")]
        public void FactoryMayReturnArgumentsAsObjectArray(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [Test, Factory("MyIntData")]
        public void FactoryMayReturnArgumentsAsIntArray(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [Test, Factory("EvenNumbers")]
        public void FactoryMayReturnSinglePrimitiveArgumentAlone(int n)
        {
            Assert.AreEqual(0, n % 2);
        }

        [Test, Factory("Params")]
        public int FactoryMayReturnArgumentsAsParamSet(int n, int d)
        {
            return n / d;
        }

        [Test]
        [Factory("MyData,MoreData")]
        [TestCase(12, 0, 0, ExpectedException = typeof(System.DivideByZeroException))]
        public void TestMayUseMultipleFactoriesOnOneAttribute(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [Test]
        [Factory("MyData")]
        [Factory("MoreData")]
        [TestCase(12, 0, 0, ExpectedException = typeof(System.DivideByZeroException))]
        public void TestMayUseMultipleFactoryAttributes(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [Test, Factory(typeof(DivideDataProvider), "HereIsTheData")]
        public void FactoryMayBeInAnotherClass(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [Test, Factory]
        public void CanLocateCompatibleFactories_SameClass(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [Test, Factory(typeof(DivideDataProvider))]
        public void CanLocateCompatibleFactories_OtherClass(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [TestCaseFactory(typeof(int), typeof(int), typeof(int))]
        static object[] MyData = new object[] {
            new object[] { 12, 3, 4 },
            new object[] { 12, 4, 3 },
            new object[] { 12, 6, 2 } };

        static object[] MyIntData = new object[] {
            new int[] { 12, 3, 4 },
            new int[] { 12, 4, 3 },
            new int[] { 12, 6, 2 } };

        [TestCaseFactory(typeof(int))]
        static int[] EvenNumbers = new int[] { 2, 4, 6, 8 };

        private static IEnumerable CheckCurrentDirectory
        {
            get
            {
                return new object[] { new object[] { System.IO.File.Exists("nunit.core.tests.dll") } };
            }
        }

        [TestCaseFactory(typeof(int), typeof(int), typeof(int))]
        static object[] MoreData = new object[] {
            new object[] { 12, 1, 12 },
            new object[] { 12, 2, 6 } };

        static object[] Params = new object[] {
            new TestCaseData(24, 3).Returns(8),
            new TestCaseData(24, 2).Returns(12) };

        private class DivideDataProvider
        {
            [TestCaseFactory(typeof(int), typeof(int), typeof(int))]
            public static IEnumerable HereIsTheData
            {
                get
                {
#if NET_2_0
                    yield return new TestCaseData(0, 0, 0)
                        .WithName("ThisOneShouldThow")
                        .WithDescription("Demonstrates use of ExpectedException")
                        .Throws(typeof(System.DivideByZeroException));
                    yield return new object[] { 100, 20, 5 };
                    yield return new object[] { 100, 4, 25 };
#else
                    ArrayList list = new ArrayList();
                    list.Add(
                        new TestCaseData( 0, 0, 0)
                            .WithName("ThisOneShouldThow")
                            .WithDescription("Demonstrates use of ExpectedException")
                            .Throws( typeof (System.DivideByZeroException) ));
                    list.Add(new object[] { 100, 20, 5 });
                    list.Add(new object[] {100, 4, 25});
                    return list;
#endif
                }
            }
        }
    }
}
