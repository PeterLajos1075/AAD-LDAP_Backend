using AAD_LDAP_Backend.Entitys;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;

namespace AAD_LDAP_Backend.Context
{
    public class ContextBasic : InterFace
    {

        DirectoryEntry domain = new DirectoryEntry("LDAP://OU=Users,OU=Hauni Hungaria,DC=HUNGARIA,DC=KOERBER,DC=DE");



        public List<DirectoryEntity> ReadAll()
        {

            SearchResultCollection results;
            DirectorySearcher ds = null;

            ds = new DirectorySearcher(domain);

            ds.Filter = "(&(objectCategory=User)";

            results = ds.FindAll();

            List<DirectoryEntity> Users = new List<DirectoryEntity>();


            foreach (SearchResult sr in results)
            {
                DirectoryEntity us = new DirectoryEntity();
                us.Name = sr.Properties["Name"][0].ToString();
                us.sAMAccountName = sr.Properties["sAMAccountName"][0].ToString();
                us.department = sr.Properties["department"][0].ToString();
                us.mail = sr.Properties["mail"][0].ToString();
                us.extensionAttribute = sr.Properties["extensionAttribute"][0].ToString();
                us.manager = sr.Properties["manager"][0].ToString();
                Users.Add(us);
            }
            return Users;
        }
    }
}