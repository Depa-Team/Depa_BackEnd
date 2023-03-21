using System.Net.Mime;
using AutoMapper;
using Hostlify.API.Filter;
using Hostlify.API.Resource;
using Hostlify.API.Resources;
using Hostlify.Domain;
using Hostlify.Infraestructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hostlify.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    public class PlansController : ControllerBase
    {
        private readonly IPlanDomain _planDomain;//Inyeccion
        private readonly IMapper _mapper;
        
        public PlansController(IPlanDomain planDomain,IMapper mapper)
        {
            _planDomain = planDomain;
            _mapper = mapper;
        }
        
        [HttpPost]
        [AllowAnonymous]
        [Route("Post")]
        public async Task<IActionResult> Post([FromBody] PlanResource planInput)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("error de formato");
                }

                var category = _mapper.Map<PlanResource, Plan>(planInput); //Aqui hago la conversion
                var result = await _planDomain.post(category); //Agrego await para que sea sincrona
                return StatusCode(StatusCodes.Status201Created, "category created");
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar: "+ex);
            }
            finally
            {
                
            }
        }
        
        // GET: api/Plans
        [HttpGet]
        [AllowAnonymous]
        public async Task<List<PlanResourceGet>> Get()
        {
            List<PlanResourceGet> planResourceList = new List<PlanResourceGet>();
            var result = _planDomain.getAll().Result.ToArray();
            foreach (var planResource in result)
            {
                var plan_ = new Plan();
                plan_.Name = planResource.Name;
                plan_.Id = planResource.Id;
                plan_.Rooms = planResource.Rooms;
                plan_.Price = planResource.Price;
                plan_.DateCreated = planResource.DateCreated;
                plan_.DateUpdated = planResource.DateUpdated;
                plan_.IsActive = planResource.IsActive;
                planResourceList.Add(_mapper.Map<Plan, PlanResourceGet>(plan_));
            }
            return planResourceList;
        }

        // PUT: api/Plans/5
        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Put(int id, [FromBody] PlanResource planInput)
        {
            try
            {
                var plan = _mapper.Map<PlanResource, Plan>(planInput);
                var result = await _planDomain.update(id, plan);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar: "+ex);
            }
        }


        // Delete: api/Plans/5
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeletePlan(int id)
        {
            try
            {
                var result = await _planDomain.delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar");
            }
        }

    }
}
