using AAD_LDAP_Backend.Entitys;

public interface InterFace
{
    Task<List<DirectoryEntity>> ReadAll();
    Task<List<DirectoryEntity>> ReadByName(string? Name);
    Task<List<DirectoryEntity>> ReadAllUsers();

}

