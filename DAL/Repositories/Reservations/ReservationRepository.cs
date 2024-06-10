using DAL.Models;
using DAL.Repositories._Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Reservations
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        ReservationRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {

        }
    }
}
