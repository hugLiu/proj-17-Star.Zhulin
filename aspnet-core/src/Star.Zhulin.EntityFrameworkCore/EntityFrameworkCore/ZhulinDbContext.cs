using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Star.Zhulin.Authorization.Roles;
using Star.Zhulin.Authorization.Users;
using Star.Zhulin.MultiTenancy;

namespace Star.Zhulin.EntityFrameworkCore
{
    public class ZhulinDbContext : AbpZeroDbContext<Tenant, Role, User, ZhulinDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ZhulinDbContext(DbContextOptions<ZhulinDbContext> options)
            : base(options)
        {
        }
    }
}
