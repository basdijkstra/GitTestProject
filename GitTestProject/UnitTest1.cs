namespace GitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // S omething
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void AnotherTest()
        {
            Assert.Fail();
        }
    }
}