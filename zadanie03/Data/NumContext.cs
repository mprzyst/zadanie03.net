using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zadanie03.Models;

namespace zadanie03.Data
{
    public class NumContext : IdentityDbContext<IdentityUser>
    {
        public NumContext(DbContextOptions options) : base(options) { }

        public DbSet<Num> Number { get; set; }
    }

}
