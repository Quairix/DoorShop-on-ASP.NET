﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA.Data.Entities;

namespace WA.Data
{
    public class WAContext : DbContext
    {
        public WAContext(DbContextOptions<WAContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
