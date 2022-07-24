using Microsoft.EntityFrameworkCore;
using TaskIt.Models;

namespace TaskIt.Data
{
    public class IssueDbContext: DbContext
    {

        public IssueDbContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Issue> Issues { get; set; }
    }
}
