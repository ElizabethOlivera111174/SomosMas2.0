using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Interfaces;
using Project.Domain.DTOs.ContactsDTOs;
using Project.Domain.Helpers.Pagination;
using System;
using System.Threading.Tasks;

namespace Project.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        #region Objects and Constructor
        private readonly IContactsServices _contactsServices;
        public ContactsController(IContactsServices contactsServices)
        {
            _contactsServices = contactsServices;
        }
        #endregion

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<ActionResult<PaginationDTO<ContactDTO>>> GetAll([FromQuery] int page)
        {
            try
            {
                string route = Request.Path.Value.ToString();
                var request = await _contactsServices.GetByPage(route, page);

                if (request == null) return BadRequest("No se ha encontrado la solicitud");

                return Ok(request);
            }
            catch (Exception result)
            {
                return BadRequest(result.Message);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDTO>> Get(int id)
        {
            try
            {
                var test= _contactsServices.EntityExists(id);
                if (test==false)
                    return NotFound();

                var contact = await _contactsServices.GetById(id);
                return Ok(contact);
            }
            catch (Exception result)
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromForm] ContactInsertDTO contactInsertDTO)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("Los datos no son validos.");

                var request = await _contactsServices.Insert(contactInsertDTO);

                if (request.HasErrors == true)
                    return BadRequest("No se ha podido completar la solicitud");

                return Ok(request);
            }
            catch (Exception result)
            {
                return BadRequest(result.Message);
            }
        }
    }
}
