using ServiceA;
using System.Threading.Tasks;

namespace CalculatorService.Tests
{
    class FakeServiceA: IServiceA
    {
        private readonly int value;

        public FakeServiceA(int value)
        {
            this.value = value;
        }

        public Task<int> GetData()
        {
            return Task.FromResult(value);
        }
    }
}
