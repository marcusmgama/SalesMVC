﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesMVC.Models
{
    public class SalesMVCContext : DbContext
    {
        public SalesMVCContext (DbContextOptions<SalesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departments> Departments { get; set; }
        public DbSet<Seller> Seller { get; set; }

        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
