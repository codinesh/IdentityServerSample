using SocialLoginApi.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SocialLoginApi.Data
{
    public class MyDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public MyDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Match> Match { get; set; }
    }

   
}
