using ServiceB;
using System.Threading.Tasks;

namespace CalculatorService.Tests
{
    class FakeServiceB : IServiceB
    {
        private readonly int value;

        public FakeServiceB(int value)
        {
            this.value = value;
        }

        public Task<int> GetData()
        {
            return Task.FromResult(value);
        }
    }
}
