using AutoMapper;
using BLL.DTO;
using BLL.Service._Generic;
using DAL.Models;
using DAL.Repositories.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Pilots
{
    public class PilotService : GenericService<Pilot, Pilotdto>, IPilotService
    {
        public readonly IPilotRepository _pilotRepository;
        public readonly IMapper _mapper;

        public PilotService(IPilotRepository pilotRepository, IMapper mapper) : base(pilotRepository, mapper)
        {
            _pilotRepository = pilotRepository;
            _mapper = mapper;
        }
    }
}
