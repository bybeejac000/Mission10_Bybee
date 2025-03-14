using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10.Data;
using Mission10.Models;

namespace Mission10.Controllers
{
    //Create API and bring in interface

    [Route("api/[controller]")]
    [ApiController]
    public class BowlingAPI : ControllerBase
    {
        public IBowlingRepo _repo;
        public BowlingAPI(IBowlingRepo temp)
        {
            _repo = temp;
        }

        //Define method and call the interface method
        [HttpGet(Name = "GetBowlers")]
        public List<APIReturn> Get()
        {
            var bowlers = _repo.AllData();

            return bowlers;
        }
    }

        
        
       


}
