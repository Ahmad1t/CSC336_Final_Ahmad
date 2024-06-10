using AutoMapper;
using BLL.DTO;
using BLL.Service._Generic;
using BLL.Service.Passengers;
using DAL.Models;
using DAL.Repositories._Generic;
using DAL.Repositories.Airplanes;
using DAL.Repositories.Passengers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Airplanes
{
    public class AirplaneService : GenericService<Airplane , Airplanedto>, IAirplaneService
    {
        public readonly IAirplaneRepository _airplaneRepository;
        public readonly IMapper _mapper;

        public AirplaneService(IAirplaneRepository repository, IMapper mapper) : base(repository, mapper) 
        {
            _airplaneRepository = repository;
            _mapper = mapper;
        }
    }
}
