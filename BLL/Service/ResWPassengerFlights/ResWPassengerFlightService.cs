using AutoMapper;
using BLL.DTO;
using BLL.Wrapping;
using DAL.Repositories.Passengers;
using DAL.Repositories.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.ResWPassengerFlights
{
    public class ResWPassengerFlightService : IResWPassengerFlightSerive
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IPassengerRepository _passengerRepository;
        public readonly IMapper _mapper;

    public ResWPassengerFlightService(IReservationRepository reservationRepository, IPassengerRepository passengerRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _passengerRepository = passengerRepository;
            _mapper = mapper;
        }

        public ApiResponse<ResWPassengerFlightdto> ResWResWPassengerFlight(ResWPassengerFlightdto dto)
        {
            ApiResponse<ResWPassengerFlightdto> response = new ApiResponse<ResWPassengerFlightdto>();
            return response;
            try
            {

                
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
