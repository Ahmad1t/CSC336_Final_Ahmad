using BLL.DTO;
using BLL.Service._Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using AutoMapper;
using DAL.Repositories.Passengers;
namespace BLL.Service.Passengers
{
    public class PassengerService : GenericService<Passenger, Passengerdto>, IPassengerSerive
    {
        public readonly IPassengerRepository _repository;
        public readonly IMapper _mapper;

        public PassengerService(IPassengerRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
