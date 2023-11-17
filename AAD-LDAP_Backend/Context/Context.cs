using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace AAD_LDAP_Backend.Context
{
    public class ContextBasic : DbContext
    {
        public ContextBasic(DbContextOptions<ContextBasic> opt) : base(opt) { }

        DirectoryEntry entry = DirectoryEntry("LDAP://OU=Users,OU=Hauni Hungaria,DC=HUNGARIA,DC=KOERBER,DC=DE");
    }
}
