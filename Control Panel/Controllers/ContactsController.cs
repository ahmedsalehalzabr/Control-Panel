using Control_Panel.Data;
using Control_Panel.Data.Models;
using Control_Panel.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Control_Panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ContactsController(AppDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public IActionResult GetAllContact()
        {
            var contacts = _db.Contacts.ToList();
            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult AddContact(AddRequestDTO request)
        {
            var domainModelContact = new Contact
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Favorite = request.Favorite,
            };
            _db.Contacts.Add(domainModelContact);
            _db.SaveChanges();
            return Ok(domainModelContact);

        }
    }
}
