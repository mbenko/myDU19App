using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myDU19App.Models
{
    public class myDataContext : DbContext
    {
        public myDataContext (DbContextOptions<myDataContext> options)
            : base(options)
        {
        }

        public DbSet<myDU19App.Models.Chore> Chore { get; set; }
    }
}
