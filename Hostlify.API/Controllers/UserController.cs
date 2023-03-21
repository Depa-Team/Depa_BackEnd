using AutoMapper;
using Hostlify.API.Resource;
using Hostlify.API.Resources;
using Hostlify.Domain;
using Hostlify.Infraestructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hostlify.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserDomain _userDomain;
        private readonly IMapper _mapper;
        
        public UserController(IUserDomain userDomain,IMapper mapper)
        {
            _userDomain = userDomain;
            _mapper = mapper;
        }
        // GET: api/User
        [HttpPost] 
        [AllowAnonymous]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginResource LoginResource)
        { 
            var user = _mapper.Map<LoginResource,User>(LoginResource);
            var result = await _userDomain.Login(user);
            return Ok(result);
        }   
        
        // GET: api/User
        [HttpPost]
        [AllowAnonymous]
        [Route("Signup")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> Signup(UserResource userResource)
        {
            var user = _mapper.Map<UserResource,User>(userResource);
            var result = await _userDomain.Signup(user);
            return Ok();
        }
        
        // GET: api/User
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IEnumerable<string>), 200)]
        public async Task<List<UserResourceGet>> Get()
        {
            List<UserResourceGet> userResourceList = new List<UserResourceGet>();
            var result = _userDomain.GetAllUsers().Result.ToArray();
            foreach (var userResource in result)
            {
                var user_ = new User();
                user_.Name = userResource.Name;
                user_.Id = userResource.Id;
                user_.Email = userResource.Email;
                user_.Type = userResource.Type;
                user_.Plan = userResource.Plan;
                user_.Password = userResource.Password;
                user_.phoneNumber = userResource.phoneNumber;
                user_.DateCreated = userResource.DateCreated;
                user_.DateUpdated = userResource.DateUpdated;
                user_.IsActive = userResource.IsActive;
                userResourceList.Add(_mapper.Map<User, UserResourceGet>(user_));
            }
            return userResourceList;
        }
        

        // GET: api/User/5
        [AllowAnonymous]
        [ProducesResponseType(typeof(string), 200)]
        [HttpGet("{id}", Name = "Get")]
        public async Task<UserResourceGet> Get(int id)
        {
            User user_ = new User();
            var result = await _userDomain.GetByUserId(id);
            user_.Id = result.Id;
            user_.Name = result.Name;
            user_.Email = result.Email;
            user_.Type = result.Type;
            user_.Plan = result.Plan;
            user_.Password = result.Password;
            user_.phoneNumber = result.phoneNumber;
            user_.DateCreated=result.DateCreated;
            user_.DateUpdated=result.DateUpdated;
            user_.IsActive = result.IsActive;
            return _mapper.Map<User,UserResourceGet>(user_);
        }
        

        // DELETE: api/User/5
        [AllowAnonymous]
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(void), 200)]
        public async Task<bool> Delete(int id)
        {
            return await _userDomain.DeleteUser(id);
        }
    }
}
