using DemoTests.Demo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoTests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : Controller
    {

        private readonly IDemoServices _demoServices;

        public DemoController(IDemoServices demoServices)
        {
            _demoServices = demoServices;
        }



        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            var result = _demoServices.FindAsync();
            // var resource = await _districtService.ListAsync();
            // var districts = _mapper.Map<IEnumerable<District>, IEnumerable<DistrictResource>>(resource);
            // return districts;
            return Ok(await result);
        }

        [HttpPost]
        public async Task<IEnumerable<DemoModel>> ListAsync2()
        {
            var result = await _demoServices.FindAsync();
            // var resource = await _districtService.ListAsync();
            // var districts = _mapper.Map<IEnumerable<District>, IEnumerable<DistrictResource>>(resource);
            // return districts;
            return result;
        }

        [HttpGet("{id:int}")]
        public bool getAuthById(int id)
        {
            var result = _demoServices.getAuthById(id);
            // var resource = await _districtService.ListAsync();
            // var districts = _mapper.Map<IEnumerable<District>, IEnumerable<DistrictResource>>(resource);
            // return districts;
            return result;
        }
    }
}
