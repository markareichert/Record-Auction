using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecordAuction.Models;

namespace RecordAuction.Data
{
    public class RecordDbContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
        public DbSet<RecordCondition> RecordConditions { get; set; }

        public RecordDbContext(DbContextOptions<RecordDbContext> options)
        : base(options)
    {
        }
    }
}
