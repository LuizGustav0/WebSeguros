using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSeguros.Models;

namespace WebSeguros.Models
{
    public class WebSegurosContext : DbContext
    {
        public WebSegurosContext (DbContextOptions<WebSegurosContext> options)
            : base(options)
        {
        }

        public DbSet<WebSeguros.Models.Cliente> Cliente { get; set; }


        public DbSet<WebSeguros.Models.Carro> Carro { get; set; }
    }
}
