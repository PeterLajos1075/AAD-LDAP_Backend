using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace AAD_LDAP_Backend.Entitys
{
    public class DirectoryEntity
    {
        public string? Name { get; set; }

        public string? sAMAccountName { get; set; }

        public string? department { get; set; }

        [EmailAddress, MaxLength(150, ErrorMessage = "MaxLength is 150")]
        public string? mail { get; set; }

        public string? extensionAttribute { get; set; }

        public string? manager { get; set; }
    }
}
