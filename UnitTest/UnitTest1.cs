using AwsApp.Controllers;

namespace UnitTest
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
            var test = new Test();
            var result = test.Compare("1", "1");
            Assert.IsTrue(result == 0);
        }
    }
}