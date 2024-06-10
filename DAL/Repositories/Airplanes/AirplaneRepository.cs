﻿using DAL.Models;
using DAL.Repositories._Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Airplanes
{
    public class AirplaneRepository : GenericRepository<Airplane>, IAirplaneRepository
    {
        public AirplaneRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {

        }
    }
}
