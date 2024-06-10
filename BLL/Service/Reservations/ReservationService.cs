using AutoMapper;
using BLL.DTO;
using BLL.Service._Generic;
using DAL.Models;
using DAL.Repositories.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Reservations
{
    public class ReservationService : GenericService<Reservation,  Reservationdto>, IReservationService
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper):base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
    }
}
