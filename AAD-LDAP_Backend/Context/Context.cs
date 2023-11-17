using Microsoft.EntityFrameworkCore;
using System.DirectoryServices;

namespace AAD_LDAP_Backend.Context
{
    public class ContextBasic : InterFace
    {

        DirectoryEntry domain = new DirectoryEntry("LDAP://OU=Users,OU=Hauni Hungaria,DC=HUNGARIA,DC=KOERBER,DC=DE");

        public Task<List<T>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ReadAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ReadByName(string? Name)
        {
            throw new NotImplementedException();
        }
    }
}