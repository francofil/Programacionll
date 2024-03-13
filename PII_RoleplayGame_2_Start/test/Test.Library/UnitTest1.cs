using NUnit.Framework;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Health()
        {
            bool input = Health>100;
            bool expected = Health==100;
            bool output = Health==100;
            Assert.AreEqual(output, expected);
        }
    }
}