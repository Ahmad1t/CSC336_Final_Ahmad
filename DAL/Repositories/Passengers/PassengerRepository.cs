using DAL.Models;
using DAL.Repositories._Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Repositories.Passengers.PassengerRepository;

namespace DAL.Repositories.Passengers
{
    public class PassengerRepository : GenericRepository<Passenger>, IPassengerRepository
    {
        public PassengerRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext) // base=super
        {

        }
    }
}
