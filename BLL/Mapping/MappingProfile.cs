using AutoMapper;
using BLL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapping
{
    public  class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Airplane, Airplanedto>().ReverseMap();
            CreateMap<Passenger, Passengerdto>().ReverseMap();
            CreateMap<Flight, Flightdto>().ReverseMap();
            CreateMap<Pilot, Pilotdto>().ReverseMap();
            CreateMap<Reservation, Reservationdto>().ReverseMap();
        }
    }
}
