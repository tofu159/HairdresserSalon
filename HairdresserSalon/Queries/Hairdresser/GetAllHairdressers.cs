﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Convey.CQRS.Queries;
using HairdresserSalon.Models;

namespace HairdresserSalon.Queries.Hairdresser
{
    public class GetAllHairdressers : IQuery<IEnumerable<HairdresserModel>>
    {
    }
}
