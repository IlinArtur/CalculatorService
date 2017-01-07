using System;
using System.Threading.Tasks;

namespace ServiceB
{
    public class ServiceB : IServiceB
    {
        public async Task<int> GetData()
        {
            return await Task.FromResult(new Random(101).Next(200));
        }
    }
}
