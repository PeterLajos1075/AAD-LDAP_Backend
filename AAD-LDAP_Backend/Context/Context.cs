using Microsoft.EntityFrameworkCore;

namespace AAD_LDAP_Backend.Context
{
    public class ContextBasic : DbContext
    {
        public ContextBasic(DbContextOptions<ContextBasic> opt) : base(opt) { }
    }
}
