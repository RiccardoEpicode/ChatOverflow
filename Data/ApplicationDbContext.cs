using Microsoft.EntityFrameworkCore;


namespace ChatOverflow.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

}
