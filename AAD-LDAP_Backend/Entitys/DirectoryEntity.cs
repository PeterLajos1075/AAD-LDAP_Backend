﻿using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace AAD_LDAP_Backend.Entitys
{
    public class DirectoryEntity
    {
        public string? Name { get; set; }

        public string? sAMAccountName { get; set; }

        public string? department { get; set; }

        [EmailAddress]
        public string? mail { get; set; }

        public string? extensionAttribute { get; set; }

        public string? manager { get; set; }
    }
}
