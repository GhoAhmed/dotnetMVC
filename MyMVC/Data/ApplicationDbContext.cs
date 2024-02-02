

using Microsoft.EntityFrameworkCore;

namespace MyMVC.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

}
