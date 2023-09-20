/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using students.Data;
using students.Models;
using students.Repositories;
using phones.Controllers;
using System.Security.AccessControl;
using phones.Models;
using Microsoft.JSInterop;

namespace phones.Controllers
{
    [Route("api/Phones")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private readonly RepositoryContext _context;
        public PhonesController(RepositoryContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllPhones()
        {

            try
            {
                var phones = _context.Phones.ToList();


                return Ok(phones);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpGet("{id:int}")]
        public IActionResult GetOnePhone([FromRoute(Name = "id")] int id)
        {
            try
            {
                var phone = _context
                 .Phones
                 .Where(s => s.Id.Equals(id))
                 .SingleOrDefault();

                if (phone == null)
                {
                    return NotFound();
                }
                return Ok(phone);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        public IActionResult CreateOnePhone([FromBody] Phone phone)
        {
            try
            {
                if (phone is null)
                    return BadRequest();


               foreach (var x in _context.Phones)
                {
                    if (phone.Phonenumber == x.Phonenumber)
                    {
                        return NotFound(new
                        {
                            StatusCode = 404,
                            message = $"Böyle bir numaraya sahip başka birisi var."
                        }
                            );
                    }
                }
            

                foreach (var number in _context.Phones)
                {
                    if (number.StudentId == phone.StudentId)
                    {
                        if (number.Default == true && phone.Default == true)
                        {
                            return NotFound(new
                            {
                                StatusCode = 404,
                                message = $"Zaten bu kişinin öncelikli numarası var."
                            });
                        }
                    }

                }



                _context.Phones.Add(phone);
                _context.SaveChanges();
                return StatusCode(201, phone);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOnePhone([FromRoute(Name = "id")] int id, [FromBody] Phone phone)
        {
            try
            {
                var entity = _context
                .Phones
                .Where(s => s.Id.Equals(id))
                .SingleOrDefault();

                if (entity == null)
                    return NotFound();


                if (id != phone.Id)
                    return BadRequest();


                entity.Default = phone.Default;
                entity.StudentId = phone.StudentId;
                entity.Phonenumber = phone.Phonenumber;

                _context.Phones.Update(entity);

                _context.SaveChanges();

                return Ok(phone);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteOnePhone([FromRoute(Name = "id")] int id)
        {
            try
            {
                var entitiy = _context
                .Phones
                .Where(s => s.Id.Equals(id))
                .SingleOrDefault();

                if (entitiy is null)
                    return NotFound(new
                    {
                        StatusCode = 404,
                        message = $"Girilen id: {id}, Böyle bir id Bulunamadı."
                    });

                _context.Phones.Remove(entitiy);
                _context.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }

}
*/