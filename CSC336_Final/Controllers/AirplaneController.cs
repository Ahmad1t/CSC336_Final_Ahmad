using BLL.DTO;
using BLL.Service.Airplanes;
using BLL.Service.Passengers;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : _GenericController<Airplanedto>
    {
        private readonly IAirplaneService _serive;

        public AirplaneController(IAirplaneService service) : base(service)
        {
            _serive = service;
        }
    }
}
