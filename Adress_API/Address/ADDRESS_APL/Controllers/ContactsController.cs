using ADDRESS_BAL.Services;
using ADDRESS_DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations.Rules;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ADDRESS_APL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        protected readonly ContactService contactService;

        //Inyección de dependencia
        public ContactsController() => contactService = new ContactService();

        // GET: api/<ContactsController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            List<Contact> contacts = contactService.getContacts();
            return contacts;
        }

        // GET api/<ContactsController>/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            Contact contact = contactService.getContactById(id);
            return contact;
        }

        // POST api/<ContactsController>
        [HttpPost]
        public void Post([FromBody] Contact contact)
        {
            contactService.postNewContact(contact);
        }

        // PUT api/<ContactsController>/5
        [HttpPut]
        public void Put([FromBody] Contact value)
        {
            contactService.updateContact(value);
        }

        // DELETE api/<ContactsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            contactService.deleteContact(id);
        }
    }
}
