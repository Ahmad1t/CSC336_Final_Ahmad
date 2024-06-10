using DAL.Models;
using DAL.Repositories._Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Pilots
{
    public class PilotRepository : GenericRepository<Pilot>, IPilotRepository
    {
        PilotRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {
        }
    }
}
