using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class JustDaitingContext :IdentityDbContext<AppUser,AppRole,string>
    {
        public JustDaitingContext(DbContextOptions<JustDaitingContext> options) : base(options)
        {

        }

    
    }
}
