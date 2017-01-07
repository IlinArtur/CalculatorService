using NUnit.Framework;

namespace CalculatorService.Tests
{
    [TestFixture]
    public class CalcultaorServiceTests
    {
        [Test]
        public void GetSum_OnePlusOne_AlwaysTwo()
        {
            var target = GetCalculatorService(1, 1);
            int result = target.GetSum().Result;

            Assert.AreEqual(2, result);
        }

        private static CalculatorService GetCalculatorService(int a, int b)
        {
            return new CalculatorService(new FakeServiceA(a), new FakeServiceB(b));
        }
    }
}
