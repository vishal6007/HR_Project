﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotDomain.Entities.Setup
{
    public class VacancyStatus: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
