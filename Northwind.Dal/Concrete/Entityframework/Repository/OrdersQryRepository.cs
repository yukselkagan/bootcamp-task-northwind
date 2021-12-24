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
    public class OrdersQryRepository : GenericRepository<OrdersQry>, IOrdersQryRepository
    {

        public OrdersQryRepository(DbContext context) : base(context)
        {
            
        }

        public IQueryable OrdersQryReport()
        {
            return dbset.AsQueryable();
        }
    }
}
