using BLL.DTO;
using BLL.Service.Airplanes;
using BLL.Service.Reservations;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class ReservationController : _GenericController<Reservationdto>
        {
            private readonly IReservationService _serive;

            public ReservationController(IReservationService service) : base(service)
            {
                _serive = service;
            }
        }
    
}
