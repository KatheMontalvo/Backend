using backend_tc.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend_tc
{
    public class AplicationsDbContext : DbContext
    {
        DbSet<TarjetaCredito> TarjetaCredito { get; set;}
        public AplicationsDbContext(DbContextOptions<AplicationsDbContext> options): base(options)
        {

        }
    }
}
