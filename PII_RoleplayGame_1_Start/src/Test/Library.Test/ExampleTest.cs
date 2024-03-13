using NUnit.Framework;

namespace Test.Library
{
    public class ExampleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void SupiriorMaxHealth()
        {
            string input = MaxHealth>100;
            string expected = MaxHealth==100;
            string output = MaxHealth==100;
            Assert.AreEqual(output, expected);
        }
    }
}