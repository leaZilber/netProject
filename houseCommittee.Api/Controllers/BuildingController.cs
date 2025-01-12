using houseCommittee.core.IService;
using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;
using Microsoft.AspNetCore.Mvc;

namespace houseCommittee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _building;
        public BuildingController(IBuildingService building)
        {
            _building= building;
        }
        // GET: api/<BuildingController>
        [HttpGet("{id}")]
        public Building GetBuildingById(int id)
        {
           return _building.GetBuildingByid(id);         
        }

        // GET api/<BuildingController>/5
        [HttpGet]
        public List<Building> GetAllBuildings()
        {
           return _building.GetAllBuildings();
        }

        // POST api/<BuildingController>
        [HttpPost]
        public void Post([FromBody] Building newBuild)
        {
          _building.AddBuilding(newBuild);
        }

        // PUT api/<BuildingController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Building b,int id)
        {
             _building.UpDateBuild(b,id);
        }

        // DELETE api/<BuildingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _building.DeleteBuilding(id);
        }
    }
}
