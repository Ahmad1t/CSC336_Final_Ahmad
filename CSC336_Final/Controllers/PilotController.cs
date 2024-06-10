using BLL.DTO;
using BLL.Service.Pilots;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotController : _GenericController<Pilotdto>
    {
        private readonly IPilotService _pilotService;

        public PilotController(IPilotService pilotService) : base(pilotService) 
        {
            _pilotService = pilotService;
        }
    }
}
