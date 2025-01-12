using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseCommitteeController : ControllerBase
    {
       private readonly IHouseCommitteeService _houseCommitteeService;
        public HouseCommitteeController(IHouseCommitteeService houseCommitteeService)
        {
            _houseCommitteeService = houseCommitteeService;
        }

        [HttpGet]
        public HouseCommittee GetHouseComById(string id)
        {
           return _houseCommitteeService.GetHouseComByid(id);
        }

        // GET api/<HouseCommitteeController>/5
        [HttpGet("{id}")]
        public List<HouseCommittee> GetAllHouseCom()
        {
           return _houseCommitteeService.GetAllHouseCom();
        }

        // POST api/<HouseCommitteeController>
        [HttpPost]
        public void Post([FromBody] HouseCommittee h2)
        {
           _houseCommitteeService.AddHouseCom(h2);
        }

        // PUT api/<HouseCommitteeController>/5
        [HttpPut("{id}")]
        public void Put( string phone,[FromBody] HouseCommittee h1)
        {
            _houseCommitteeService.UpDateHouseCom(h1,phone);
        }

        // DELETE api/<HouseCommitteeController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
           _houseCommitteeService.DeleteHouseCom(id);
        }
    }
}
