using AAD_LDAP_Backend.Entitys;

public interface InterFace
{
    List<DirectoryEntity> ReadAllUsers();
    //Task<List<DirectoryEntity>> ReadByName(string? Name);
    //Task<List<DirectoryEntity>> ReadAllUsers();

}

