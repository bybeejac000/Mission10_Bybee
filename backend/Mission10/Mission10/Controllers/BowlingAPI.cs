using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10.Data;
using Mission10.Models;

namespace Mission10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingAPI : ControllerBase
    {
        public IBowlingRepo _repo;
        public BowlingAPI(IBowlingRepo temp)
        {
            _repo = temp;
        }


        [HttpGet(Name = "GetBowlers")]
        public List<APIReturn> Get()
        {
            var bowlers = _repo.AllData();

            return bowlers;
        }
    }

        
        
       


}
