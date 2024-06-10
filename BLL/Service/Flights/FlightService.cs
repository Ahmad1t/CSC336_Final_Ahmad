using AutoMapper;
using BLL.DTO;
using BLL.Service._Generic;
using DAL.Models;
using DAL.Repositories.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Flights
{
    public class FlightService : GenericService<Flight , Flightdto > , IFlightService
    {
        public readonly IFlightRepository _flightRepository;
        public readonly IMapper _mapper;
        public FlightService(IFlightRepository flightRepository, IMapper mapper) : base(flightRepository, mapper)   
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }
    }
}
