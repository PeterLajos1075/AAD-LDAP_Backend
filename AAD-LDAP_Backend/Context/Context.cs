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
        
        public List<DirectoryEntity> ReadAllUsers()
        {

            SearchResultCollection results;
            DirectorySearcher ds = new DirectorySearcher(domain);

            ds.Filter = "(&(objectCategory=User))";

            ds.PropertiesToLoad.Add("displayName");
            ds.PropertiesToLoad.Add("sAMAccountName");
            ds.PropertiesToLoad.Add("department");
            ds.PropertiesToLoad.Add("mail");
            ds.PropertiesToLoad.Add("extensionAttribute5");
            ds.PropertiesToLoad.Add("manager");
            
            results = ds.FindAll();


            List<DirectoryEntity> Users = new List<DirectoryEntity>();


            foreach (SearchResult sr in results)
            {
                DirectoryEntity us = new DirectoryEntity();


                us.DisplayName = sr.Properties.Contains("displayName") ? sr.Properties["displayName"][0].ToString()! : string.Empty;
                us.sAMAccountName = sr.Properties.Contains("sAMAccountName") ? sr.Properties["sAMAccountName"][0].ToString()! : string.Empty;
                us.department = sr.Properties.Contains("department") ? sr.Properties["department"][0].ToString()! : string.Empty;
                us.mail = sr.Properties.Contains("mail") ? sr.Properties["mail"][0].ToString()! : string.Empty;
                us.extensionAttribute = sr.Properties.Contains("extensionAttribute5") ? sr.Properties["extensionAttribute5"][0].ToString()! : string.Empty;
                us.manager = sr.Properties.Contains("manager") ? sr.Properties["manager"][0].ToString()! : string.Empty;




                Users.Add(us);
            }
            return Users;
        }
    }
}