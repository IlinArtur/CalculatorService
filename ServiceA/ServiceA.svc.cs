using System;
using System.Threading.Tasks;

namespace ServiceA
{
    public class ServiceA : IServiceA
    {
        public async Task<int> GetData()
        {
            return await Task.FromResult(new Random(1).Next(100));
        }
    }
}
