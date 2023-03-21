using AutoMapper;
using Hostlify.API.Resource;
using Hostlify.API.Resources;
using Hostlify.Domain;
using Hostlify.Infraestructure;
using Hostlify.Infraestructure.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Hostlify.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryDomain _historyDomain;//Inyeccion
        private readonly IMapper _mapper;

        public HistoryController(IHistoryDomain historyDomain ,IMapper mapper)
        {
            _historyDomain = historyDomain;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        [AllowAnonymous]
        public async Task<IActionResult> Get() 
        {
            try
            {
                var result = await _historyDomain.getAll();
                return Ok(_mapper.Map<List<History>, List<HistoryResourceGet>>(result));
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar");
            }
            finally
            {
            
            }
        }

        
        [HttpGet]
        [AllowAnonymous]
        [Route("byManagerId")]
        public  async Task<List<HistoryResourceGet>> GetHistoryForManagerId(int managerId)
        {
            List<HistoryResourceGet> historyResourceList = new List<HistoryResourceGet>();
            var result = _historyDomain.getHistoryForManagerId(managerId).Result.ToArray();
            foreach (var historyResource in result)
            {
                var history_ = new History();
                history_.id = historyResource.id;
                history_.flatName= historyResource.flatName;   
                history_.managerId=historyResource.managerId;
                history_.guestName= historyResource.guestName;
                history_.initialDate= historyResource.initialDate;
                history_.endDate= historyResource.endDate;
                history_.price= historyResource.price;
                historyResourceList.Add(_mapper.Map<History, HistoryResourceGet>(history_));
            }
            return historyResourceList;
        } 
        
        [HttpPost]
        [AllowAnonymous]
        [Route("Post")]
        public async Task<IActionResult>  Post([FromBody] HistoryResource historyInput)
        {
            try
            {
              
               var history = _mapper.Map<HistoryResource, History>(historyInput); 
                var result = await _historyDomain.postHistory(history); 
                return StatusCode(StatusCodes.Status201Created, "history created");
            }
                                                                                                                
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar: "+ex);
            }
            finally
            {
                
            }
        }

        // DELETE
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _historyDomain.deleteHistory(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al procesar");
            }
        }
    }
}
