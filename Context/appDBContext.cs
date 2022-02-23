using apiPruebaTecnica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPruebaTecnica.Context
{
    public class appDBContext : DbContext
    {
        public appDBContext(DbContextOptions<appDBContext> options) : base(options)
        {

        }
        public DbSet<Clientes> clientes{get; set; }
    }
}
