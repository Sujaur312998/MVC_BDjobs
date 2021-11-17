using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_Bdjobs.Models;

namespace web_Bdjobs.Data
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext>options):base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
    }
}
