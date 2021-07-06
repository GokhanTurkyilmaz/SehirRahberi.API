using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SehirRahberi.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRahberi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private DataContext _datacontext;
        public ValuesController(DataContext dataContext)
        {
            _datacontext = dataContext;
        }
        //Get api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _datacontext.Values.ToListAsync();
            return Ok(values);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _datacontext.Values.FirstOrDefaultAsync(v=>v.Id==id);
            return Ok(value);
        }
    }
}
