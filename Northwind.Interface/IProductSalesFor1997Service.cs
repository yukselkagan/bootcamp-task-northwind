﻿using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IProductSalesFor1997Service : IGenericServise<ProductSalesFor1997, DtoProductSalesFor1997>
    {
        IQueryable ProductSalesFor1997Report();
    }
}
