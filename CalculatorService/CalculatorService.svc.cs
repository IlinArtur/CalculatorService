using ServiceA;
using ServiceB;
using System;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class CalculatorService : ICalculatorService
    {
        private IServiceA a;
        private IServiceB b;

        public CalculatorService(IServiceA a, IServiceB b)
        {
            this.a = a;
            this.b = b;
        }

        public async Task<int> GetSum()
        {
            return await a.GetData() + await b.GetData();
        }
    }
}
