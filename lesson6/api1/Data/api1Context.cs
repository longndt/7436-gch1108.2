using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api1.Models;

namespace api1.Data
{
    public class api1Context : DbContext
    {
        public api1Context (DbContextOptions<api1Context> options)
            : base(options)
        {
        }

        public DbSet<api1.Models.Mobile> Mobile { get; set; } = default!;
    }
}
