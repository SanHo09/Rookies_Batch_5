﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebsite.Models;

namespace SalesWebsite.Backend.Data
{
    public class SalesWebsiteBackendContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public SalesWebsiteBackendContext (DbContextOptions<SalesWebsiteBackendContext> options)
            : base(options)
        {
        }

        internal object FindAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
