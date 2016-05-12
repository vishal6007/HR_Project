﻿using Data.Infrastructure;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData.Repositories
{
    public class EFErrorRepository : EFBaseEntityRepository<Error>, IErrorRepository
    {
        public EFErrorRepository(IDbFactory factory) : base(factory)
        {

        }
    }
}