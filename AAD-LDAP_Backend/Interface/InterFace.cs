using AAD_LDAP_Backend.Entitys;
using System.DirectoryServices;

public interface InterFace
{
    List<DirectoryEntity> ReadAllUsers();
    DirectoryEntity ReadByName(string Name);
    DirectoryEntity BuildUser(SearchResult sr);
}

