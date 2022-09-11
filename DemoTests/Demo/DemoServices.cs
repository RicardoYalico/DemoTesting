using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTests.Demo
{
    public class DemoServices : IDemoServices
    {
        private readonly IDemoRepository _demoRepository;

        public DemoServices(IDemoRepository demoRepository)
        {
            _demoRepository = demoRepository;
        }

        public async Task<IEnumerable<DemoModel>> FindAsync()
        {
            return await _demoRepository.FindAsync();
        }

        public bool getAuthById(int id)
        {
            return _demoRepository.getAuthById(id);
        }
    }
}
