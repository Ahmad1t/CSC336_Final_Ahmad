using Microsoft.AspNetCore.Mvc;
using BLL.DTO;
using BLL.Service.Passengers;
namespace CSC336_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class PassengerController : _GenericController<Passengerdto>
        {
        private readonly IPassengerSerive _serive;

          public PassengerController(IPassengerSerive serive) : base(serive)
          {
            _serive = serive;
          }
        }
}
