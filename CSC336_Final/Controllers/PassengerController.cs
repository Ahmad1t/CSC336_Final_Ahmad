using Microsoft.AspNetCore.Mvc;
using BLL.DTO;
namespace CSC336_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
/*    public class UsersController : _GenericController<Userdto>
    {
        private readonly IUserService _service;

        public UsersController(IUserService service) : base(service)
        {
            _service = service;
        }*/

        public class PassengerController : _GenericController<Passengerdto>
    {
        private readonly I
    }
}
