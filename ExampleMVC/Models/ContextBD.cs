using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleMVC.Models
{
    public class ContextBD:DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base(options)
        {

        }
     

       
        public DbSet<Venta> venta { get; set; }

        public DbSet<Producto> producto { get; set; }

       


    }
}

