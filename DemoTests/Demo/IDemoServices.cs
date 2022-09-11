using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTests.Demo
{
    public interface IDemoServices
    {
        public Task<IEnumerable<DemoModel>> FindAsync();

        public bool getAuthById(int id);

    }
}
