//using houseCommittee.core.RepositoriesI;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace WebApplication1.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ServiceProviderController : ControllerBase
//    {

//        private readonly IServiceProviderService _sericeProvider;
//        public ServiceProviderController(IServiceProviderService sericeProvider)
//        {
//            _sericeProvider = sericeProvider;
//        }
//        // GET: api/<ServiceProviderController>
//        [HttpGet]
//        public ServiceProvider GetServiceProvById(string id)
//        {
//            return _sericeProvider.GetServiceProvByid(id);
//        }

//        // GET api/<ServiceProviderController>/5
//        [HttpGet("{id}")]
//        public List<ServiceProvider> GetAllServicePro()
//        {
//            return _sericeProvider.GetAllServiceProv();
//        }

//        // POST api/<ServiceProviderController>
//        [HttpPost]
//        public void Post([FromBody] ServiceProvider ser)
//        {
//            _sericeProvider.AddServiceProv(ser);
//        }

//        // PUT api/<ServiceProviderController>/5
//        [HttpPut("{id}")]
//        public void Put(string id, [FromBody] ServiceProvider ser )
//        {
//          _sericeProvider.UpDateServiceProv(ser,id);
//        }

//        // DELETE api/<ServiceProviderController>/5
//        [HttpDelete("{id}")]
//        public void Delete(string id)
//        {
//           _sericeProvider.DeleteServiceProv(id);
//        }
//    }
//}
