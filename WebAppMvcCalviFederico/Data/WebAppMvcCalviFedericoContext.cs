using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMvcCalviFederico.Models;

namespace WebAppMvcCalviFederico.Data
{
    public class WebAppMvcCalviFedericoContext : DbContext
    {
        public WebAppMvcCalviFedericoContext (DbContextOptions<WebAppMvcCalviFedericoContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMvcCalviFederico.Models.Anagrafica> Anagrafica { get; set; } = default!;
    }
}
