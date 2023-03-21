using AutoMapper;
using Hostlify.API.Resource;
using Hostlify.API.Resources;
using Hostlify.Domain;
using Hostlify.Infraestructure;
using Hostlify.Infraestructure.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hostlify.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]

    public class FlatsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFlatDomain _flatDomain;

        public FlatsController(IMapper mapper, IFlatDomain flatDomain)
        {
            _mapper = mapper;
            _flatDomain = flatDomain;
        }


        // GET: api/Rooms
        [HttpGet("GetAll")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllFlats()
        {
            try
            {
                var result = await _flatDomain.getAll();
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar");
            }
            finally
            {

            }
        }

        // GET: api/Rooms/5
        [HttpGet]
        [AllowAnonymous]
        [Route("byManagerId")]
        public async Task<List<FlatResourceGet>> GetFlatsforManagerId(int managerId)
        {
            List<FlatResourceGet> flatResourceList = new List<FlatResourceGet>();
            var result = _flatDomain.getFlatsforManagerId(managerId).Result.ToArray();
            foreach (var flatResource in result)
            {
                var flat_ = new Flat();
                flat_.Id = flatResource.Id;
                flat_.flatName = flatResource.flatName;
                flat_.ManagerId = flatResource.ManagerId;
                flat_.GuestId = flatResource.GuestId;
                flat_.Initialdate = flatResource.Initialdate;
                flat_.EndDate = flatResource.EndDate;
                flat_.Price = flatResource.Price;
                flat_.DateCreated = flatResource.DateCreated;
                flat_.DateUpdated = flatResource.DateUpdated;
                flat_.IsActive = flatResource.IsActive;
                flatResourceList.Add(_mapper.Map<Flat,FlatResourceGet>(flat_));
            }
            return flatResourceList;
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("byGuestId")]
        public async Task<FlatResourceGet> GetFlatforGuestId(int guestId)
        {

                var result = await _flatDomain.getFlatforGuestId(guestId);
                var flat_ = new Flat();
                flat_.Id = result.Id;
                flat_.flatName = result.flatName;
                flat_.ManagerId = result.ManagerId;
                flat_.GuestId = result.GuestId;
                flat_.Initialdate = result.Initialdate;
                flat_.EndDate = result.EndDate;
                flat_.Price = result.Price;
                flat_.DateCreated = result.DateCreated;
                flat_.DateUpdated = result.DateUpdated;
                flat_.IsActive = result.IsActive;
                return _mapper.Map<Flat,FlatResourceGet>(flat_);
           
        }


        // POST: api/Rooms
        [HttpPost]
        [AllowAnonymous]
        [Route("Post")]
        public async Task<IActionResult> Post([FromBody] FlatResource flatInput)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("error de formato");
                }
                var flat = _mapper.Map<FlatResource, Flat>(flatInput); //Aqui hago la conversion
                var result = await _flatDomain.postFlat(flat); //Agrego await para que sea sincrona
                return StatusCode(StatusCodes.Status201Created, "room created");
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar: " + ex);
            }
            finally
            {

            }
        }

        // PUT: api/Rooms/5
        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Put(int id, [FromBody] EditFlatResource flatInput)
        {
            try
            {
                
                var result = await _flatDomain.updateFlat(id, _mapper.Map<EditFlatResource,Flat>(flatInput));
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar");
            }
            finally
            {

            }
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _flatDomain.deleteFlat(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar");
            }
        }
    }
}
