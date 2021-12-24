﻿using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class SummaryOfSalesByYearRepository : GenericRepository<SummaryOfSalesByYear>, ISummaryOfSalesByYearRepository
    {

        public SummaryOfSalesByYearRepository(DbContext context) : base(context)
        {
            
        }

        public IQueryable SummaryOfSalesByYearReport()
        {
            return dbset.AsQueryable();
        }
    }
}
