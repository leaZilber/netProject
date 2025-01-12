using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace houseCommittee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        // GET: api/<MessageController>
        [HttpGet]
        public Message GetMessageById(string id)
        {
            return _messageService.GetMessageByid(id);
        }

        // GET api/<MessageController>/5
        [HttpGet("{id}")]
        public List<Message> GetAllMessage()
        {
            return _messageService.GetAllMessages();
        }

        // POST api/<MessageController>
        [HttpPost]
        public void Post([FromBody] Message m1)
        {
            _messageService.AddMessage(m1);
        }

        // PUT api/<MessageController>/5
        [HttpPut("{id}")]
        public void Put(string title, string target, [FromBody] Message m1)
        {
            _messageService.UpDateMessage(m1, title, target);
        }

        // DELETE api/<MessageController>/5
        [HttpDelete("{id}")]
        public void Delete(string title, string target)
        {
            _messageService.DeleteMessage(title, target);
        }
    }
}
