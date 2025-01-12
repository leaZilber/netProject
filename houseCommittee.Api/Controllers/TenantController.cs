using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace houseCommittee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {

        private readonly ITenantService _tenant;
        public TenantController(ITenantService tenant)
        {
            _tenant = tenant;
        }
        // GET: api/<TenantController>
        [HttpGet]
        public Tenant GetTenantById(string id)
        {
            return _tenant.GetTenantByid(id);
        }

        // GET api/<TenantController>/5
        [HttpGet("{id}")]
        public List<Tenant> GetAllTenants()
        {
            return _tenant.GetAllTenant();
        }

        // POST api/<TenantController>
        [HttpPost]
        public void Post([FromBody] Tenant t)
        {
            _tenant.AddTenant(t);
        }

        // PUT api/<TenantController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Tenant t, string id)
        {
            _tenant.UpDateTenant(t, id);
        }

        // DELETE api/<TenantController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _tenant.DeleteTenant(id);
        }
    }
}
