using Microsoft.EntityFrameworkCore;
using WebAPI_Portfolio.Models;

namespace WebAPI_Portfolio.Data
{
    public class ApiContext : DbContext
    {

        public DbSet<test> testProperty { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) :base(options)
        {

        }
    }
}
